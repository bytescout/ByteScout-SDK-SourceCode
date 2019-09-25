## How to record screen video from given window in C++ (managed) and ByteScout Screen Capturing SDK

### Tutorial on how to record screen video from given window in C++ (managed)

Record screen video from given window is easy to implement in C++ (managed) if you use these source codes below. ByteScout Screen Capturing SDK: the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images. It can record screen video from given window in C++ (managed).

This rich sample source code in C++ (managed) for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to record screen video from given window. Just copy and paste the code into your C++ (managed) application’s code and follow the instruction. Enjoy writing a code with ready-to-use sample C++ (managed) codes.

Free trial version of ByteScout Screen Capturing SDK is available on our website. Documentation and source code samples are included.

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

##### ****AssemblyInfo.cpp:**
    
```
#include "stdafx.h"

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;
using namespace System::Security::Permissions;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly:AssemblyTitleAttribute("CaptureFromGivenWindow")];
[assembly:AssemblyDescriptionAttribute("")];
[assembly:AssemblyConfigurationAttribute("")];
[assembly:AssemblyCompanyAttribute("")];
[assembly:AssemblyProductAttribute("CaptureFromGivenWindow")];
[assembly:AssemblyCopyrightAttribute("Copyright (c)  2011")];
[assembly:AssemblyTrademarkAttribute("")];
[assembly:AssemblyCultureAttribute("")];

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the value or you can default the Revision and Build Numbers
// by using the '*' as shown below:

[assembly:AssemblyVersionAttribute("1.0.*")];

[assembly:ComVisible(false)];

[assembly:CLSCompliantAttribute(true)];

[assembly:SecurityPermission(SecurityAction::RequestMinimum, UnmanagedCode = true)];

```

<!-- code block end -->    

<!-- code block begin -->

##### ****CaptureFromGivenWindow.cpp:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****resource.h:**
    
```
//{{NO_DEPENDENCIES}}
// Microsoft Visual C++ generated include file.
// Used by app.rc

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// CaptureFromGivenWindow.pch will be the pre-compiled header
// stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"



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

// TODO: reference additional headers your program requires here

```

<!-- code block end -->