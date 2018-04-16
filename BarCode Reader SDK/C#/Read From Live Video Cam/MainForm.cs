//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Bytescout.BarCodeReader;
using TouchlessLib;


namespace ReadFromVideoCamera
{
    public partial class MainForm: Form
    {
		// Scan delay, ms.
		const int SCAN_DELAY = 1500; // scan barcodes every 1.5 sec

		// Touchless SDK library manager (to use it you should have TouchlessLib.dll referenced and WebCamLib.dll in the build output directory)
	    readonly TouchlessMgr _touchlessLibManager;

        // Background thread for barcode scanning
        readonly BackgroundWorker _backgroundWorker = new BackgroundWorker();
		// Synchronization event
	    readonly AutoResetEvent _synchronizationEvent = new AutoResetEvent(false);
        
		// Form constructor
		public MainForm()
        {
            InitializeComponent();

            // Create Touchless library manager
            _touchlessLibManager = new TouchlessMgr();

			// Setup background worker
            _backgroundWorker.WorkerSupportsCancellation = true;
			_backgroundWorker.DoWork += BackgroundWorker_DoWork;
			_backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
		}

	    // On form loading 
        private void Form_Load(object sender, EventArgs e)
        {
            // Fill devices combobox with available video cameras
            foreach (Camera camera in _touchlessLibManager.Cameras)
                cmbCamera.Items.Add(camera);

            // Select the first available camera. See also cmbCamera_SelectedIndexChanged event handler.
	        if (_touchlessLibManager.Cameras.Count > 0)
		        cmbCamera.SelectedItem = _touchlessLibManager.Cameras[0];
	        else
		        MessageBox.Show("No video camera available. Please connect the camera.");

	        // Populate barcode types combobox
            PopulateBarcodeTypesCombobox();
			// Select some default barcode type
			cmbBarcodeType.SelectedItem = "QRCode";
        }

	    protected void PopulateBarcodeTypesCombobox()
	    {
		    cmbBarcodeType.Items.Clear();

		    foreach (PropertyInfo propertyInfo in typeof(BarcodeTypeSelector).GetProperties())
			    cmbBarcodeType.Items.Add(propertyInfo.Name);
	    }
		
		// On camera selected
        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_touchlessLibManager.CurrentCamera != null)
                _touchlessLibManager.CurrentCamera.OnImageCaptured -= CurrentCamera_OnImageCaptured;

