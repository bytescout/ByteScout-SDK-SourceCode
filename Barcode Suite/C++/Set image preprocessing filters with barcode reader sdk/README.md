## How to set image preprocessing filters with barcode reader sdk in C++ and ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set image preprocessing filters with barcode reader sdk in C++

An easy to understand sample source code to learn how to set image preprocessing filters with barcode reader sdk in C++ ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can set image preprocessing filters with barcode reader sdk in C++.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly set image preprocessing filters with barcode reader sdk in your C++ application. Just copy and paste the code into your C++ application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample C++ codes.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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

##### ****ImagePreprocessingFilters.cpp:**
    
```
#include "stdafx.h"

///
/// This example demonstrates the use of image filters to improve the decoding confidence or speed.
///

#import "c:\\Program Files\\Bytescout BarCode Reader SDK\\net2.00\\Bytescout.BarCodeReader.tlb" raw_interfaces_only

using namespace Bytescout_BarCodeReader;

void PrintFoundBarcodes(IReaderPtr pIReader);

int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
	HRESULT hr = CoInitialize(NULL);

	// Create the interface pointer.
	IReaderPtr pIReader(__uuidof(Reader));

	// set the registration name and key
	_bstr_t registrationName(L"DEMO");
	pIReader->put_RegistrationName(registrationName);

	_bstr_t registrationKey(L"DEMO");
	pIReader->put_RegistrationKey(registrationKey);

	// Set barcode type to find
	_BarcodeTypeSelectorPtr pBarcodeTypesToFind;
	pIReader->get_BarcodeTypesToFind(&pBarcodeTypesToFind);
	pBarcodeTypesToFind->put_Code128(VARIANT_TRUE);

	
	// Get image filters collection
	_ImagePreprocessingFiltersCollection* pIImageFilters;
	pIReader->get_ImagePreprocessingFilters(&pIImageFilters);

	
	// WORKING WITH LOW CONTRAST BARCODE IMAGES

	pIImageFilters->AddContrast(40);

	// Add contrast adjustment for low-contrast image
	_bstr_t sampleFile1(L".\\low-contrast-barcode.png");	
	wprintf(L"Image \"%s\"\n", static_cast<wchar_t*>(sampleFile1));

	pIReader->ReadFromFile(sampleFile1);
	PrintFoundBarcodes(pIReader);

	pIImageFilters->Clear();


	// WORKING WITH NOISY BARCODE IMAGES

	// Add median filter to lower a noise
	pIImageFilters->AddMedian();

	_bstr_t sampleFile2(L".\\noisy-barcode.png");
	wprintf(L"Image \"%s\"\n", static_cast<wchar_t*>(sampleFile2));

	pIReader->ReadFromFile(sampleFile2);
	PrintFoundBarcodes(pIReader);

	pIImageFilters->Clear();


	// WORKING WITH DENSE AND ILLEGIBLE BARCODES

	// Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
	pIImageFilters->AddScale_2(2.0);

	_bstr_t sampleFile3(L".\\too-dense-barcode.png");
	wprintf(L"Image \"%s\"\n", static_cast<wchar_t*>(sampleFile3));

	pIReader->ReadFromFile(sampleFile3);
	PrintFoundBarcodes(pIReader);

	pIImageFilters->Clear();


	// REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

	// Add the crop filter to cut off empty margins from the image.
	// This will not improve the recognition quality but may speed up the processing 
	// if you enabled multiple barcode types to search. 
	pIImageFilters->AddCropDark();

	_bstr_t sampleFile4(L".\\barcode-with-large-margins.png");
	wprintf(L"Image \"%s\"\n", static_cast<wchar_t*>(sampleFile4));

	pIReader->ReadFromFile(sampleFile4);
	PrintFoundBarcodes(pIReader);

	pIImageFilters->Clear();


	
	// Uninitialize COM.
	CoUninitialize();

	// Wait until user press any key
	system("pause");

	return 0;
}

void PrintFoundBarcodes(IReaderPtr pIReader)
{
	// Get found barcode count
	long count;
	pIReader->get_FoundCount(&count);

	// Get found barcode information
	for (int i = 0; i < count; i++)
	{
		SymbologyType type;
		pIReader->GetFoundBarcodeType(i, &type);
		wprintf(L"Barcode type: %d\n", type);

		float confidence;
		pIReader->GetFoundBarcodeConfidence(i, &confidence);
		wprintf(L"Barcode confidence: %f\n", confidence);

		BSTR bstrValue;
		pIReader->GetFoundBarcodeValue(i, &bstrValue);
		wprintf(L"Barcode value: %s\n", bstrValue);
		::SysFreeString(bstrValue);

		wprintf(L"\n");
	}

	if (count == 0)
	{
		wprintf(L"No barcodes found.\n");
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****ImagePreprocessingFilters.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}") = "ImagePreprocessingFilters", "ImagePreprocessingFilters.vcxproj", "{74A23FC0-E323-4980-9363-41326A457785}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Win32 = Debug|Win32
		Release|Win32 = Release|Win32
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{74A23FC0-E323-4980-9363-41326A457785}.Debug|Win32.ActiveCfg = Debug|Win32
		{74A23FC0-E323-4980-9363-41326A457785}.Debug|Win32.Build.0 = Debug|Win32
		{74A23FC0-E323-4980-9363-41326A457785}.Release|Win32.ActiveCfg = Release|Win32
		{74A23FC0-E323-4980-9363-41326A457785}.Release|Win32.Build.0 = Release|Win32
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
// CPPExample.pch will be the pre-compiled header
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