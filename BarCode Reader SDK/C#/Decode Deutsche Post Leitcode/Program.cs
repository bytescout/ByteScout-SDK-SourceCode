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


using System;
using System.IO;

using Bytescout.BarCodeReader;

namespace ReadDeutschePostLeitcode
{
    class Program
    {
        const string ImageFile = "DeutschePostLeitcode.png";

        static void Main()
        {
            Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(ImageFile));

            Reader bc = new Reader();
            bc.RegistrationName = "demo";
			bc.RegistrationKey = "demo";

            // Set barcode type to find
            bc.BarcodeTypesToFind.Interleaved2of5 = true; // "Deutsche Post Leitcode" is subset of "Interleaved 2 of 5" barcode

            // Read barcodes
            FoundBarcode[] barcodes = bc.ReadFrom(ImageFile);

            foreach (FoundBarcode barcode in barcodes)
            {
                Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value);
            }

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
