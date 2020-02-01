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


using System;
using Bytescout.BarCode;
using Bytescout.BarCodeReader;


namespace QRCodeWithImage
{
	class Program
	{
		static void Main(string[] args)
		{
			// GENERATE QR CODE WITH DECOARATION IMAGE:

			const string decorationImageFile = @".\logo.png";
			const string outputFile = @".\barcode.png";
			const string barcodeValue = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz";
			
			// Create and activate barcode generator instance
			using (Barcode barcode = new Barcode("demo", "demo"))
			{
				// Set barcode type
				barcode.Symbology = Bytescout.BarCode.SymbologyType.QRCode;

				// Set high QR Code error correction level
				barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High;

				// Set barcode value
				barcode.Value = barcodeValue;

				// Add decoration image and scale it to 15% of the barcode square
				barcode.AddDecorationImage(decorationImageFile, 15);

				// Save generated barcode
				barcode.SaveImage(outputFile);

				Console.WriteLine("Barcode saved to " + outputFile);


				// CHECK THE BARCODE IS DECODABLE:

				// Create and activate barcode reader instance
				using (Reader reader = new Reader("demo", "demo"))
				{
					// Enable QR Code decoding
					reader.BarcodeTypesToFind.QRCode = true;

					// Read barcode from generated image
					FoundBarcode[] foundBarcodes = reader.ReadFrom(outputFile);

					// Check result
					if (foundBarcodes.Length > 0 && foundBarcodes[0].Type == Bytescout.BarCodeReader.SymbologyType.QRCode)
						Console.WriteLine("Barcode is decodable.");
					else
						Console.WriteLine("Barcode is not decodable!");
				}

				Console.WriteLine();
				Console.WriteLine("Press any key...");
				Console.ReadKey();
			}
		}
	}
}
