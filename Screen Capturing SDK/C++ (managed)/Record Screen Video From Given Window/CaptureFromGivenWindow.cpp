//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// CaptureFromGivenWindow.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace System::Threading;
using namespace System::Diagnostics;

using namespace BytescoutScreenCapturingLib;


int main(array<System::String ^> ^args)
{
	// Create Capturer instance
    Capturer ^capturer = gcnew Capturer();
    
	capturer->RegistrationName = "demo";
	capturer->RegistrationKey = "demo";

	// Set capturing type
	capturer->CapturingType = CaptureAreaType::catWindow;

	// Specify window to capture by its title.
	// Capturer will take the first window containing "Internet Explorer" in its title.
	capturer->WindowToCapture = "Internet Explorer";

	// You can also capture only a part of the window by specifying capturing rectangle
	//capturer->CaptureRectLeft = 25;
	//capturer->CaptureRectTop = 25;
	//capturer->CaptureRectWidth = 320;
	//capturer->CaptureRectHeight = 240;

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer->put_WMVVideoBitrate(capturer->WMVVideoBitrate * 2);


        // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
        // capturer->CaptureTransparentControls = true;

	
	// Set output video width and height
	capturer->OutputWidth = 640;
	capturer->OutputHeight = 480;

	// set border style
        capturer.CaptureAreaBorderType = CaptureAreaBorderType::cabtDashed;

	// Set output file name
	capturer->OutputFileName = "Output.wmv";

	// Start capturing
	capturer->Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do {
	// Thread.Sleep(1) 
	// }
	// While(StopButtonNotClicked);

	
	Console::WriteLine("Capture window for 5s...");

	// Wait for 5 seconds
	Thread::Sleep(5000);

	// Stop capturing
	capturer->Stop();

    // Release resources
    System::Runtime::InteropServices::Marshal::ReleaseComObject(capturer);
    //capturer = NULL;

	
	Console::WriteLine("Done.");
	
	// Open the capture video in default associated application
	Process::Start("Output.wmv");

	return 0;
}
