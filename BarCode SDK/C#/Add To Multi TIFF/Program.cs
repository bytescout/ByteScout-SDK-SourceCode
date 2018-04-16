//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using Bytescout.BarCode;

namespace AddBarcodeToMultipageTiff
{
	class Program
	{
		static void Main()
		{
            // Create new barcode and register it.
            Barcode barcode = new Barcode();
			barcode.RegistrationName = "demo";
			barcode.RegistrationKey = "demo";

            // Set symbology
            barcode.Symbology = SymbologyType.PDF417;
            // Set value
            barcode.Value = "Sample barcode";

            // Place barcode at bottom-right corner of the the first TIFF page
			barcode.DrawToImage("wikipedia.tif", 0, 550, 1100, "result.tif");

            // Open output file in default image viewer
            System.Diagnostics.Process.Start("result.tif");
		}
	}
}
