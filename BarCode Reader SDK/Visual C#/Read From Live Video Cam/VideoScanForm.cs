//*******************************************************************
//       ByteScout BarCode Reader SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Bytescout.BarCodeReader;
using TouchlessLib;


namespace ReadFromVideoCamera
{
    public partial class VideoScanForm: Form
    {
        /// <summary>
        /// Touchless lib manager object (to use it you should have TouchlessLib.dll and WebCamLib.dll)
        /// </summary>
        TouchlessMgr MANAGER;

        /// <summary>
        /// USED IN POPUP MODE ONLY (see ShowScanPopup() method)
        /// Close or not on the first barcode found
        /// (results are saved in m_foundBarcodes
        /// </summary>
        public bool CloseOnFirstBarcodeFound = false;

        /// <summary>
        /// Background worker
        /// </summary>
        BackgroundWorker bw = new BackgroundWorker();
        
        /// <summary>
        /// Delay to scan every (mseconds), default to scan every 800 mseconds
        /// </summary>
        const int SCAN_DELAY = 1500; // every 1.5 sec

        /// <summary>
        /// Default barcode type to scan.
        /// </summary>
	    private BarcodeTypeSelector m_barcodeTypeToScan = new BarcodeTypeSelector();

        /// <summary>
        /// Array with all latest barcodes from the last scanning session.
        /// </summary>
        public FoundBarcode[] m_foundBarcodes = null;
        
        /// <summary>
        /// Internal varaible to indicate working status.
        /// </summary>
        public static bool STATUS = true;

        /// <summary>
        /// Creates the form.
        /// </summary>
        public VideoScanForm()
        {
            InitializeComponent();

			// enable calling UI element 'ListBox' inside a thread
            CheckForIllegalCrossThreadCalls = false;
            lblScanning.Visible = false;
            bw.WorkerSupportsCancellation = true;

        }

        /// <summary>
        /// Finds barcodes from bitmap object
        /// </summary>
        /// <param name="img">input bitmap</param>
        private FoundBarcode[] findBarcodes(Bitmap img)
        {
            Reader reader = new Reader();

            try
            {
                reader.RegistrationName = VideoScanFormConstants.BARCODEREADERSDK_REGISTRATION_NAME;
                reader.RegistrationKey = VideoScanFormConstants.BARCODEREADERSDK_REGISTRATION_KEY;

                reader.BarcodeTypesToFind = GetBarcodeTypeToFindFromCombobox();

                //reader.MaxNumberOfBarcodesPerPage = 1;
                FoundBarcode[] result = reader.ReadFrom(img);

                String timeNow = string.Format("{0:HH:mm:ss:tt}", DateTime.Now);

                if (result != null && result.Length > 0)
                {
                    textAreaBarcodes.SelectionStart = 0;
                    textAreaBarcodes.SelectionLength = 0;
                    textAreaBarcodes.SelectedText = "\nTime: " + timeNow + "\n";

                    // insert barcodes into the text area output
                    foreach (FoundBarcode barcode in result)
                    {
                        // make a sound that we found the barcode (not working on x64 due to Microsoft changed it)
                        Console.Beep();
                        // form the string with barcode value
                        String barcodeValue = String.Format("Found: {0} {1}" + "\r\n", barcode.Type, barcode.Value);
                        // add barcode to the text area output
                        textAreaBarcodes.SelectedText = barcodeValue + "\n";
                        // update status text with number of barcodes
                        lblFoundBarcodes.Text = String.Format("Found {0} barcodes:", result.Length);
                    }
                }
                // make flickering for "Scanning..." label
                lblScanning.Visible = !lblScanning.Visible;
                lblScanning.Update();

                // return result with barcodes
                return result;
            }
            finally
            {
                reader.Dispose();
            }
        }

        /// <summary>
        /// Create touchless lib camera manager and initializes variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoScanForm_Load(object sender, EventArgs e)
        {
            // populate barcode types into the combobox
            PopulateBarcodeTypesCombobox();
            
            InitCamera();

            StartDecoding();
        }

