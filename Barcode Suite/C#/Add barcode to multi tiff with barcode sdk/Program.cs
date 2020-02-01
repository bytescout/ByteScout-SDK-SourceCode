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
