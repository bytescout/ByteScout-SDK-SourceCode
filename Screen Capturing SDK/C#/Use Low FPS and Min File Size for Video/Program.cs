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
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using BytescoutScreenCapturingLib; // import bytescout screen capturing activex object 

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

namespace SimpleCaptureCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Capturer capturer = new Capturer(); // create new screen capturer object


            capturer.CapturingType = CaptureAreaType.catScreen; // set capturing area type to catScreen to capture whole screen

            capturer.OutputFileName = "LowFPS.wmv"; // set output video filename to .WMV or .AVI file

  	// set WMV video codec to Windows Media Video 9 Screen that gives best quality/size ratio when recording from screen
	capturer.CurrentWMVVideoCodecName = "Windows Media Video 9 Screen";
	// disable audio so we will have a video only (and the lowest wmv file size as possible: about 20 kb per 1 second, about 70 mb per 1 hour
	capturer.AudioEnabled = false;
	// set FPS to 0.5 fps (1 frame per every 2 seconds)
	// you may also want to set to 1 fps (1 frame per 1 second or higher)
	capturer.FPS = 0.50f;

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2;



            // set output video width and height
            capturer.OutputWidth = 640;
            capturer.OutputHeight = 480;
            
	    // set the text overlay with autochanging time stamp macros to indicate playing time and current date time 
	    capturer.OverlayingRedTextCaption = "Recording: {RUNNINGMIN}:{RUNNINGSEC}:{RUNNINGMSEC} on {CURRENTYEAR}-{CURRENTMONTH}-{CURRENTDAY} at {CURRENTHOUR}:{CURRENTMIN}:{CURRENTSEC}:{CURRENTMSEC}";


	    // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	    // capturer.CaptureTransparentControls = true;

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


            capturer.Run(); // run screen video capturing 

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do {
	// Thread.Sleep(1) 
	// }
	// While(StopButtonNotClicked);


	    Console.WriteLine("Capturing entire screen for 5 seconds...");

            Thread.Sleep(5000); // wait for 5 seconds

            capturer.Stop(); // stop video capturing

            // Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer);
            capturer = null;


	    Console.WriteLine("Done");


            Process.Start("LowFPS.wmv");
        }
    }
}
