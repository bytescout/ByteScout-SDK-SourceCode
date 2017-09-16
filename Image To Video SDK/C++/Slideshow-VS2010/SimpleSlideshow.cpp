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
