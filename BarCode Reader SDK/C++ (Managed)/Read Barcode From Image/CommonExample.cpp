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

using namespace System;
using namespace System::IO;
using namespace System::Drawing;
using namespace Bytescout::BarCodeReader;

int main(array<System::String ^> ^args)
{
	String ^path = "BarcodePhoto.jpg";
	
	Console::WriteLine("Reading barcode(s) from image " + Path::GetFullPath(path));

	Reader ^bc = gcnew Reader();
	
	// Set to find all barcode types
	bc->BarcodeTypesToFind->All = true;
	// But we recommend to use specific barcode types to avoid false positives, e.g.:
	// bc->BarcodeTypesToFind->QRCOde = true;
	// bc->BarcodeTypesToFind->Code39 = true;
	
	// Decode barcodes
	bc->ReadFrom(path);

	for (int i=0; i < bc->FoundCount; i++)
	{
		Console::WriteLine("Found barcode with type: " + bc->GetFoundBarcodeType(i).ToString() + " and value: " + bc->GetFoundBarcodeValue(i));
	}

	Console::WriteLine("Press any key to exit..");            
	Console::ReadKey();

    return 0;
}
