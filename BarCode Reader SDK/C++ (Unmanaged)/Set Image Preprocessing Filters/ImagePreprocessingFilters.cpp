//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


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

