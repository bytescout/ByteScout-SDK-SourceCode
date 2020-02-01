//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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

namespace ScreenCapturing
{
    public class CapturingThreadData
    {
        public CaptureAreaType CaptureType;
        public String TempFile;
        public Rectangle CaptureRectangle;
    	public bool ShowWebCamStream;

        public int Result = 0; // 0 - success; 1 - error
        public string ErrorText;
    }

    public class CapturingThread
    {
        public static void ThreadProc(Object obj)
        {
            Capturer capturer = new Capturer(); // create new screen capturer object

            CapturingThreadData data = (CapturingThreadData) obj;

	        if (Program.Cfg.WriteLog)
		        capturer.SetLogFile(Path.GetTempPath() + Application.ProductName + " log.txt");

	        capturer.RegistrationName = "demo";
            capturer.RegistrationKey = "demo";

			if (Program.Cfg.AudioDevice != "")
			{
				capturer.CurrentAudioDeviceName = Program.Cfg.AudioDevice;
			}

            if (Program.Cfg.AudioLine != "")
            {
                capturer.CurrentAudioDeviceLineName = Program.Cfg.AudioLine;
            }

			if (Program.Cfg.SelectedVideoCodecTab == 0)
			{
				capturer.CurrentWMVAudioCodecName = Program.Cfg.WmvAudioCodec;
				capturer.CurrentWMVAudioFormat = Program.Cfg.WmvAudioFormat;
				capturer.CurrentWMVVideoCodecName = Program.Cfg.WmvVideoCodec;

				Program.Cfg.WmvAudioCodec = capturer.CurrentWMVAudioCodecName;
				Program.Cfg.WmvAudioFormat = capturer.CurrentWMVAudioFormat;
				Program.Cfg.WmvVideoCodec = capturer.CurrentWMVVideoCodecName;
			}
			else
			{
				capturer.CurrentAudioCodecName = Program.Cfg.AviAudioCodec;
				capturer.CurrentVideoCodecName = Program.Cfg.AviVideoCodec;
			}

            capturer.AudioEnabled = Program.Cfg.EnableAudio;
            // this option tells to use captured area dimensions as output video width/height
            // or use user defined video dimensions
            capturer.MatchOutputSizeToTheSourceSize = !Program.Cfg.ResizeOutputVideo;
            capturer.FPS = Program.Cfg.FPS;
            
			capturer.ShowMouseHotSpot = Program.Cfg.ShowMouseHotSpot;
			capturer.CaptureMouseCursor = Program.Cfg.CaptureMouseCursor;
			capturer.AnimateMouseClicks = Program.Cfg.AnimateMouseClicks;
			capturer.AnimateMouseButtons = Program.Cfg.AnimateMouseButtons;
			capturer.MouseAnimationDuration = Program.Cfg.MouseAnimationDuration;
			capturer.MouseSpotRadius = Program.Cfg.MouseSpotRadius;
			capturer.MouseHotSpotColor = (uint) ColorTranslator.ToOle(Program.Cfg.MouseHotSpotColor);
			capturer.MouseCursorLeftClickAnimationColor = (uint) ColorTranslator.ToOle(Program.Cfg.MouseCursorLeftClickAnimationColor);
			capturer.MouseCursorRightClickAnimationColor = (uint) ColorTranslator.ToOle(Program.Cfg.MouseCursorRightClickAnimationColor);                 	

            capturer.CaptureRectLeft = data.CaptureRectangle.Left;
            capturer.CaptureRectTop = data.CaptureRectangle.Top;
            capturer.CaptureRectWidth = data.CaptureRectangle.Width;
            capturer.CaptureRectHeight = data.CaptureRectangle.Height;

            capturer.KeepAspectRatio = Program.Cfg.KeepAspectRatio;

            // show recording time stamp
            capturer.OverlayingRedTextCaption = "Recording: {RUNNINGMIN}:{RUNNINGSEC}:{RUNNINGMSEC} on {CURRENTYEAR}-{CURRENTMONTH}-{CURRENTDAY} at {CURRENTHOUR}:{CURRENTMIN}:{CURRENTSEC}:{CURRENTMSEC}";

            capturer.OutputWidth = Program.Cfg.OutputWidth;
            capturer.OutputHeight = Program.Cfg.OutputHeight;

            if ((capturer.WebCamCount > 0) && (data.ShowWebCamStream))
			{
				capturer.AddWebCamVideo = true;

				if (!String.IsNullOrEmpty(Program.Cfg.WebCameraDevice))
				{
					capturer.CurrentWebCamName = Program.Cfg.WebCameraDevice;
				}

				capturer.SetWebCamVideoRectangle(Program.Cfg.WebCameraWindowX, Program.Cfg.WebCameraWindowY, Program.Cfg.WebCameraWindowWidth, Program.Cfg.WebCameraWindowHeight);
			}
            
            data.TempFile = Path.GetTempFileName();
			data.TempFile = Path.ChangeExtension(data.TempFile, (Program.Cfg.SelectedVideoCodecTab == 0) ? ".wmv" : ".avi");
            capturer.OutputFileName = data.TempFile;
            capturer.CapturingType = data.CaptureType;

            // set border around captured area if we are not capturing entire screen
            if (capturer.CapturingType != CaptureAreaType.catScreen &&
                capturer.CapturingType != CaptureAreaType.catWebcamFullScreen)
            {
                // set border style
				capturer.CaptureAreaBorderType = Program.Cfg.CaptureAreaBorderType;
				capturer.CaptureAreaBorderColor = (uint) ColorTranslator.ToOle(Program.Cfg.CaptureAreaBorderColor);
				capturer.CaptureAreaBorderWidth = Program.Cfg.CaptureAreaBorderWidth;
            }


            try
            {
                capturer.Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do 
	// Thread.Sleep(1) 
	// While StopButtonNotClicked

            }
            catch (COMException ex)
            {
                data.ErrorText = ex.Message;
                data.Result = 1;
                Marshal.ReleaseComObject(capturer);
                return;
            }

            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException)
            {
                capturer.Stop();
                data.Result = 0;
            }
            catch (Exception ex)
            {
                data.ErrorText = ex.Message;
                data.Result = 1;
            }
            finally
            {
                Marshal.ReleaseComObject(capturer);
            }
        }
    }
}
