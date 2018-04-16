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


using System.Windows.Forms;
using BytescoutScreenCapturingLib;

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find "BytescoutScreenCapturing 1.0 Type Library"
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

namespace ScreenCapturingExample
{
	public partial class Form1 : Form
	{
		private Capturer _capturer = null;

		private int _screencastCount = 0;
		private int _screenshotCount = 0;

		public Form1()
		{
			InitializeComponent();

			// Create and setup Capturer object:

			_capturer = new Capturer();

			// Capture the full screen
			_capturer.CapturingType = CaptureAreaType.catScreen;

			// Set movie width and height to the current monitor dimensions
			_capturer.OutputWidth = _capturer.MonitorWidth;
			_capturer.OutputHeight = _capturer.MonitorHeight;

			// Setup screenshots
			_capturer.ScreenshotImageFormat = ScreenshotImageType.ssitPng; // Save images in PNG format
			_capturer.ScreenshotOutputFolder = "\\."; // Save to the current folder
			_capturer.ScreenshotSavingType = ScreenshotSavingType.ssstManual; // Take screenshots manually
		}

		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			string fileName = string.Format("screencast{0}.wmv", ++_screencastCount);

			// Start screen recording
			_capturer.OutputFileName = fileName;
			_capturer.Run();

			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
			buttonScreenshot.Enabled = true;
		}

		private void buttonStop_Click(object sender, System.EventArgs e)
		{
			// Stop recording
			_capturer.Stop();

			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
			buttonScreenshot.Enabled = false;

			MessageBox.Show("Screencast saved to " + _capturer.OutputFileName, ProductName);
		}

		private void buttonScreenshot_Click(object sender, System.EventArgs e)
		{
			string fileName = string.Format("screenshot{0}.png", ++_screenshotCount);

			// Take screenshot during the recording
			_capturer.TakeScreenshot(fileName);

			MessageBox.Show("Screenshot saved to " + fileName, ProductName);
		}
	}
}
