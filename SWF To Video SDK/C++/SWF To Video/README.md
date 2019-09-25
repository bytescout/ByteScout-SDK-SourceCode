## SWF to video in C++ with ByteScout SWF To Video SDK

### Tutorial: how to do SWF to video in C++

Writing of the code to SWF to video in C++ can be done by developers of any level using ByteScout SWF To Video SDK. SWF to video in C++ can be implemented with ByteScout SWF To Video SDK. ByteScout SWF To Video SDK is the SDK that is capable of converting SWF macromedia files into WMV and AVI video. Supports dynamic flash movies, can transmit variable values. Options to change output video size, framerate, quality are available.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample C++ codes to implement SWF to video using ByteScout SWF To Video SDK.

Our website provides free trial version of ByteScout SWF To Video SDK. It comes along with all these source code samples with the goal to help you with your C++ application implementation.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****Simple.cpp:**
    
```
#include "stdafx.h"

#import "BytescoutSWFToVideo.dll"

using namespace BytescoutSWFToVideo;

int _tmain(int argc, _TCHAR* argv[])
{
	::CoInitialize(0);

	// Create an instance of SWFToVideo ActiveX object

	CLSID clsid;
    CLSIDFromProgID(OLESTR("BytescoutSWFToVideo.SWFToVideo"), &clsid);

	ISWFToVideo* swfToVideo = NULL;
    ::CoCreateInstance(clsid, NULL, CLSCTX_ALL, __uuidof(ISWFToVideo), (LPVOID*) &swfToVideo);

	if (!swfToVideo)
    {
        _ftprintf(stdout, _T("SWF To Video filter is not installed properly. Can't continue\n"));
        ::CoUninitialize();
        return 1;
    }

	// Set debug log
	//swfToVideo->SetLogFile("log.txt");

	// Register SWFToVideo
    swfToVideo->put_RegistrationName(L"demo");
    swfToVideo->put_RegistrationKey(L"demo");

	// set input SWF file
	swfToVideo->put_InputSWFFileName(L"SlideShowWithEffects.swf");

	// you may calculate output video duration using information about the the source swf movie
	// WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
    //and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
    //WARNING #2: you should set the input swf or flv filename (or url) before this calculation

    //So the movie duration is calculated as the following:
    //as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
    //and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
    //as the following (uncomment if you want to set the length of the output video to the same as the original swf)
    //or as the following source code (uncomment to enable):

    //converter->put_ConversionTimeout( 1000 * (converter->get_FrameCount() / converter.get_MovieFPS()));

	
	// set output WMV or AVI video filename
	swfToVideo->put_OutputVideoFileName(L"result.wmv");

	// Set output movie dimensions
	swfToVideo->put_OutputWidth(640);
    swfToVideo->put_OutputHeight(480);

	// Run conversion
	HRESULT hr = swfToVideo->RunAndWait();

	// Cleanup
	swfToVideo->Release();
    swfToVideo = NULL;

    ::CoUninitialize();

	return 0;
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// Simple.pch will be the pre-compiled header
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

// Modify the following defines if you have to target a platform prior to the ones specified below.
// Refer to MSDN for the latest info on corresponding values for different platforms.
#ifndef WINVER				// Allow use of features specific to Windows XP or later.
#define WINVER 0x0501		// Change this to the appropriate value to target other versions of Windows.
#endif

#ifndef _WIN32_WINNT		// Allow use of features specific to Windows XP or later.                   
#define _WIN32_WINNT 0x0501	// Change this to the appropriate value to target other versions of Windows.
#endif						

#ifndef _WIN32_WINDOWS		// Allow use of features specific to Windows 98 or later.
#define _WIN32_WINDOWS 0x0410 // Change this to the appropriate value to target Windows Me or later.
#endif

#ifndef _WIN32_IE			// Allow use of features specific to IE 6.0 or later.
#define _WIN32_IE 0x0600	// Change this to the appropriate value to target other versions of IE.
#endif

#include <stdio.h>
#include <tchar.h>


#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS	// some CString constructors will be explicit

#include <atlbase.h>
#include <atlstr.h>

#include <conio.h>

```

<!-- code block end -->