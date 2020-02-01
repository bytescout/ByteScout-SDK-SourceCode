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


// ReadFromMemory.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "atlbase.h"

#import "c:\\Program Files\\Bytescout BarCode Reader SDK\\net4.00\\Bytescout.BarCodeReader.tlb" raw_interfaces_only
using namespace Bytescout_BarCodeReader;

int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
	HRESULT hr = CoInitialize(NULL);

	// Create the interface pointer.
	IReaderPtr pIReader(__uuidof(Reader));

	// set the registration name and key
	BSTR regname = ::SysAllocString(L"DEMO");
	pIReader->put_RegistrationName(regname);
	SysFreeString(regname);
	BSTR regkey = ::SysAllocString(L"DEMO");
	pIReader->put_RegistrationKey(regkey);
	SysFreeString(regkey);

	// Set barcode type to find
	_BarcodeTypeSelectorPtr pBarcodeTypesToFind;
	pIReader->get_BarcodeTypesToFind(&pBarcodeTypesToFind);
	pBarcodeTypesToFind->put_GS1DataBarExpanded(VARIANT_TRUE);

	// Get full path of sample barcode image file
	WCHAR file[MAX_PATH];
	::GetFullPathName(L"GS1DataBarExpanded.png", MAX_PATH, file, NULL);

	// Load file content to byte array (for demonstration purpose)
	HANDLE hFile = CreateFile(file, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);
	DWORD fileSize = GetFileSize(hFile, NULL);
	byte* pBuffer = new byte[fileSize];
	DWORD numberOfBytesRead;
	ReadFile(hFile, pBuffer, fileSize, &numberOfBytesRead, NULL);
	CloseHandle(hFile);

	// Read barcode from memory
	IStream* stream = SHCreateMemStream(pBuffer, fileSize);
	hr = pIReader->ReadFromStream(stream);

	stream->Release();
	delete[] pBuffer;

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
		wprintf(L"no barcodes found");
	}

	// Uninitialize COM.
	CoUninitialize();
	
	wprintf(L"\nHit key to continue\n");
	getchar();

	return 0;
}

