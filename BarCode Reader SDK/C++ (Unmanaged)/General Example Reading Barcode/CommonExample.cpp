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

