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

