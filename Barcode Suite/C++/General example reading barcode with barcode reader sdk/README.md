## general example reading barcode with barcode reader sdk in C++ using ByteScout Barcode Suite

### Learn to code general example reading barcode with barcode reader sdk in C++: How-To tutorial

The example source codes on this page will display you how to make general example reading barcode with barcode reader sdk in C++. General example reading barcode with barcode reader sdk in C++ can be applied with ByteScout Barcode Suite. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

C++ code snippet like this for ByteScout Barcode Suite works best when you need to quickly implement general example reading barcode with barcode reader sdk in your C++ application. Follow the steps-by-step instructions from the scratch to work and copy and paste code for C++ into your editor. This basic programming language sample code for C++ will do the whole work for you in implementing general example reading barcode with barcode reader sdk in your app.

ByteScout Barcode Suite is available as a free trial. You may get it from our website along with all other source code samples for C++ applications.

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

##### ****CommonExample.cpp:**
    
```
#include "stdafx.h"

#import "c:\\Program Files\\Bytescout BarCode Reader SDK\\net2.00\\Bytescout.BarCodeReader.tlb" raw_interfaces_only

using namespace Bytescout_BarCodeReader;

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
	pBarcodeTypesToFind->put_GS1DataBarExpanded(VARIANT_TRUE);

	// Get full path of sample barcode image file
	WCHAR file[MAX_PATH];
	::GetFullPathName(L"GS1DataBarExpanded.png", MAX_PATH, file, NULL);

	// Read barcode from file
	hr = pIReader->ReadFromFile(_bstr_t(file));

	// check if file was not found
	if (hr == E_FAIL)
	{
		wprintf(L"File was not found: %s\n", file);
	}
	else
	{
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
			wprintf(L"No barcodes found.");
		}
	}

	// Uninitialize COM.
	CoUninitialize();

	// Wait until user press any key
	system("pause");

	return 0;
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****stdafx.cpp:**
    
```
// stdafx.cpp : source file that includes just the standard includes
// BarcodeReaderExample.pch will be the pre-compiled header
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


#define WIN32_LEAN_AND_MEAN		// Exclude rarely-used stuff from Windows headers
#include <stdio.h>
#include <tchar.h>

```

<!-- code block end -->