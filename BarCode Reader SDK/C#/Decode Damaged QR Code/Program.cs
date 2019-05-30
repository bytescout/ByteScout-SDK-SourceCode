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


using System;
using Bytescout.BarCodeReader;

namespace DecodeDamagedQRCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create and activate Bytescout.BarCodeReader.Reader instance
                using (Reader reader = new Reader("demo", "demo"))
                {
                    // Set barcode type to find
                    reader.BarcodeTypesToFind.QRCode = true;

                    // Read barcodes
                    FoundBarcode[] barcodes = reader.ReadFrom("corrupted_barcode_qrcode.png");

                    foreach (FoundBarcode code in barcodes)
                        Console.WriteLine("Found barcode with type '{0}' and value '{1}'", code.Type, code.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
