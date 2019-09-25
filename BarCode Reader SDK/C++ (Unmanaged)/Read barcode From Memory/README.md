## How to read barcode from memory in C++ (Unmanaged) with ByteScout BarCode Reader SDK

### This code in C++ (Unmanaged) shows how to read barcode from memory with this how to tutorial

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. Want to read barcode from memory in your C++ (Unmanaged) app? ByteScout BarCode Reader SDK is designed for it. ByteScout BarCode Reader SDK is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format.

This code snippet below for ByteScout BarCode Reader SDK works best when you need to quickly read barcode from memory in your C++ (Unmanaged) application. This C++ (Unmanaged) sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Code testing will allow the function to be tested and work properly with your data.

Download free trial version of ByteScout BarCode Reader SDK from our website with this and other source code samples for C++ (Unmanaged).

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****ReadFromMemory.cpp:**
    
```
// ReadFromMemory.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "atlbase.h"

#import "c:\\Program Files\\Bytescout BarCode Reader SDK\\net4.00\\Bytescout.BarCodeReader.tlb" raw_interfaces_only
using namespace Bytescout_BarCodeReader;

int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
	HRESULT hr = CoInitialize(NULL);

	// Create the interface pointer.
	IReaderPtr pIReader(__uuidof(Reader));

	// set the registration name and key
	BSTR regname = ::SysAllocString(L"DEMO");
	pIReader->put_RegistrationName(regname);
	SysFreeString(regname);
	BSTR regkey = ::SysAllocString(L"DEMO");
	pIReader->put_RegistrationKey(regkey);
	SysFreeString(regkey);

	// Set barcode type to find
	_BarcodeTypeSelectorPtr pBarcodeTypesToFind;
	pIReader->get_BarcodeTypesToFind(&pBarcodeTypesToFind);
	pBarcodeTypesToFind->put_GS1DataBarExpanded(VARIANT_TRUE);

	// Get full path of sample barcode image file
	WCHAR file[MAX_PATH];
	::GetFullPathName(L"GS1DataBarExpanded.png", MAX_PATH, file, NULL);

	// Load file content to byte array (for demonstration purpose)
	HANDLE hFile = CreateFile(file, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);
	DWORD fileSize = GetFileSize(hFile, NULL);
	byte* pBuffer = new byte[fileSize];
	DWORD numberOfBytesRead;
	ReadFile(hFile, pBuffer, fileSize, &numberOfBytesRead, NULL);
	CloseHandle(hFile);

	// Read barcode from memory
	IStream* stream = SHCreateMemStream(pBuffer, fileSize);
	hr = pIReader->ReadFromStream(stream);

	stream->Release();
	delete[] pBuffer;

	// Get found barcode count
	long count;
	pIReader->get_FoundCount(&count);

	// Get found barcode information
	for (int i = 0; i < count; i++)
	{
		SymbologyType type;
		hr = pIReader->GetFoundBarcodeType(i, &type);
		wprintf(L"Barcode type: %d\n", type);

		float confidence;
		hr = pIReader->GetFoundBarcodeConfidence(i, &confidence);
		wprintf(L"Barcode confidence: %f\n", confidence);

		BSTR bstrValue;
		hr = pIReader->GetFoundBarcodeValue(i, &bstrValue);
		wprintf(L"Barcode value: %s\n", bstrValue);
		::SysFreeString(bstrValue);

		wprintf(L"\n");
	}

	if (count == 0)
	{
		wprintf(L"no barcodes found");
	}

	// Uninitialize COM.
	CoUninitialize();
	
	wprintf(L"\nHit key to continue\n");
	getchar();

	return 0;
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****ReadFromMemory.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}") = "ReadFromMemory", "ReadFromMemory.vcxproj", "{ABBECC62-8779-458A-B8DC-F949363D29AF}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Win32 = Debug|Win32
		Release|Win32 = Release|Win32
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{ABBECC62-8779-458A-B8DC-F949363D29AF}.Debug|Win32.ActiveCfg = Debug|Win32
		{ABBECC62-8779-458A-B8DC-F949363D29AF}.Debug|Win32.Build.0 = Debug|Win32
		{ABBECC62-8779-458A-B8DC-F949363D29AF}.Release|Win32.ActiveCfg = Release|Win32
		{ABBECC62-8779-458A-B8DC-F949363D29AF}.Release|Win32.Build.0 = Release|Win32
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
// ReadFromMemory.pch will be the pre-compiled header
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