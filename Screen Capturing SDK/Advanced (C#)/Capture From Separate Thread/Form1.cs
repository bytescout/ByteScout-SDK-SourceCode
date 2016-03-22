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
using System.Threading;
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


namespace CaptureFromSeparateThread
{
	public partial class Form1 : Form
	{
		private Thread _capturingThread;
		private CapturingThreadData _capturingThreadData; // data to exchange between form and capturing thread

		public Form1()
		{
			InitializeComponent();

			cmbCapturingType.SelectedIndex = 0;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			CaptureAreaType captureType = CaptureAreaType.catMouse;
			
			if (cmbCapturingType.SelectedIndex == 1)
				captureType = CaptureAreaType.catScreen;

			StartRecording(captureType);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			StopRecording();
		}

		private void StartRecording(CaptureAreaType captureType)
		{
			btnStart.Enabled = false;
			btnStop.Enabled = true;

			_capturingThreadData = new CapturingThreadData();
			_capturingThreadData.CaptureType = captureType;

			_capturingThread = new Thread(CapturingThread.ThreadProc);
			_capturingThread.Start(_capturingThreadData);
		}

		private void StopRecording()
		{
			btnStop.Enabled = false;

			Cursor = Cursors.WaitCursor;

			try
			{
				// stop recording thread
				_capturingThread.Interrupt();
				_capturingThread.Join();
			}
			finally
			{
				Cursor = Cursors.Default;
			}

			if (_capturingThreadData.Result != 0)
			{
				MessageBox.Show("Capturing failed. Error: " + _capturingThreadData.ErrorText);
			}
			else
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.DefaultExt = "*.wmv";
				dlg.Filter = "WMV files (*.wmv)|*.wmv|All files (*.*)|*.*";

				dlg.FileName = "Screencast";
				dlg.Title = "Save captured video as";
				
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					File.Copy(_capturingThreadData.TempFile, dlg.FileName, true);
					
					Process.Start(dlg.FileName); // start the video in default associated application
				}
				
				File.Delete(_capturingThreadData.TempFile);
			}

			btnStart.Enabled = true;
		}
	}
}
