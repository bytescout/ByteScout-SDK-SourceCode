//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


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

