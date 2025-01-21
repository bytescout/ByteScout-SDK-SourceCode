//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
    public partial class SettingsForm : Form
    {
    	private readonly Capturer _tempCapturer;
    		
    	public SettingsForm()
        {
			InitializeComponent();

			lblProductName.Text = Application.ProductName;
			lblProductVersion.Text = "Version " + Application.ProductVersion;

			_tempCapturer = new Capturer();
    		_tempCapturer.RegistrationName = "demo";
			_tempCapturer.RegistrationKey = "demo";

			cmbFPS.Items.AddRange(new object[] { 5f, 7.5f, 10f, 12f, 14.985f, 15f, 19.98f, 20f, 23.976f, 24f, 25f, 29.97f, 30f, 50f, 59.94f, 60 });
			
			if (_tempCapturer.AudioDeviceCount == 0)
	        {
		        cbEnableAudio.Checked = false;
		        cbEnableAudio.Enabled = false;

				cmbAudioDevices.Items.Add("No audio devices found.");
		        cmbAudioDevices.SelectedIndex = 0;
		        cmbAudioDevices.Enabled = false;

		        cmbAudioLines.Enabled = false;
	        }
	        else
	        {
		        cbEnableAudio.Checked = Program.Cfg.EnableAudio;

				for (int i = 0; i < _tempCapturer.AudioDeviceCount; i++)
		        {
			        string device = _tempCapturer.GetAudioDeviceName(i);
			        cmbAudioDevices.Items.Add(device);
		        }
	        }

			for (int i = 0; i < cmbAudioDevices.Items.Count; i++)
			{
				if (cmbAudioDevices.Items[i].ToString() == Program.Cfg.AudioDevice)
				{
					cmbAudioDevices.SelectedIndex = i;
					break;
				}
			}

			if (cmbAudioDevices.SelectedIndex == -1)
			{
				cmbAudioDevices.SelectedItem = _tempCapturer.CurrentAudioDeviceName;
				Program.Cfg.AudioDevice = _tempCapturer.CurrentAudioDeviceName;
			}

        	for (int i = 0; i < _tempCapturer.AudioCodecsCount; i++)
        	{
        		string codec = _tempCapturer.GetAudioCodecName(i);
        		cmbAviAudioCodecs.Items.Add(codec);
        	}

			for (int i = 0; i < cmbAviAudioCodecs.Items.Count; i++)
			{
				if (cmbAviAudioCodecs.Items[i].ToString() == Program.Cfg.AviAudioCodec)
				{
					cmbAviAudioCodecs.SelectedIndex = i;
					break;
				}
			}

			if (cmbAviAudioCodecs.SelectedIndex == -1)
			{
				cmbAviAudioCodecs.SelectedItem = _tempCapturer.CurrentAudioCodecName;
				Program.Cfg.AviAudioCodec = _tempCapturer.CurrentAudioCodecName;
			}

            if (_tempCapturer.WebCamCount > 0)
            {

                for (int i = 0; i < _tempCapturer.WebCamCount; i++)
                {
                    string camera = _tempCapturer.GetWebCamName(i);
                    cmbWebCameras.Items.Add(camera);
                }

                for (int i = 0; i < cmbWebCameras.Items.Count; i++)
                {
                    if (cmbWebCameras.Items[i].ToString() == Program.Cfg.WebCameraDevice)
                    {
                        cmbWebCameras.SelectedIndex = i;
                        break;
                    }
                }

                if (cmbWebCameras.SelectedIndex == -1 && cmbWebCameras.Items.Count > 0)
                {
                    cmbWebCameras.SelectedIndex = _tempCapturer.CurrentWebCam;
                    Program.Cfg.WebCameraDevice = _tempCapturer.CurrentWebCamName;
                }
            }
            else 
			{
                cmbWebCameras.Enabled = false;
                tbWebCameraHeight.Enabled = false;
                tbWebCameraWidth.Enabled = false;
                tbWebCameraX.Enabled = false;
                tbWebCameraY.Enabled = false;
            }

			for (int i = 0; i < _tempCapturer.VideoCodecsCount; i++)
        	{
        		string codec = _tempCapturer.GetVideoCodecName(i);
        		cmbAviVideoCodecs.Items.Add(codec);
        	}

			for (int i = 0; i < cmbAviVideoCodecs.Items.Count; i++)
            {
				if (cmbAviVideoCodecs.Items[i].ToString() == Program.Cfg.AviVideoCodec)
                {
					cmbAviVideoCodecs.SelectedIndex = i;
                    break;
                }
            }

			if (cmbAviVideoCodecs.SelectedIndex == -1)
            {
				cmbAviVideoCodecs.SelectedItem = _tempCapturer.CurrentVideoCodecName;
                Program.Cfg.AviVideoCodec = _tempCapturer.CurrentVideoCodecName;
            }

			for (int i = 0; i < _tempCapturer.WMVAudioCodecsCount; i++)
			{
				string codec = _tempCapturer.GetWMVAudioCodecName(i);
				cmbWmvAudioCodecs.Items.Add(codec);
			}

			for (int i = 0; i < cmbWmvAudioCodecs.Items.Count; i++)
			{
				if (cmbWmvAudioCodecs.Items[i].ToString() == Program.Cfg.WmvAudioCodec)
				{
					cmbWmvAudioCodecs.SelectedIndex = i;
					break;
				}
			}

			if (cmbWmvAudioCodecs.SelectedIndex == -1)
			{
				cmbWmvAudioCodecs.SelectedItem = _tempCapturer.CurrentWMVAudioCodecName;
				Program.Cfg.WmvAudioCodec = _tempCapturer.CurrentWMVAudioCodecName;
			}

			for (int i = 0; i < _tempCapturer.WMVVideoCodecsCount; i++)
			{
				string codec = _tempCapturer.GetWMVVideoCodecName(i);
				cmbWmvVideoCodecs.Items.Add(codec);
			}

			for (int i = 0; i < cmbWmvVideoCodecs.Items.Count; i++)
			{
				if (cmbWmvVideoCodecs.Items[i].ToString() == Program.Cfg.WmvVideoCodec)
				{
					cmbWmvVideoCodecs.SelectedIndex = i;
					break;
				}
			}

			if (cmbWmvVideoCodecs.SelectedIndex == -1)
			{
				cmbWmvVideoCodecs.SelectedItem = _tempCapturer.CurrentWMVVideoCodecName;
				Program.Cfg.WmvVideoCodec = _tempCapturer.CurrentWMVVideoCodecName;
			}

    	    cbResizeVideo.Checked = Program.Cfg.ResizeOutputVideo;
    	    tbWidth.Text = Program.Cfg.OutputWidth.ToString();
    	    tbHeight.Text = Program.Cfg.OutputHeight.ToString();
    	    cbKeepAspectRatio.Checked = Program.Cfg.KeepAspectRatio;
            cmbFPS.Text = Program.Cfg.FPS.ToString();
    	    cbLog.Checked = Program.Cfg.WriteLog;

    		tbWebCameraX.Text = Program.Cfg.WebCameraWindowX.ToString();
    		tbWebCameraY.Text = Program.Cfg.WebCameraWindowY.ToString();
			tbWebCameraWidth.Text = Program.Cfg.WebCameraWindowWidth.ToString();
			tbWebCameraHeight.Text = Program.Cfg.WebCameraWindowHeight.ToString();

            cmbAudioLines.Enabled = cbEnableAudio.Checked && _tempCapturer.AudioDeviceCount > 0;
            tbWidth.Enabled = cbResizeVideo.Checked;
    	    tbHeight.Enabled = cbResizeVideo.Checked;
    	    cbKeepAspectRatio.Enabled = cbResizeVideo.Checked;

    		tabControl2.SelectedIndex = Program.Cfg.SelectedVideoCodecTab;

    		cbCaptureMouseCursor.Checked = Program.Cfg.CaptureMouseCursor;
			cbShowMouseHotSpot.Checked = Program.Cfg.ShowMouseHotSpot;
			tbMouseAnimationDuration.Text = Program.Cfg.MouseAnimationDuration.ToString(CultureInfo.InvariantCulture);
			tbHotSpotRadius.Text = Program.Cfg.MouseSpotRadius.ToString(CultureInfo.InvariantCulture);
    		ccMouseHotSpotColor.ForeColor = Program.Cfg.MouseHotSpotColor;
			cbAnimateMouseClicks.Checked = Program.Cfg.AnimateMouseClicks;
			cbAnimateMouseButtons.Checked = Program.Cfg.AnimateMouseButtons;
			ccMouseCursorLeftClickAnimationColor.ForeColor = Program.Cfg.MouseCursorLeftClickAnimationColor;
			ccMouseCursorRightClickAnimationColor.ForeColor = Program.Cfg.MouseCursorRightClickAnimationColor;

    		cmbFrameType.Items.Add("None");
    		cmbFrameType.Items.Add("Solid");
    		cmbFrameType.Items.Add("Dashed");
    		cmbFrameType.Items.Add("Dotted");
    		cmbFrameType.SelectedIndex = (int) Program.Cfg.CaptureAreaBorderType;
    		ccFrameColor.ForeColor = Program.Cfg.CaptureAreaBorderColor;
    		tbFrameWidth.Text = Program.Cfg.CaptureAreaBorderWidth.ToString(CultureInfo.InvariantCulture);
        }

		private void cbEnableAudio_CheckedChanged(object sender, EventArgs e)
		{
		    cmbAudioDevices.Enabled = cbEnableAudio.Checked;
		    cmbAudioLines.Enabled = cbEnableAudio.Checked && _tempCapturer.AudioDeviceCount > 0;
		}

        private void cbResizeVideo_CheckedChanged(object sender, EventArgs e)
        {
            tbWidth.Enabled = cbResizeVideo.Checked;
            tbHeight.Enabled = cbResizeVideo.Checked;
            cbKeepAspectRatio.Enabled = cbResizeVideo.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
		{
			if (cbEnableAudio.Checked && _tempCapturer.AudioDeviceCount > 0 && 
			    _tempCapturer.CurrentAudioDeviceLineCount > 0 && cmbAudioLines.SelectedIndex == -1)
			{
                MessageBox.Show("Please select Audio Line", Application.ProductName);
				return;
			}

			if (_tempCapturer.WMVAudioCodecsCount > 0 && cmbWmvAudioFormats.SelectedIndex == -1)
			{
				MessageBox.Show("Please select WMV Audio Format", Application.ProductName);
				return;
			}

			try
			{
				Program.Cfg.SelectedVideoCodecTab = tabControl2.SelectedIndex;
				Program.Cfg.AudioDevice = cmbAudioDevices.SelectedItem.ToString();
                Program.Cfg.AudioLine = cmbAudioLines.SelectedItem != null ? cmbAudioLines.SelectedItem.ToString() : "";
                Program.Cfg.EnableAudio = cbEnableAudio.Checked;
                Program.Cfg.AviAudioCodec = cmbAviAudioCodecs.SelectedItem.ToString();
				Program.Cfg.AviVideoCodec = cmbAviVideoCodecs.SelectedItem.ToString();
				Program.Cfg.WmvAudioCodec = cmbWmvAudioCodecs.SelectedItem.ToString();
				Program.Cfg.WmvAudioFormat = cmbWmvAudioFormats.SelectedIndex;
				Program.Cfg.WmvVideoCodec = cmbWmvVideoCodecs.SelectedItem.ToString();
			    Program.Cfg.ResizeOutputVideo = cbResizeVideo.Checked;
			    Program.Cfg.OutputWidth = Int32.Parse(tbWidth.Text);
			    Program.Cfg.OutputHeight = Int32.Parse(tbHeight.Text);
			    Program.Cfg.KeepAspectRatio = cbKeepAspectRatio.Checked;
                Program.Cfg.FPS = float.Parse(cmbFPS.Text);
			    Program.Cfg.WriteLog = cbLog.Checked;
                if (cmbWebCameras.Enabled)
                {
                    Program.Cfg.WebCameraDevice = cmbWebCameras.SelectedItem.ToString();
                    Program.Cfg.WebCameraWindowX = Int32.Parse(tbWebCameraX.Text);
                    Program.Cfg.WebCameraWindowY = Int32.Parse(tbWebCameraY.Text);
                    Program.Cfg.WebCameraWindowWidth = Int32.Parse(tbWebCameraWidth.Text);
                    Program.Cfg.WebCameraWindowHeight = Int32.Parse(tbWebCameraHeight.Text);
                }
				Program.Cfg.CaptureMouseCursor = cbCaptureMouseCursor.Checked;
				Program.Cfg.ShowMouseHotSpot = cbShowMouseHotSpot.Checked;
				Program.Cfg.MouseAnimationDuration = Convert.ToInt32(tbMouseAnimationDuration.Text);
				Program.Cfg.MouseSpotRadius = Convert.ToInt32(tbHotSpotRadius.Text);
				Program.Cfg.MouseHotSpotColor = ccMouseHotSpotColor.ForeColor;
				Program.Cfg.AnimateMouseClicks = cbAnimateMouseClicks.Checked;
				Program.Cfg.AnimateMouseButtons = cbAnimateMouseButtons.Checked;
				Program.Cfg.MouseCursorLeftClickAnimationColor = ccMouseCursorLeftClickAnimationColor.ForeColor;
				Program.Cfg.MouseCursorRightClickAnimationColor = ccMouseCursorRightClickAnimationColor.ForeColor;
				Program.Cfg.CaptureAreaBorderType = (CaptureAreaBorderType) cmbFrameType.SelectedIndex;
				Program.Cfg.CaptureAreaBorderColor = ccFrameColor.ForeColor;
				Program.Cfg.CaptureAreaBorderWidth = Int32.Parse(tbFrameWidth.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, Application.ProductName);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process prc = new Process();
			prc.StartInfo.FileName = "http://www.bytescout.com/";
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

		private void btnVideoCodecProps_Click(object sender, EventArgs e)
		{
			Capturer tempCapturer = new Capturer();
			tempCapturer.RegistrationName = "demo";
			tempCapturer.RegistrationKey = "demo";

			tempCapturer.CurrentVideoCodecName = cmbAviVideoCodecs.SelectedItem.ToString();


			try
			{
				tempCapturer.ShowVideoCodecSettingsDialog(0);
			}
			catch (InvalidCastException)
			{
				MessageBox.Show("This codec has no properties dialog.", Application.ProductName);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Failed to open the codec properties dialog.\n" + exception.Message, Application.ProductName);
			}
            finally
		    {
		        Marshal.ReleaseComObject(tempCapturer);
            }
		}

		private void linkViewLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string logFile = Path.GetTempPath() + Application.ProductName + " log.txt";

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
					MessageBox.Show(ex.Message, Application.ProductName);
				}
			}
		}

		private void cmbAudioDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_tempCapturer.AudioDeviceCount == 0)
				return;

			_tempCapturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();

			cmbAudioLines.Items.Clear();

			for (int i = 0; i < _tempCapturer.CurrentAudioDeviceLineCount; i++)
			{
				string line = _tempCapturer.GetCurrentAudioDeviceLineName(i);
				cmbAudioLines.Items.Add(line);
			}

			for (int i = 0; i < cmbAudioLines.Items.Count; i++)
			{
				if (cmbAudioLines.Items[i].ToString() == Program.Cfg.AudioLine)
				{
					cmbAudioLines.SelectedIndex = i;
					break;
				}
			}

            if (cmbAudioLines.SelectedIndex == -1)
            {
                for (int j = 0; j < cmbAudioLines.Items.Count; j++ )
                {
                    string tmpS = cmbAudioLines.Items[j].ToString().ToUpper();
                    if (tmpS.IndexOf("MIC") > -1)
                    {
                        cmbAudioLines.SelectedIndex = j;
                    }
                }
            }
            
            if (cmbAudioLines.SelectedIndex == -1)
			{
                cmbAudioLines.SelectedItem = _tempCapturer.CurrentAudioDeviceLineName;
				Program.Cfg.AudioLine = _tempCapturer.CurrentAudioDeviceLineName;
			}
		}

		private void cmbWmvAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
		{
			_tempCapturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();

			cmbWmvAudioFormats.Items.Clear();

			// Get list of available WMV audio formats
			for (int i = 0; i < _tempCapturer.WMVAudioFormatCount; i++)
			{
				string codec = _tempCapturer.GetWMVAudioFormatDescription(i);
				cmbWmvAudioFormats.Items.Add(codec);
			}

			for (int i = 0; i < cmbWmvAudioFormats.Items.Count; i++)
			{
				if (i == Program.Cfg.WmvAudioFormat)
				{
					cmbWmvAudioFormats.SelectedIndex = i;
					break;
				}
			}

			if (cmbWmvAudioFormats.SelectedIndex == -1)
			{
				cmbWmvAudioFormats.SelectedIndex = _tempCapturer.CurrentWMVAudioFormat;
				Program.Cfg.WmvAudioFormat = _tempCapturer.CurrentWMVAudioFormat;
			}
		}
    }
}
