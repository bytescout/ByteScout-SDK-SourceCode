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

	// you may also refer to the tlb from \net4.00\ folder
	// you may also want to include the tlb file into the project so you could compile it and use intellisense for it
	#import "c:\\Program Files\\Bytescout PDF Extractor SDK\\net2.00\\Bytescout.PDFExtractor.tlb" raw_interfaces_only

	using namespace Bytescout_PDFExtractor;

	int _tmain(int argc, _TCHAR* argv[])
	{
		// Initialize COM.
		HRESULT hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);

		// Create the interface pointer.
		_DocumentSplitterPtr pIDocumentSplitter(__uuidof(DocumentSplitter));

		// Set the registration name and key
		// Note: You should use _bstr_t or BSTR to pass string to the library because of COM requirements
		_bstr_t bstrRegName(L"DEMO"); 
		pIDocumentSplitter->put_RegistrationName(bstrRegName);
		
		_bstr_t bstrRegKey(L"DEMO");
		pIDocumentSplitter->put_RegistrationKey(bstrRegKey);

		// you may enable optimization for extracted pages from documents
		// pIDocumentSplitter->put_OptimizeSplittedDocuments = true;

		// Load sample PDF document
		HRESULT sRes = S_OK;
		//1. extract selected pages (!note: page numbers are 1-based)
		_bstr_t bstrPath(L"..\\..\\sample2.pdf");
		_bstr_t bstrParam(L"page2.pdf");
		sRes = pIDocumentSplitter->ExtractPage(bstrPath, bstrParam, 2);

		// 2. split the doc into 2 parts at page #2
		// (!) Note: page numbers are 1-based
		_bstr_t bstrPathInput(L"..\\..\\sample2.pdf");
		_bstr_t bstrParam1(L"part1.pdf");
		_bstr_t bstrParam2(L"part2.pdf");
		sRes = pIDocumentSplitter->Split(bstrPathInput, bstrParam1, bstrParam2, 2);

		// 3. merge page 2 extracted on step 1 along with base pdf
		// Create the interface pointer.
		_DocumentMergerPtr pIDocumentMerger(__uuidof(DocumentMerger));
		//_bstr_t bstrRegName(L"DEMO"); 
		pIDocumentMerger->put_RegistrationName(bstrRegName);		
		//_bstr_t bstrRegKey(L"DEMO");
		pIDocumentMerger->put_RegistrationKey(bstrRegKey);

		// merge 2 files into the 3rd one
		_bstr_t bstrParamMerge1(L"page2.pdf");
		_bstr_t bstrParamMerge2(L"..\\..\\sample2.pdf");
		_bstr_t bstrParamMergeOutput(L"merged.pdf");

		sRes = pIDocumentMerger->Merge2(bstrParamMerge1, bstrParamMerge2,bstrParamMergeOutput);

		// finally release both instances
		pIDocumentSplitter->Release();
		pIDocumentMerger->Release();

		// uninitialize ActiveX COM support
		CoUninitialize();

		return 0;
	}

