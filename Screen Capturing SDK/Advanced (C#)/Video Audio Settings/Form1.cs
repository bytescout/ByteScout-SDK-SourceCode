//*******************************************************************
//       ByteScout Screen Capturing SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;
using System.Drawing;

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference


namespace VideoAudioSettings
{
	public partial class Form1 : Form
	{
		private Capturer capturer = null;

		private bool _recording = false;
		private bool _paused = false;

		public Form1()
		{
			InitializeComponent();

			// Create Capturer instance
			capturer = new Capturer();
			capturer.RegistrationName = "demo"; // put your registration name here
			capturer.RegistrationKey = "demo";  // put your registration key here
			

			// Get list of available audio devices
			for (int i = 0; i < capturer.AudioDeviceCount; i++)
			{
				string line = capturer.GetAudioDeviceName(i);
				cmbAudioDevices.Items.Add(line);
			}

			// Select current audio device
			cmbAudioDevices.SelectedIndex = capturer.CurrentAudioDevice;

			// Get list of available AVI audio codecs
			for (int i = 0; i < capturer.AudioCodecsCount; i++)
			{
				string codec = capturer.GetAudioCodecName(i);
				cmbAviAudioCodecs.Items.Add(codec);
			}

			// Select current AVI audio codec
			cmbAviAudioCodecs.SelectedIndex = capturer.CurrentAudioCodec;


			// Get list of available web camera devices
			for (int i = 0; i < capturer.WebCamCount; i++)
			{
				string camera = capturer.GetWebCamName(i);
				cmbWebCameras.Items.Add(camera);
			}

			// Select current web camera
			if (cmbWebCameras.Items.Count != 0)
			{
				cmbWebCameras.SelectedIndex = capturer.CurrentWebCam;
			}
			else
			{
				cmbWebCameras.Items.Add("No devices");
				cmbWebCameras.SelectedIndex = 0;
				cmbWebCameras.Enabled = false;
				cbShowWebCamOverlay.Enabled = false;
			}

			// Get list of available AVI video codecs
			for (int i = 0; i < capturer.VideoCodecsCount; i++)
			{
				string codec = capturer.GetVideoCodecName(i);
				cmbAviVideoCodecs.Items.Add(codec);
			}

			// Select current AVI video codec
			cmbAviVideoCodecs.SelectedIndex = capturer.CurrentVideoCodec;

			// Get list of available WMV audio codecs
			for (int i = 0; i < capturer.WMVAudioCodecsCount; i++)
			{
				string codec = capturer.GetWMVAudioCodecName(i);
				cmbWmvAudioCodecs.Items.Add(codec);
			}

			// Select current WMV audio codec
			cmbWmvAudioCodecs.SelectedIndex = capturer.CurrentWMVAudioCodec;

			// Get list of available WMV video codecs
			for (int i = 0; i < capturer.WMVVideoCodecsCount; i++)
			{
				string codec = capturer.GetWMVVideoCodecName(i);
				cmbWmvVideoCodecs.Items.Add(codec);
			}

			// Select current WMV video codec
			cmbWmvVideoCodecs.SelectedIndex = capturer.CurrentWMVVideoCodec;


			// Fill list of FPS values
			cmbFPS.Items.AddRange(new object[] { 5f, 7.5f, 10f, 12f, 14.985f, 15f, 19.98f, 20f, 23.976f, 24f, 25f, 29.97f, 30f, 50f, 59.94f, 60 });
			// Select current FPS
			cmbFPS.SelectedItem = 14.985f;

			cbCaptureLayeredWindows.Checked = capturer.CaptureTransparentControls;

			nudMouseHotSpot.Value = capturer.MouseSpotRadius;
		}

		// Rectangular region recording mode is selected
		private void cbEnableAudio_CheckedChanged(object sender, EventArgs e)
		{
			cmbAudioDevices.Enabled = cbEnableAudio.Checked;
			cmbAudioLines.Enabled = cbEnableAudio.Checked;
		}

		private void cmbAudioDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();

			cmbAudioLines.Items.Clear();

			// Get list of available audio lines of current audio device
			for (int i = 0; i < capturer.CurrentAudioDeviceLineCount; i++)
			{
				string line = capturer.GetCurrentAudioDeviceLineName(i);
				cmbAudioLines.Items.Add(line);
			}

			// Select current audio line
            if (cmbAudioLines.Items.Count > 0)
            {
                cmbAudioLines.SelectedIndex = capturer.CurrentAudioDeviceLine;
            }
		}

		private void cmbWmvAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
		{
			capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();

			cmbWmvAudioFormats.Items.Clear();

			// Get list of available WMV audio formats
			for (int i = 0; i < capturer.WMVAudioFormatCount; i++)
			{
				string codec = capturer.GetWMVAudioFormatDescription(i);
				cmbWmvAudioFormats.Items.Add(codec);
			}

			// Select current WMV audio format
			cmbWmvAudioFormats.SelectedIndex = capturer.CurrentWMVAudioFormat;
		}

		private void rbRectRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Region around the mouse recording mode is selected
		private void rbRegionAroundMouse_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Full screen recording mode is selected
		private void rbFullscreen_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Show video code internal properties dialog
		private void btnVideoCodecProps_Click(object sender, System.EventArgs e)
		{
			capturer.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex;
			capturer.ShowVideoCodecSettingsDialog(Handle.ToInt32());
		}

		// Show log
		private void linkViewLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string logFile = Path.GetTempPath() + "Capturing Log.txt";

			if (File.Exists(logFile))
			{
				Process prc = new Process();
				prc.StartInfo.FileName = logFile;
				prc.StartInfo.UseShellExecute = true;

				try
				{
					prc.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}    
		
		private void btnStartRecording_Click(object sender, System.EventArgs e)
		{
			// Set up the capturer

			if (cbLog.Checked)
			{
				capturer.SetLogFile(Path.GetTempPath() + "Capturing Log.txt");
			}

			bool captureToAvi = (tabControl1.SelectedIndex == 1);

			capturer.AudioEnabled = cbEnableAudio.Checked;
			capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();
            if (cmbAudioLines.Items.Count>0)
            {
                capturer.CurrentAudioDeviceLineName = cmbAudioLines.SelectedItem.ToString();
            }
				
			if (captureToAvi)
			{
				capturer.CurrentAudioCodecName = cmbAviAudioCodecs.SelectedItem.ToString();
				capturer.CurrentVideoCodecName = cmbAviVideoCodecs.SelectedItem.ToString();
			}
			else // capture to WMV
			{
				capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();
				capturer.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex;
				capturer.CurrentWMVVideoCodecName = cmbWmvVideoCodecs.SelectedItem.ToString();
			}

			capturer.MouseAnimationDuration = 400;
			capturer.FPS = float.Parse(cmbFPS.Text);
			capturer.CaptureTransparentControls = cbCaptureLayeredWindows.Checked;
			capturer.MouseSpotRadius = (int) nudMouseHotSpot.Value;

			capturer.OutputWidth = int.Parse(tbWidth.Text);
			capturer.OutputHeight = int.Parse(tbHeight.Text);

			// Set capturing mode

			if (rbRectRegion.Checked)
			{
				capturer.CapturingType = CaptureAreaType.catRegion;
			}
			else if (rbRegionAroundMouse.Checked)
			{
				capturer.CapturingType = CaptureAreaType.catMouse;
			}
			else
			{
				capturer.CapturingType = CaptureAreaType.catScreen;
			}

			if (cbShowWebCamOverlay.Checked)
			{
				// Set web camera device to add overlaying video to the source
				capturer.AddWebCamVideo = true;

				// Set device name or you can set device by index using .CurrentCaptureDevice property
				capturer.CurrentWebCam = cmbWebCameras.SelectedIndex;

				// Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10,10)
				capturer.SetWebCamVideoRectangle(
					int.Parse(tbWebCameraX.Text), 
					int.Parse(tbWebCameraY.Text), 
					int.Parse(tbWebCameraWidth.Text), 
					int.Parse(tbWebCameraHeight.Text));
			}


            // set border around captured area if we are not capturing entire screen
            if (
                capturer.CapturingType != CaptureAreaType.catScreen &&
                capturer.CapturingType != CaptureAreaType.catWebcamFullScreen
                )
            {
                // set border style
                capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
                capturer.CaptureAreaBorderColor = (uint)ColorTranslator.ToOle(Color.Red);
            }

			// Save to temp file

			String filename = Path.GetTempFileName();
			filename = Path.ChangeExtension(filename, captureToAvi ? "avi" : "wmv");
			capturer.OutputFileName = filename;
			
			try
			{
				// Start capturing
				try
				{
					Cursor = Cursors.WaitCursor;
					capturer.Run();
				}
				finally
				{
					Cursor = Cursors.Default;
				}

				_recording = true;
				btnStartRecording.Enabled = false;
				btnPauseRecording.Enabled = true;
				btnStopRecording.Enabled = true;

				// Wait for "Stop Recording" button pressed
				while (_recording)
				{
					Thread.Sleep(10);
					Application.DoEvents();
				}

				// Stop capturing
				try
				{
					Cursor = Cursors.WaitCursor;
					capturer.Stop();
				}
				finally
				{
					Cursor = Cursors.Default;
				}

				// Ask for output file name
				SaveFileDialog dlg = new SaveFileDialog();

				dlg.Title = @"Save captured video as";
				dlg.FileName = @"Screencast";

				if (captureToAvi)
				{
					dlg.DefaultExt = @"*.avi";
					dlg.Filter = @"AVI files (*.avi)|*.avi|All files (*.*)|*.*";
				}
				else
				{
					dlg.DefaultExt = @"*.wmv";
					dlg.Filter = @"WMV files (*.wmv)|*.wmv|All files (*.*)|*.*";
				}
				
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save to specified file name
					File.Copy(capturer.OutputFileName, dlg.FileName, true);
				}

				// clean up
				try
				{
					File.Delete(capturer.OutputFileName);
				}
				catch
				{
				}

				btnStartRecording.Enabled = true;
				btnPauseRecording.Enabled = false;
				btnStopRecording.Enabled = false;

                // open saved video in default video viewer
				try
				{
					Process.Start(dlg.FileName);
				}
				catch
				{
				}
			}
			catch (COMException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnPauseRecording_Click(object sender, EventArgs e)
		{
			bool captureToAvi = (tabControl1.SelectedIndex == 1);

			if (captureToAvi)
			{
				MessageBox.Show("Pausing is only available for WMV format yet.");
				return;
			}

			if (!_paused)
			{
				capturer.Pause();
				_paused = true;
				btnPauseRecording.Text = "Resume recodring";
			}
			else
			{
				// Resume capturing
				capturer.Run(); 
				_paused = false;
				btnPauseRecording.Text = "Pause recording";
			}
		}

		private void btnStopRecording_Click(object sender, System.EventArgs e)
		{
			// Toggle recording flag
			if (_recording)
			{
				_recording = false;
			}
		}
	}
}
