//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ScreenCapturing.Properties;
using BytescoutScreenCapturingLib;


// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference


namespace ScreenCapturing
{
	public sealed partial class MainForm : Form
	{
	    private bool _recording;
	    private ToolStripDropDown _dropDownItems;
        private Rectangle _recordingRegion = Rectangle.Empty;
	    private Thread _capturingThread;
	    private CapturingThreadData _capturingThreadData;
	    private string _lastRecordedFile;

        private const int MYKEYID = 0;
        private const int WM_HOTKEY = 0x0312;
	    private const int WM_MOUSEMOVE = 0x0200;
        private const int MOD_ALT = 1;
        private const int MOD_CONTROL = 2;
        private const int MOD_SHIFT = 4;

        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hWnd, int id, int modifier, Keys vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

		public MainForm()
		{
			InitializeComponent();

			Point location = Program.Cfg.WindowLocation;

			if (location.IsEmpty)
			{
				StartPosition = FormStartPosition.CenterScreen;
			}
			else
			{
				Location = location;
			}

			Text = Application.ProductName + " " + Application.ProductVersion;
        }

		private void tsmiFullScreen_Click(object sender, EventArgs e)
        {
			_recordingRegion = Screen.PrimaryScreen.Bounds;
            
			StartRecording(CaptureAreaType.catScreen, sender == tsmiFullScreen);
        }

	    private void tsmiMouseRegion_Click(object sender, EventArgs e)
	    {
			_recordingRegion.Width = Program.Cfg.OutputWidth;
			_recordingRegion.Height = Program.Cfg.OutputHeight;

            StartRecording(CaptureAreaType.catMouse, sender == tsmiMouseRegion);
	    }

	    private void tsbRecord_Click(object sender, EventArgs e)
	    {
			if (_recording)
			{
				StopRecording();
			}
	    }

		private void tsbPlay_Click(object sender, EventArgs e)
	    {
            Process prc = new Process();
            prc.StartInfo.FileName = _lastRecordedFile;
			prc.StartInfo.UseShellExecute = true;

			try
			{
				prc.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName);
			}
	    }

	    private void tsbSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm f = new SettingsForm())
            {
            	f.ShowDialog();
            }
        }

	    private void StartRecording(CaptureAreaType captureType, bool withCam)
	    {
            _recording = true;

			if (withCam)
			{
				_dropDownItems = tsbRecordWithCam.DropDown;
				tsbRecord.Enabled = false;
				tsbRecordWithCam.ShowDropDownArrow = false;
				tsbRecordWithCam.DropDown = null;
				tsbRecordWithCam.Image = Resources.stop;
				tsbRecordWithCam.Text = "Stop";
			}
			else
			{
				_dropDownItems = tsbRecord.DropDown;
				tsbRecordWithCam.Enabled = false;
				tsbRecord.ShowDropDownArrow = false;
				tsbRecord.DropDown = null;
				tsbRecord.Image = Resources.stop;
				tsbRecord.Text = "Stop";
			}           

			statusBar.Items[0].Text = "Recording started";
			tsbPlay.Enabled = false;

	        if (!Program.Cfg.DoNotShowMessage1)
	        {
				CustomMessageBox mb = new CustomMessageBox(Application.ProductName, "Press CTRL-SHIFT-F12 to stop recording.");
                mb.StartPosition = FormStartPosition.CenterScreen;
	            mb.ShowDialog();
	            Program.Cfg.DoNotShowMessage1 = mb.DoNotShow;
	        }

            RegisterHotKey(Handle, MYKEYID, MOD_CONTROL + MOD_SHIFT, Keys.F12);

            _capturingThreadData = new CapturingThreadData();

            _capturingThreadData.CaptureType = captureType;
            _capturingThreadData.CaptureRectangle = _recordingRegion;
	    	_capturingThreadData.ShowWebCamStream = withCam;

            _capturingThread = new Thread(CapturingThread.ThreadProc);
            _capturingThread.Start(_capturingThreadData);

            WindowState = FormWindowState.Minimized;
	    }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == MYKEYID)
            {
                if (_recording)
                {
                	StopRecording();
                }
            }

            base.WndProc(ref m);
        }

	    private void StopRecording()
		{
	    	Cursor = Cursors.WaitCursor;

	    	try
	    	{
	    		_capturingThread.Interrupt();
	    		_capturingThread.Join();
	    	}
	    	finally
	    	{
				Cursor = Cursors.Default;
	    	}

			_recording = false;

			if (!tsbRecord.Enabled)
			{
				tsbRecordWithCam.ShowDropDownArrow = true;
				tsbRecordWithCam.DropDown = _dropDownItems;
				tsbRecordWithCam.Image = Resources.record_cam;
				tsbRecordWithCam.Text = "Record with webcam";
				_dropDownItems = null;
				tsbRecord.Enabled = true;
			}
			else
			{
				tsbRecord.ShowDropDownArrow = true;
				tsbRecord.DropDown = _dropDownItems;
				tsbRecord.Image = Resources.record;
				tsbRecord.Text = "Record";
				_dropDownItems = null;
				tsbRecordWithCam.Enabled = true;
			}

            UnregisterHotKey(Handle, MYKEYID);
            WindowState = FormWindowState.Normal;
            SetForegroundWindow(Handle);

            if (_capturingThreadData.Result != 0)
            {
                statusBar.Items[0].Text = "Recording failed";
                MessageBox.Show("Capturing failed.\n\nError: " + _capturingThreadData.ErrorText);
            }
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();

				if (Program.Cfg.SelectedVideoCodecTab == 0)
				{
					dlg.DefaultExt = "*.wmv";
					dlg.Filter = "WMV files (*.wmv)|*.wmv|All files (*.*)|*.*";
				}
				else
				{
					dlg.DefaultExt = "*.avi";
					dlg.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
				}

				DateTime now = DateTime.Now;
	            string fileName = string.Format("Screencast-{0}-{1:00}-{2:00}-{3:00}-{4:00}", now.Year, now.Month, now.Day, now.Hour, now.Minute);

				dlg.FileName = fileName;
			    dlg.Title = "Save captured video as";
			    dlg.InitialDirectory = Program.Cfg.LastUsedFolder;

			    if (dlg.ShowDialog() == DialogResult.OK)
			    {
                    File.Copy(_capturingThreadData.TempFile, dlg.FileName, true);
			        
                    _lastRecordedFile = dlg.FileName;
                    statusBar.Items[0].Text = "Successfully recorded \"" + Path.GetFileName(dlg.FileName) + "\"";
                    tsbPlay.Enabled = File.Exists(_lastRecordedFile);
                    Program.Cfg.LastUsedFolder = Path.GetDirectoryName(dlg.FileName);

                    // open saved video file in the default media player
                    Process.Start(dlg.FileName);
                }
			    else
			    {
                    statusBar.Items[0].Text = "Canceled";
			    }

		        try
		        {
		            File.Delete(_capturingThreadData.TempFile);
		        }
		        catch
		        {
		        }
            }
		}

		protected override void OnLocationChanged(EventArgs e)
		{
			Program.Cfg.WindowLocation = Location;
			base.OnLocationChanged(e);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (_recording)
			{
				StopRecording();
			}

			Program.Cfg.Save();
			base.OnClosing(e);
		}

        private void tsmiRectangularRegion_Click(object sender, EventArgs e)
        {
            RegionSelector rs = new RegionSelector();
            
			if (rs.ShowDialog() != DialogResult.Abort)
            {
            	_recordingRegion = rs.SelectedRectangle;
				StartRecording(CaptureAreaType.catRegion, sender == tsmiRectangularRegion);
            }
        }
	}
}
