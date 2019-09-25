## How to get barcode to memory buffer with barcode sdk in C++ and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to get barcode to memory buffer with barcode sdk in C++

Quickly learn how to get barcode to memory buffer with barcode sdk in C++ with this sample source code. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to get barcode to memory buffer with barcode sdk using C++.

This prolific sample source code in C++ for ByteScout Premium Suite contains various functions and other necessary options you should do calling the API to get barcode to memory buffer with barcode sdk. This C++ sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check C++ sample code samples to see if they respond to your needs and requirements for the project.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for C++.

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

##### ****BarcodeGenerationExample.cpp:**
    
```
#include "stdafx.h"
#include <atlsafe.h> // For ATL::CComSafeArray

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
	pIBarcode->put_Symbology(SymbologyType_Code128);

	// Set barcode value
	BSTR value = ::SysAllocString(L"Abc123");
	pIBarcode->put_Value(value);
	::SysFreeString(value);

	// Get barcode image bytes.
	SAFEARRAY* pSafeArray;
	pIBarcode->GetImageBytesPNG(&pSafeArray);

	// Convert SAFEARRAY to byte array
	CComSafeArray<BYTE> safeArray;
	safeArray.Attach(pSafeArray);
	UINT count = safeArray.GetCount();
	BYTE* bytes = new BYTE[count];
	for (ULONG i = 0; i < count; i++)
		bytes[i] = safeArray.GetAt(i);

	// Check result by saving image bytes to file
	FILE* pFile;
	fopen_s(&pFile, "result.png", "wb");
	fwrite(bytes, 1, count, pFile);
	fclose(pFile);

	delete[] bytes;
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