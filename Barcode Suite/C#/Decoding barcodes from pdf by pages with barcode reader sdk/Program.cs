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
using Bytescout.BarCodeReader;

namespace BarcodesFromPDF
{
    class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";

            // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
            // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
            // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
            reader.BarcodeTypesToFind.All1D = true;

			// Input filename
            string fileName = "example.pdf";

            // Pages from which barcodes to be fetched
			int[] readFromPages = { 1, 2 };

            foreach (var pageNo in readFromPages)
            {
                Console.WriteLine("\n\nReading barcodes from PDF page {0}...", pageNo);

                // Decoding barcodes from PDF on page-by-page basis instead of reading whole page
                FoundBarcode[] barcodes = reader.ReadFrom(fileName, (pageNo - 1));

                // Found results
                foreach (FoundBarcode barcode in barcodes)
                {
                    Console.WriteLine("Found Barcode, Type: '{0}', Value: '{1}', Position: {2}", 
                        barcode.Type, barcode.Value, barcode.Rect);
                }
            }

            // Cleanup
            reader.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
