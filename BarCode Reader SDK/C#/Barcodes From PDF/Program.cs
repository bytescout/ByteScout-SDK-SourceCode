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


using System;
using Bytescout.BarCodeReader;

namespace BarcodesFromPDF
{
    class Program
    {
        static void Main()
        {
            Reader barcodeReader = new Reader();
            barcodeReader.RegistrationName = "demo";
			barcodeReader.RegistrationKey = "demo";
            
            // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
            // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
		    // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
			barcodeReader.BarcodeTypesToFind.All1D = true;

            Console.WriteLine("Reading barcodes from PDF document...");

            FoundBarcode[] barcodes = barcodeReader.ReadFrom("example.pdf");

            foreach (FoundBarcode barcode in barcodes)
            {
                Console.WriteLine("Found barcode with type '{0}' and value '{1}' on page {2} at {3}", 
                	barcode.Type, barcode.Value, barcode.Page, barcode.Rect);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
