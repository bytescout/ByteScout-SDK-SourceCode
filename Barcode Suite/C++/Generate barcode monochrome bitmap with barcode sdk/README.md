## How to generate barcode monochrome bitmap with barcode sdk in C++ using ByteScout Barcode Suite

### How to write a robust code in C++ to generate barcode monochrome bitmap with barcode sdk with this step-by-step tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. Want to generate barcode monochrome bitmap with barcode sdk in your C++ app? ByteScout Barcode Suite is designed for it. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for C++ plus the guidelines and the code below will help you quickly learn how to generate barcode monochrome bitmap with barcode sdk. Just copy and paste the code into your C++ application’s code and follow the instructions. Applying C++ application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Barcode Suite free trial version is available on our website. C++ and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****BarcodeGenerationExample.cpp:**
    
```
#include "stdafx.h"

#import "Bytescout.BarCode.tlb" raw_interfaces_only

using namespace Bytescout_BarCode;


int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
	HRESULT hr = CoInitialize(NULL);

	// Create the interface pointer.
	IBarcodePtr pIBarcode(__uuidof(Barcode));

	// set the registration name and key
	BSTR regname = ::SysAllocString(L"DEMO");
	pIBarcode->put_RegistrationName(regname);
	::SysFreeString(regname);

	BSTR regkey = ::SysAllocString(L"DEMO");
	pIBarcode->put_RegistrationKey(regkey);
	::SysFreeString(regkey);

	// Set barcode type (symbology)
	pIBarcode->put_Symbology(SymbologyType_DataMatrix);

	// Set monochrome output 
	pIBarcode->put_ProduceMonochromeImages(VARIANT_TRUE);

	// Set barcode value
	BSTR value = ::SysAllocString(L"Barcode Value 1234567890");
	pIBarcode->put_Value(value);
	::SysFreeString(value);

	// Save barcode image
	BSTR fileName = ::SysAllocString(L"result.png");
	pIBarcode->SaveImage(fileName);
	::SysFreeString(fileName);

	pIBarcode->Release();

	// Uninitialize COM.
	CoUninitialize();

	return 0;
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****BarcodeGenerationExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}") = "BarcodeGenerationExample", "BarcodeGenerationExample.vcxproj", "{7197580A-6CCC-4581-BD61-9028B6A0578E}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Win32 = Debug|Win32
		Release|Win32 = Release|Win32
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{7197580A-6CCC-4581-BD61-9028B6A0578E}.Debug|Win32.ActiveCfg = Debug|Win32
		{7197580A-6CCC-4581-BD61-9028B6A0578E}.Debug|Win32.Build.0 = Debug|Win32
		{7197580A-6CCC-4581-BD61-9028B6A0578E}.Release|Win32.ActiveCfg = Release|Win32
		{7197580A-6CCC-4581-BD61-9028B6A0578E}.Release|Win32.Build.0 = Release|Win32
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// BarcodeGenerationExample.pch will be the pre-compiled header
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

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>



// TODO: reference additional headers your program requires here

```

<!-- code block end -->    

<!-- code block begin -->

##### ****targetver.h:**
    
```
#pragma once

// Including SDKDDKVer.h defines the highest available Windows platform.

// If you wish to build your application for a previous Windows platform, include WinSDKVer.h and
// set the _WIN32_WINNT macro to the platform you wish to support before including SDKDDKVer.h.

#include <SDKDDKVer.h>

```

<!-- code block end -->