			if (cmbCamera.SelectedIndex != -1)
			{
				Camera camera = _touchlessLibManager.Cameras[cmbCamera.SelectedIndex];

				if (camera != null)
				{
					// Set camera output image dimensions
					camera.CaptureWidth = int.Parse(tbCameraWidth.Text);
					camera.CaptureHeight = int.Parse(tbCameraHeight.Text);

					camera.OnImageCaptured += CurrentCamera_OnImageCaptured;

					// Select the camera
					_touchlessLibManager.CurrentCamera = camera;
				}
			}
        }

		private void btnUpdateCameraImageDimensions_Click(object sender, EventArgs e)
        {
            if (_touchlessLibManager.CurrentCamera != null)
            {
                // Update camera's output image dimensions
                _touchlessLibManager.CurrentCamera.CaptureWidth = int.Parse(tbCameraWidth.Text);
                _touchlessLibManager.CurrentCamera.CaptureHeight = int.Parse(tbCameraHeight.Text);
            }
        }

        public void StartDecoding()
        {
            if (cmbCamera.SelectedIndex == -1)
                return;

            // Clear the output text box
            rtbFoundBarcodes.Clear();

            // Check if we have camera selected
            if (cmbCamera.SelectedIndex != -1)
            {
				// Start the decoding in the background thread
	            BarcodeTypeSelector barcodeTypesToFind = GetBarcodeTypeFromCombobox();
	            _backgroundWorker.RunWorkerAsync(barcodeTypesToFind);

				UpdateControls(true);
			}
			else
            {
                MessageBox.Show("Please select the camera first!");
            }
        }

        private void StopDecoding()
        {
	        _backgroundWorker.CancelAsync();

			// Wait until BackgroundWorker finished
	        if (_backgroundWorker.IsBusy)
		        _synchronizationEvent.WaitOne();

	        UpdateControls(false);
        }

	    void UpdateControls(bool started)
	    {
		    if (started)
		    {
				btnStart.Enabled = false;
				btnStop.Enabled = true;
				cmbBarcodeType.Enabled = false;
				cmbCamera.Enabled = false;
			    tbCameraHeight.Enabled = false;
			    tbCameraWidth.Enabled = false;
			    btnUpdateCameraImageDimensions.Enabled = false;
			    cbStopOnFirstBarcode.Enabled = false;
			    lblScanning.Visible = true;
			    lblScanning.Text = "Scanning...";
		    }
		    else
		    {
				btnStart.Enabled = true;
				btnStop.Enabled = false;
				cmbBarcodeType.Enabled = true;
				cmbCamera.Enabled = true;
				cbStopOnFirstBarcode.Enabled = true;
				tbCameraHeight.Enabled = true;
				tbCameraWidth.Enabled = true;
				btnUpdateCameraImageDimensions.Enabled = true;
				lblScanning.Visible = true;
			}
	    }

        void CurrentCamera_OnImageCaptured(object sender, CameraEventArgs e)
        {
			pictureBoxPreview.Image = e.Image;
        }

	    private void btnStart_Click(object sender, EventArgs e)
        {
            StartDecoding();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopDecoding();
        }

        // Background thread procedure used by BackgroundWorker
		public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = (BackgroundWorker) sender;
			BarcodeTypeSelector barcodeTypesToFind = (BarcodeTypeSelector) e.Argument;

            // Create and setup barcode reader instance
			using (Reader reader = new Reader())
			{
				reader.RegistrationName = "demo";
				reader.RegistrationKey = "demo";

				reader.BarcodeTypesToFind = barcodeTypesToFind;

				// Work while not canceled
				while (true)
				{
					// Check cancellation
					if (worker.CancellationPending)
					{
						e.Cancel = true;
						_synchronizationEvent.Set();
						return;
					}

					// Get image from camera by invoking method from UI thread
					Bitmap bitmap = (Bitmap) Invoke(new GetCameraImageDelegate(GetCameraImage));
					if (bitmap == null)
					{
						e.Result = null;
						return;
					}

					// Search the image for barcodes
					FoundBarcode[] result = reader.ReadFrom(bitmap);

					// Update UI asynchronously
					BeginInvoke(new Action<FoundBarcode[]>(UpdateStatus), new object[] { result });

					// Pause
					Thread.Sleep(SCAN_DELAY);
				}
			}
		}

		delegate Bitmap GetCameraImageDelegate();

	    Bitmap GetCameraImage()
	    {
			if (!IsDisposed && !Disposing && _touchlessLibManager.CurrentCamera != null)
				return _touchlessLibManager.CurrentCamera.GetCurrentImage();

		    return null;
	    }

		// Update UI with found barcodes information
		void UpdateStatus(FoundBarcode[] foundBarcodes)
	    {
			if (foundBarcodes != null && foundBarcodes.Length > 0)
			{
				// Play sound if we found any barcode
				SystemSounds.Beep.Play();

				StringBuilder stringBuilder = new StringBuilder();

				stringBuilder.AppendFormat("Time: {0:HH:mm:ss:tt}", DateTime.Now);
				stringBuilder.AppendLine();

				// Display found barcodes in the output text box
				foreach (FoundBarcode barcode in foundBarcodes)
				{
					stringBuilder.AppendFormat("Found barcode: {0} {1}", barcode.Type, barcode.Value);
					stringBuilder.AppendLine();
				}

				rtbFoundBarcodes.Text = stringBuilder.ToString();

				// Update status text with number of found barcodes
				lblFoundBarcodes.Text = string.Format("Found {0} barcodes:", foundBarcodes.Length);
			}

			// Make "Scanning..." label flicker.
			lblScanning.Visible = !lblScanning.Visible;
			lblScanning.Refresh();

			// Check if we need to stop on first barcode found
			if (cbStopOnFirstBarcode.Checked && foundBarcodes != null && foundBarcodes.Length > 0)
			{
				StopDecoding();
			}
		}

		// Background thread is finished
	    private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	    {
			// Update UI asynchronously
			BeginInvoke(new Action<RunWorkerCompletedEventArgs>(OnBackgroundWorkerFinished), new object[] { e });
	    }

	    void OnBackgroundWorkerFinished(RunWorkerCompletedEventArgs completedEventArgs)
	    {
			if (completedEventArgs.Cancelled)
			{
				lblScanning.Text = "Stopped";
			}
			else if (completedEventArgs.Error != null)
			{
				lblScanning.Text = "Error: " + completedEventArgs.Error.Message;
			}
			else
			{
				lblScanning.Text = "Done!";
			}

			UpdateControls(false);
		}

		// Gets selected barcode type
		private BarcodeTypeSelector GetBarcodeTypeFromCombobox()
		{
			BarcodeTypeSelector result = new BarcodeTypeSelector();

			string selectedBarcodeTypeName = (string) cmbBarcodeType.SelectedItem;

	        PropertyInfo propertyInfo = typeof(BarcodeTypeSelector).GetProperty(selectedBarcodeTypeName);
			propertyInfo.SetValue(result, true, null);

			return result;
        }

	    protected override void OnClosing(CancelEventArgs e)
        {
			StopDecoding();
			
			_touchlessLibManager.Dispose();

			base.OnClosing(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.OK;
            Close();
        }

		private void btnCameraProperties_Click(object sender, EventArgs e)
		{
			try
			{
				if (_touchlessLibManager.CurrentCamera != null)
					_touchlessLibManager.CurrentCamera.ShowPropertiesDialog(Handle);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
    }
}
