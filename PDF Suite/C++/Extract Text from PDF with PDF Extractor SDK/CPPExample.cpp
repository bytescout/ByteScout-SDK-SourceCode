//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


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
		_bstr_t bstrPath(L"..\\..\\sample3.pdf");
		pITextExtractor->LoadDocumentFromFile(bstrPath);

		// Save extracted text to file
		_bstr_t bstrOutputFile(L"output.txt");
		pITextExtractor->SaveTextToFile(bstrOutputFile);

		pITextExtractor->Release();

		CoUninitialize();

		return 0;
	}

