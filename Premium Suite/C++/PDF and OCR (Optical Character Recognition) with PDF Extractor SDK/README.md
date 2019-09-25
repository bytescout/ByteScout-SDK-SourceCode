## PDF and OCR (optical character recognition) with PDF extractor SDK in C++ and ByteScout Premium Suite

### Build PDF and OCR (optical character recognition) with PDF extractor SDK in C++: ### Step-by-step instructions on how to do PDF and OCR (optical character recognition) with PDF extractor SDK in C++

ByteScout tutorials describe the stuff for programmers who use C++. PDF and OCR (optical character recognition) with PDF extractor SDK in C++ can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this C++, code samples for C++, developers help to speed up the application development and writing a code when using ByteScout Premium Suite. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample C++ codes to implement PDF and OCR (optical character recognition) with PDF extractor SDK using ByteScout Premium Suite.

Visit our website to get a free trial version of ByteScout Premium Suite. Free trial contains many of source code samples to help you with your C++ project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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

##### ****CPPExample.cpp:**
    
```
	#include "stdafx.h"
	#include "comip.h"

	#import "c:\\Program Files\\Bytescout PDF Extractor SDK\\net4.00\\Bytescout.PDFExtractor.tlb" raw_interfaces_only

	using namespace Bytescout_PDFExtractor;

	int _tmain(int argc, _TCHAR* argv[])
	{
		// Initialize COM.
		HRESULT hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);

		// Create the interface pointer.
		_TextExtractorPtr pITextExtractor(__uuidof(TextExtractor));

		// Set the registration name and key
		// Note: You should use _bstr_t or BSTR to pass string to the library because of COM requirements
		_bstr_t bstrRegName(L"DEMO"); 
		pITextExtractor->put_RegistrationName(bstrRegName);
		
		_bstr_t bstrRegKey(L"DEMO");
		pITextExtractor->put_RegistrationKey(bstrRegKey);

		// Load sample PDF document
		_bstr_t bstrPath(L"..\\..\\sample_ocr.pdf");
		pITextExtractor->LoadDocumentFromFile(bstrPath);

		// Enable Optical Character Recognition (OCR)
		// in .Auto mode (SDK automatically checks if needs to use OCR or not)
		pITextExtractor->put_OCRMode(OCRMode_Auto);
		
		// Set the location of OCR language data files
		_bstr_t bstrOCRLangDataPath(L"c:\\Program Files\\Bytescout PDF Extractor SDK\\ocrdata");
		pITextExtractor->put_OCRLanguageDataFolder(bstrOCRLangDataPath);

		// Set OCR language
		_bstr_t bstrOCRLanguage(L"eng");
		pITextExtractor->put_OCRLanguage(bstrOCRLanguage);

		// Set PDF document rendering resolution
		pITextExtractor->put_OCRResolution(300);


		// You can also apply various preprocessing filters
		// to improve the recognition on low-quality scans.

		_ImagePreprocessingFiltersCollection* pIImagePreprocessingFilters;
		pITextExtractor->get_OCRImagePreprocessingFilters(&pIImagePreprocessingFilters);

		// Automatically deskew skewed scans
		//pIImagePreprocessingFilters->AddDeskew();

		// Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
		//pIImagePreprocessingFilters->AddVerticalLinesRemover();
		//pIImagePreprocessingFilters->AddHorizontalLinesRemover();

		// Repair broken letters
		//pIImagePreprocessingFilters->AddDilate();

		// Remove noise
		//pIImagePreprocessingFilters->AddMedian();

		// Apply Gamma Correction
		//pIImagePreprocessingFilters->AddGammaCorrection();

		// Add Contrast
		//pIImagePreprocessingFilters->AddContrast(20);


		// (!) You can use new OCRAnalyser class to find an optimal set of image preprocessing 
		// filters for your specific document.
		// See "OCR Analyser" example.


		// Save extracted text to file
		_bstr_t bstrOutputFile(L"output.txt");
		pITextExtractor->SaveTextToFile(bstrOutputFile);

		pITextExtractor->Release();

		CoUninitialize();

		return 0;
	}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****CPPExample.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2013
VisualStudioVersion = 12.0.40629.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}") = "CPPExample", "CPPExample.vcxproj", "{74A23FC0-E323-4980-9363-41326A457785}"
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