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

	
	// set output WMV, WEBM or AVI video filename
	swfToVideo->put_OutputVideoFileName(L"result.webm");

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

