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
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Drawing;
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
	public class CapturingThread
	{
		public static void ThreadProc(Object obj)
		{
		    CapturingThreadData data = (CapturingThreadData) obj;
		    data.Success = true;

		    // Prepare Capturer:

		    Capturer capturer = new Capturer(); // create new screen capturer object

		    capturer.RegistrationName = "demo";
		    capturer.RegistrationKey = "demo";

		    capturer.CaptureRectLeft = data.CaptureRectangle.Left;
		    capturer.CaptureRectTop = data.CaptureRectangle.Top;
		    capturer.CaptureRectWidth = data.CaptureRectangle.Width;
		    capturer.CaptureRectHeight = data.CaptureRectangle.Height;

		    capturer.OutputWidth = 640;
		    capturer.OutputHeight = 480;

		    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
		    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
		    // capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2;

		    capturer.CaptureRectWidth = 320;
		    capturer.CaptureRectHeight = 240;

		    data.TempFile = Path.GetTempFileName();
		    data.TempFile = Path.ChangeExtension(data.TempFile, ".wmv");

		    capturer.OutputFileName = data.TempFile;
		    capturer.CapturingType = data.CaptureType;

		    // set border around captured area if we are not capturing entire screen
		    if (capturer.CapturingType != CaptureAreaType.catScreen &&
		        capturer.CapturingType != CaptureAreaType.catWebcamFullScreen)
		    {
		        capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
		        capturer.CaptureAreaBorderColor = (uint) ColorTranslator.ToOle(Color.Red);
		    }


		    // Wait for events:

		    WaitHandle[] events = new WaitHandle[] {data.StartOrResumeEvent, data.PauseEvent, data.StopEvent};
		    
            try
		    {
                while (true)
                {
                    int i = WaitHandle.WaitAny(events);

                    if (events[i] == data.StartOrResumeEvent)
                    {
                        if (!capturer.IsRunning)
                            capturer.Run();
                    }
                    else if (events[i] == data.PauseEvent)
                    {
                        if (capturer.IsRunning)
                            capturer.Pause();
                    }
                    else if (events[i] == data.StopEvent)
                    {
                        capturer.Stop();
                        break;
                    }
                }
		    }
		    catch (Exception ex)
		    {
		        data.ErrorText = ex.Message;
		        data.Success = false;
		    }
		    finally
		    {
		        // Release resources
		        Marshal.ReleaseComObject(capturer);
		    }
		}
	}
}
