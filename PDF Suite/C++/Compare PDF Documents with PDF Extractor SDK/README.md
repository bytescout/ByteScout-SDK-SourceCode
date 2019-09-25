## compare PDF documents with PDF extractor SDK in C++ using ByteScout PDF Suite

### compare PDF documents with PDF extractor SDK in C++

ByteScout tutorials describe the stuff for programmers who use C++. ByteScout PDF Suite was created to assist compare PDF documents with PDF extractor SDK in C++. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

C++ code snippet like this for ByteScout PDF Suite works best when you need to quickly implement compare PDF documents with PDF extractor SDK in your C++ application.  Just copy and paste this C++ sample code to your C++ application's code editor, add a reference to ByteScout PDF Suite (if you haven't added yet) and you are ready to go! This basic programming language sample code for C++ will do the whole work for you in implementing compare PDF documents with PDF extractor SDK in your app.

Trial version can be downloaded from our website for free. It contains this and other source code samples for C++.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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

		// Load first document
		_TextExtractorPtr document1(__uuidof(TextExtractor));
		document1->put_RegistrationName(_bstr_t(L"DEMO"));
		document1->put_RegistrationKey(_bstr_t(L"DEMO"));
		document1->LoadDocumentFromFile(_bstr_t(L"..\\..\\comparison1.pdf"));

		// Load second  document
		_TextExtractorPtr document2(__uuidof(TextExtractor));
		document2->put_RegistrationName(_bstr_t(L"DEMO"));
		document2->put_RegistrationKey(_bstr_t(L"DEMO"));
		document2->LoadDocumentFromFile(_bstr_t(L"..\\..\\comparison2.pdf"));

		// Compare documents
		_TextComparerPtr comparer(__uuidof(TextComparer));
		comparer->put_RegistrationName(_bstr_t(L"DEMO"));
		comparer->put_RegistrationKey(_bstr_t(L"DEMO"));
		DECIMAL result;
		comparer->Compare((_BaseTextExtractorPtr) document1, (_BaseTextExtractorPtr) document2, &result);

		// Generate report
		VARIANT_BOOL ok;
		comparer->GenerateHtmlReport_2(_bstr_t(L"report.html"), &ok);

		document1->Release();
		document2->Release();
		comparer->Release();

		CoUninitialize();

		return 0;
	}


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