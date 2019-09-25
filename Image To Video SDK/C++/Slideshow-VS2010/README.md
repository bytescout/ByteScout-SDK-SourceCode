## slideshow -vs2010 in C++ and ByteScout Image To Video SDK

### Make slideshow -vs2010 in C++: ### Tutorial on how to do slideshow -vs2010 in C++

Source code documentation samples provide quick and easy way to add a required functionality into your application. ByteScout Image To Video SDK was made to help with slideshow -vs2010 in C++. ByteScout Image To Video SDK is the library for conversion of images into video slideshow. Provides built-in support for more than hundred of 2D and 3D transition effects. Output formats supported are AVI,WMV and WEBM video files. You may adjust output video size, quality, framerate and add audio.

C++, code samples for C++, developers help to speed up the application development and writing a code when using ByteScout Image To Video SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enhanced documentation and tutorials are available along with installed ByteScout Image To Video SDK if you'd like to dive deeper into the topic and the details of the API.

On our website you may get trial version of ByteScout Image To Video SDK for free. Source code samples are included to help you with your C++ application.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****SimpleSlideshow.cpp:**
    
```
// SimpleSlideshow.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <conio.h>
#include <GdiPlus.h>

#pragma comment(lib, "gdiplus")
#import "BytescoutImageToVideo.dll"

using namespace BytescoutImageToVideo;
using namespace Gdiplus;

int _tmain(int argc, _TCHAR* argv[])
{
	::CoInitialize(0);

	CLSID clsid;
    CLSIDFromProgID(OLESTR("BytescoutImageToVideo.ImageToVideo"), &clsid);

	IImageToVideo* i2v = NULL;
    ::CoCreateInstance(clsid, NULL, CLSCTX_ALL, __uuidof(IImageToVideo), (LPVOID*)&i2v);

	if (!i2v)
    {
        fwprintf(stdout, L"Image To Video filter is not installed properly.\n");

        ::CoUninitialize();
        return 1;
    }

	ULONG_PTR m_pGdiToken;
	GdiplusStartupInput m_gdiplusStartupInput;
	GdiplusStartup(&m_pGdiToken, &m_gdiplusStartupInput, NULL);

	// set log
	i2v->SetLogFile("log.txt");

	// register the library
	i2v->put_RegistrationName(L"demo");
	i2v->put_RegistrationKey(L"demo");

	// set output video dimensions
	i2v->put_OutputWidth(640);
    i2v->put_OutputHeight(480);

	i2v->put_UseInEffectForFirstSlide(VARIANT_FALSE);
	i2v->put_UseOutEffectForLastSlide(VARIANT_TRUE);

	CComPtr<ISlides> slides;
	CComPtr<ISlide> slide;
    
	i2v->get_Slides(&slides);

	// add some transition effects
	slides->put_DefaultSlideInEffect(teBlinds3DHorz);
	slides->put_DefaultSlideOutEffect(teBlinds3DVert);

	slide = i2v->AddImageFromFileName(L"..\\..\\slide1.jpg");
	slide->put_Duration(3000);
	slide = i2v->AddImageFromFileName(L"..\\..\\slide2.jpg");
	slide->put_Duration(3000);
	slide = i2v->AddImageFromFileName(L"..\\..\\slide3.jpg");
	slide->put_Duration(3000);
	
	i2v->put_ExternalAudioTrackFromFileName(L"..\\..\\bgmusic.mp3");

	i2v->put_OutputVideoFileName(L"Output.wmv");

	wprintf(L"Starting conversion process - Hit a key to abort ...\n");

	HRESULT hr = i2v->Run();

    if (FAILED(hr))
    {
		CComBSTR s;
        i2v->get_LastError(&s);
        fwprintf(stdout, L"Conversion process failed: %s\n", CString(s));
    }
    else
    { 
        int i = 0;
        char *spin = "|/-\\";
        VARIANT_BOOL b = VARIANT_TRUE;

        while (!_kbhit() && b == VARIANT_TRUE)
        {
            LONG progress = 0;
            i2v->get_ConversionProgress(&progress);
            wprintf(L"\rMaking video %d%% %c", progress, spin[i++]);
            i %= 4;
            Sleep(50);

            i2v->get_IsRunning(&b);
        }

        i2v->get_IsRunning(&b);

        if (b == VARIANT_TRUE)
        {
            i2v->Stop();
            wprintf(L"\nConversion process aborted by user.\n");
        }
        else
        {
            _ftprintf(stdout, _T("\nConversion process completed successfully.\n"));
        }
    }

    wprintf(L"\nPress Enter to continue.\n");
    getchar();

    i2v->Release();
    i2v = NULL;

	GdiplusShutdown(m_pGdiToken);

	::CoUninitialize();

	return 0;
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// SimpleSlideshow.pch will be the pre-compiled header
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

// TODO: reference additional headers your program requires here

```

<!-- code block end -->