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
	pIBarcode->put_Symbology(SymbologyType_DataMatrix);

	// Set monochrome output 
	pIBarcode->put_ProduceMonochromeImages(VARIANT_TRUE);

	// Set barcode value
	BSTR value = ::SysAllocString(L"Barcode Value 1234567890");
	pIBarcode->put_Value(value);
	::SysFreeString(value);

	// Save barcode image
	BSTR fileName = ::SysAllocString(L"result.png");
	pIBarcode->SaveImage(fileName);
	::SysFreeString(fileName);

	pIBarcode->Release();

	// Uninitialize COM.
	CoUninitialize();

	return 0;
}

