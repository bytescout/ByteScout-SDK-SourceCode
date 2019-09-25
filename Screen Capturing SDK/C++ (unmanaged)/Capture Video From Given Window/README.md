## How to capture video from given window in C++ (unmanaged) and ByteScout Screen Capturing SDK

### How to code in C++ (unmanaged) to capture video from given window with this step-by-step tutorial

These sample source codes on this page below are demonstrating how to capture video from given window in C++ (unmanaged). ByteScout Screen Capturing SDK is the SDK for developers for quick implementation of screen video recording. The SDK records screen into video or into a series of screenshots. Can also record audio. Saves video into AVI,WMV and Google's WebM. Output video quality, size, resolution or framerate can be adjusted easily. Provides additional tools for privacy features like blacking out on scren areas with sensitive information on screen right during recording. Supports web camera as input and can add instant text and images into video output and you can use it to capture video from given window with C++ (unmanaged).

This code snippet below for ByteScout Screen Capturing SDK works best when you need to quickly capture video from given window in your C++ (unmanaged) application. In your C++ (unmanaged) project or application you may simply copy & paste the code and then run your app! Code testing will allow the function to be tested and work properly with your data.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

##### ****CaptureFromGivenWindow.cpp:**
    
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