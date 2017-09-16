//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


// CaptureFromEntireScreen.cpp : main project file.

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
	capturer->CapturingType = CaptureAreaType::catScreen;

	// Set output video width and height
	capturer->OutputWidth = 640;
	capturer->OutputHeight = 480;

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer->put_WMVVideoBitrate(capturer->WMVVideoBitrate * 2);


        // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
        // capturer->CaptureTransparentControls = true;


	// Set output file name
	capturer->OutputFileName = "Output.webm";

	// Start capturing
	capturer->Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do {
	// Thread.Sleep(1) 
	// }
	// While(StopButtonNotClicked);

	
	Console::WriteLine("Capture the desktop for 5s...");

	// Wait for 5 seconds
	Thread::Sleep(5000);

	// Stop capturing
	capturer->Stop();

    // Release resources
    System::Runtime::InteropServices::Marshal::ReleaseComObject(capturer);
    //capturer = NULL;

	
	Console::WriteLine("Done.");
	
	// Open the capture video in default associated application
	Process::Start("Output.webm");

	return 0;
}
