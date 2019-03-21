//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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

