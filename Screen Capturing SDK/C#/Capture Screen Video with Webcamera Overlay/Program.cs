//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
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


namespace CaptureWithWebcameraOverlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Capturer capturer = new Capturer(); // create new screen capturer object


            capturer.CapturingType = CaptureAreaType.catScreen; // set capturing area type to catScreen to capture whole screen

			// Set webcamera device by name (.CurrentWebCamname property)
			// or set it by index using .CurrentWebCam property
        	capturer.CurrentWebCam = 0;

			// Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10, 10)
        	capturer.SetWebCamVideoRectangle(10, 10, 160, 120);

			// Enable webcam overlaying capture device
        	capturer.AddWebCamVideo = true;

			capturer.OutputFileName = "ScreenWithWebCameraCaptured.wmv"; // set output video filename to .WMV or .AVI file

            // set output video width and height
            capturer.OutputWidth = 640;
            capturer.OutputHeight = 480;

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2;


	    // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	    // capturer.CaptureTransparentControls = true;

            
            capturer.Run(); // run screen video capturing 

	//' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	//' using Thread.Sleep(1) inside the checking loop, so you have the loop like
	//' Do {
	//' Thread.Sleep(1) 
	//' }
	//' While(StopButtonNotClicked);

	    Console.WriteLine("Capturing entire screen for 10 seconds...");

            Thread.Sleep(10000); // wait for 10 seconds

            capturer.Stop(); // stop video capturing

            // Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer);
            capturer = null;

	    Console.WriteLine("Done");

	    Process.Start("ScreenWithWebCameraCaptured.wmv");
        }
    }
}
