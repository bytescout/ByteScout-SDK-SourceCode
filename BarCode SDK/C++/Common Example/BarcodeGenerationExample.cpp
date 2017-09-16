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

	// Save barcode image
	BSTR fileName = ::SysAllocString(L"result.png");
	pIBarcode->SaveImage(fileName);
	::SysFreeString(fileName);

	pIBarcode->Release();

	// Uninitialize COM.
	CoUninitialize();

	return 0;
}

