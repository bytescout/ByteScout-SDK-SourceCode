## How to capture video from region around mouse in C++ (unmanaged) with ByteScout Screen Capturing SDK

### The tutorial below will demonstrate how to capture video from region around mouse in C++ (unmanaged)

The sample shows steps and algorithm of how to capture video from region around mouse and how to make it work in your C++ (unmanaged) application. ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video. It can capture video from region around mouse in C++ (unmanaged).

This code snippet below for ByteScout Screen Capturing SDK works best when you need to quickly capture video from region around mouse in your C++ (unmanaged) application. Just copy and paste the code into your C++ (unmanaged) application’s code and follow the instruction. This basic programming language sample code for C++ (unmanaged) will do the whole work for you to capture video from region around mouse.

ByteScout Screen Capturing SDK free trial version is available on our website. C++ (unmanaged) and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****CaptureRegionAroundMouse.cpp:**
    
```
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
	::CoCreateInstance(clsid_ScreenCapturer, NULL, CLSCTX_ALL, __uuidof(ICapturer), (LPVOID*)&capturer);

	if (!capturer)
	{
		_ftprintf(stdout, _T("Screen Capturer is not installed properly."));
		::CoUninitialize();
		return 1;
	}

	capturer->put_RegistrationName(_T("demo"));
	capturer->put_RegistrationKey(_T("demo"));

	// Set capturing type 
	capturer->put_CapturingType(catMouse);

	// Set capturing area width and height
	capturer->put_CaptureRectWidth(640);
	capturer->put_CaptureRectHeight(480);

	// Set output video width and height
	capturer->put_OutputWidth(640);
	capturer->put_OutputHeight(480);

	    // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	    // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	    // capturer->put_WMVVideoBitrate(capturer->WMVVideoBitrate * 2);


	// set border style
	capturer->put_CaptureAreaBorderType(cabtDashed);
    capturer->put_CaptureAreaBorderWidth(2);
	capturer->put_CaptureAreaBorderColor(RGB(255, 0, 0));

	// Set output file name
	capturer->OutputFileName = _T("Output.wmv");

        // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
        // capturer->CaptureTransparentControls = true;


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
		_tprintf(_T("Starting capture - Hit Enter to stop ...\n"));

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


```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// CaptureFromEntireScreen.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

// TODO: reference any additional headers you need in STDAFX.H
// and not in this file

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.h:**
    
```
// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#ifndef _WIN32_WINNT		// Allow use of features specific to Windows XP or later.                   
#define _WIN32_WINNT 0x0501	// Change this to the appropriate value to target other versions of Windows.
#endif						

#include <stdio.h>
#include <tchar.h>

#include <atlbase.h>
#include <atlstr.h>
#include <conio.h>

```

<!-- code block end -->