        private void InitCamera()
        {
            try
            {
                // create touchless lib manager to work with video camera
                MANAGER = new TouchlessMgr();

                // iterate through available video camera devices
                foreach (Camera item in MANAGER.Cameras)
                {
                    // add to the list of available camera devices
                    cbCamera.Items.Add(item);
                }

                // select first available camera
                cbCamera.SelectedItem = MANAGER.Cameras[0];

                // setting default image dimensions, see also camera selection event
                MANAGER.Cameras[0].CaptureWidth = int.Parse(tbCameraWidth.Text);
                MANAGER.Cameras[0].CaptureHeight = int.Parse(tbCameraHeight.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No video camera available. Please connect the camera\n" + ex.Message);
            }


        }

        public void StartDecoding()
        {
            UpdateCameraSelection();

            //UpdateCameraSelection();

            // clear the rich text box output
            textAreaBarcodes.Clear();
            // clean list of barcodes
            m_foundBarcodes = null;

            // check if we have camera selected
            if (cbCamera.SelectedIndex != -1)
            {

                // set working status
                STATUS = true;

                // create new thread with image processing function
                bw.DoWork += new DoWorkEventHandler(doBarcodeDecoding);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);


                // update ui buttons
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                cbBarCodeType.Enabled = false;
                cbCamera.Enabled = false;
                lblScanning.Visible = true;
                tbCameraHeight.Enabled = false;
                tbCameraWidth.Enabled = false;
                lblScanning.Text = "Scanning...";

                // finally start the decoding thread
                bw.RunWorkerAsync(CloseOnFirstBarcodeFound);
            }
            else
            {
                MessageBox.Show("Please select the camera first !");
            }
        }


        /// <summary>
        /// Update picture box with the latest frame from video camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CurrentCamera_OnImageCaptured(object sender, CameraEventArgs e)
        {
            if (MANAGER != null)
            {
                Bitmap imagePreview = MANAGER.CurrentCamera.GetCurrentImage();
                // resize image into 320x240 and set to the preview
                pictureVideoPreview.Image = ResizeImage(imagePreview, 320, 240);
            }
        }

        // http://stackoverflow.com/questions/1195064/fastest-image-resizing-in-net
        public Image ResizeImage( Image img, int width, int height )
        {
            Bitmap b = new Bitmap( width, height ) ;
            using(Graphics g = Graphics.FromImage( b ))
            {       
                 g.DrawImage( img, 0, 0, width, height ) ;
            }

            return b ;
        }

        /// <summary>
        /// Start the scanning process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartDecoding();
        }

