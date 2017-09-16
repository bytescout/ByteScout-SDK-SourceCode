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


// CaptureFromEntireScreen.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#import "BytescoutScreenCapturing.dll"

using namespace BytescoutScreenCapturingLib;
using namespace std;


void usage(ICapturer* capturer);
void setParams(int argc, _TCHAR* argv[], ICapturer* capturer);


int _tmain(int argc, _TCHAR* argv[])
{
	::CoInitialize(0);

	// Create Capturer instance

	CLSID clsid_ScreenCapturer;
	CLSIDFromProgID(OLESTR("BytescoutScreenCapturing.Capturer"), &clsid_ScreenCapturer);

	ICapturer* capturer = NULL;
	::CoCreateInstance(clsid_ScreenCapturer, NULL, CLSCTX_ALL, __uuidof(ICapturer), (LPVOID*) &capturer);

	if (!capturer)
	{
		_ftprintf(stdout, _T("Screen Capturer is not installed properly."));
		::CoUninitialize();
		return 1;
	}

	capturer->put_RegistrationName(_T("demo"));
	capturer->put_RegistrationKey(_T("demo"));

	// Set capturing type
	capturer->put_CapturingType(catWindow);

	// Specify window to capture by its title.
	// Capturer will take the first window containing "Internet Explorer" in its title.
	capturer->put_WindowToCapture(_T("Internet Explorer"));

	// You can also capture only a part of the window by specifying capturing rectangle
	//capturer->put_CaptureRectLeft(25);
	//capturer->put_CaptureRectTop(25);
	//capturer->put_CaptureRectWidth(320);
	//capturer->put_CaptureRectHeight(240);

	// Set output video width and height
	capturer->put_OutputWidth(640);
	capturer->put_OutputHeight(480);

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer->put_WMVVideoBitrate(capturer->WMVVideoBitrate * 2);


        // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
        // capturer->CaptureTransparentControls = true;


	// set border style
        ?apturer.CaptureAreaBorderType = cabtDashed;

	// Set output file name
	capturer->OutputFileName = _T("Output.wmv");

	// Start capturing
	HRESULT hr = capturer->Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do 
	// Thread.Sleep(1) 
	// While StopButtonNotClicked

	
	if (FAILED(hr))
	{
		// Error handling
		CComBSTR s;
		capturer->get_LastError(&s);
		_ftprintf(stdout, _T("Capture failed: %s\n"), CString(s));
	}
	else
	{
		_tprintf(_T("Starting capture - Hit a key to stop ...\n"));

		int i = 0;
		TCHAR *spin = _T("|/-\\");

		// Show some progress
		while (!_kbhit())
		{
			_tprintf(_T("\rEncoding %c"), spin[i++]);
			i %= 4;
			Sleep(50);
		}

		// Stop after key press
		capturer->Stop();

		_tprintf(_T("\nDone."));
		getchar();
	}

	// Release Capturer
	capturer->Release();
	capturer = NULL;

	::CoUninitialize();

	return 0;
}