        /// <summary>
        /// Stops scanning process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopDecoding();
        }

        private void StopDecoding()
        {
            bw.CancelAsync();

            // update ui elements
            //lblScanning.Visible = false;

            // change working status
            STATUS = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            cbBarCodeType.Enabled = true;
            cbCamera.Enabled = true;

            tbCameraHeight.Enabled = true;
            tbCameraWidth.Enabled = true;


            if (CloseOnFirstBarcodeFound && m_foundBarcodes != null && m_foundBarcodes.Length > 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }

        /// <summary>
        /// Function to read barcodes from image (used by new created Thread object)
        /// </summary>
        public void doBarcodeDecoding(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            bool closeOnFirstBarcode = (bool)e.Argument;

            while (true)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    // work while user has not changed the status to false (i.e. false meanse user canceled the scan)
                    // get current frame bitmap from camera using Touchless lib
                    Bitmap bitmap = MANAGER.CurrentCamera.GetCurrentImage();

                    // search for bar codes
                    FoundBarcode[] result = null;

                    if (bitmap != null)
                        result = findBarcodes(bitmap);

                    // check if we need to stop on first barcode found
                    if (closeOnFirstBarcode && result != null && result.Length > 0)
                    {
                        e.Result = result;
                        return; // end processing
                    }

                    // wait for a little to lower the CPU load
                    Thread.Sleep(SCAN_DELAY);
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // clear last results
            m_foundBarcodes = null;

            // if cancaled
            if ((e.Cancelled == true))
            {
                lblScanning.Visible = true;
                this.lblScanning.Text = "Canceled";
            }
            // if some error
            else if (!(e.Error == null))
            {
                lblScanning.Visible = true;
                this.lblScanning.Text = "Error: " + e.Error.Message;
            }

            else
            {
                lblScanning.Visible = true;
                this.lblScanning.Text = "Done!";
                m_foundBarcodes = (FoundBarcode[])e.Result;
            }

            StopDecoding();
        }


        /// <summary>
        /// Update camera according to use selection of camera from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCameraSelection();
        }

        private void UpdateCameraSelection()
        {
            if (cbCamera.Items.Count > 0 && cbCamera.SelectedIndex >-1)
            {
                if (MANAGER.CurrentCamera != null)
                    MANAGER.CurrentCamera.OnImageCaptured -= CurrentCamera_OnImageCaptured;

                Camera CurrentCamera = MANAGER.Cameras[cbCamera.SelectedIndex];

                if (CurrentCamera != null)
                {
                    // setting camera output image dimensions

                    CurrentCamera.CaptureWidth = int.Parse(tbCameraWidth.Text);
                    CurrentCamera.CaptureHeight = int.Parse(tbCameraHeight.Text);

                    CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(CurrentCamera_OnImageCaptured);

                    MANAGER.CurrentCamera = CurrentCamera;
                }
            }
        }

        /// <summary>
        /// Updates current symbology filter selection to scan according to the selection in the combobox
        /// </summary>
        /// <returns></returns>
		private BarcodeTypeSelector GetBarcodeTypeToFindFromCombobox()
		{
            string selectedItemText = cbBarCodeType.Text;

            if (string.IsNullOrEmpty(selectedItemText))
                throw new Exception("empty barcode type selection!");

            // iterate through properties of barcode selector 
            // and enable the selected property

            // reset all barcodes selections
            m_barcodeTypeToScan.Reset();

            // iterate through m_barcodeTypeToScan bool properties 
            // checking if we should check this barcode type value
            foreach (System.Reflection.PropertyInfo propinfo in m_barcodeTypeToScan.GetType().GetProperties())
            {
                // continue if can not write to propery
                if (!propinfo.CanWrite)
                    continue;

                string name = propinfo.Name;
                if (name == selectedItemText)
                    propinfo.SetValue(m_barcodeTypeToScan, true, null);
            }

            return m_barcodeTypeToScan;
        }

        protected void PopulateBarcodeTypesCombobox()
        {
            cbBarCodeType.Items.Clear();
            foreach (System.Reflection.PropertyInfo propinfo in m_barcodeTypeToScan.GetType().GetProperties())
            {
                // continue if can not write to propery
                if (!propinfo.CanWrite)
                    continue;

                string name = propinfo.Name;
                cbBarCodeType.Items.Add(name);
            }

            cbBarCodeType.Sorted = true;

            // select first item in barcode types combobox (first is FindAll )
            cbBarCodeType.SelectedItem = cbBarCodeType.Items[0]; 


        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Deinitialize();
        }

        private void Deinitialize()
        {
            // cancel decoding thread
            bw.CancelAsync();
            // deinit camera
            DeinitCamera();
            // mark as closed
            IsClosed = true;

        }

        private void DeinitCamera()
        {
            if (MANAGER != null)
            {
                if (MANAGER.CurrentCamera != null)
                {
                    MANAGER.CurrentCamera.OnImageCaptured -= CurrentCamera_OnImageCaptured;
                    MANAGER.CurrentCamera = null;
                }
            }
            if (cbCamera.SelectedItem != null)
                cbCamera.SelectedItem = null;
            cbCamera.Items.Clear();
            MANAGER = null;
            Thread.Sleep(500);
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            // click on stop button to stop any scan if any
            btnStop_Click(null, null);

            // deinit the current camera
            DeinitCamera();

            ShowScanPopup();

            // reiniit current camera
            InitCamera();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ShowScanPopup()
        {

            this.Hide();

            try
            {

                // this block to create another instance to scan barcodes
                VideoScanForm popup = new VideoScanForm();
                // set new popup position shifted by 20 pixels
                popup.Left = this.Left + 20;
                popup.Top = this.Top + 20;
                // set the new popup window to close on first found barcpde
                popup.CloseOnFirstBarcodeFound = true;
                // hide the btnTry button on new dialog window
                popup.btnTryPopup.Visible = false;
                popup.btnStop.Visible = false;
                popup.btnStart.Visible = false;

                // set the popup title
                popup.Text = "POPUP DIALOG - ONE TIME SCAN";

                // show the dialog
                if (popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // checking if one time scan dialog found barcodes 
                    if (popup.m_foundBarcodes != null && popup.m_foundBarcodes.Length > 0)
                        MessageBox.Show("Popup scan found the barcode:" + popup.m_foundBarcodes[0].Value, "POPUP RESULT");
                }
                else
                    MessageBox.Show("Popup canceled! Returning to the main window");

                // close the popup dialog
                popup.Close();
                // set to null
                popup = null;
            }
            finally 
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// indicates if the form is closed
        /// </summary>
        public bool IsClosed = false;

    }
}
