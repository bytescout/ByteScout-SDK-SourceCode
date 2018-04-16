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

namespace InterruptProcessing
{
    class Program
    {
        const string ImageFile = "1d_barcodes.pdf";

        static void Main()
        {
            Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(ImageFile));

            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Set barcode types to find
            reader.BarcodeTypesToFind.All1D = true;

            reader.BarcodeFound += Reader_BarcodeFound;

            // Read barcodes
            reader.ReadFrom(ImageFile);

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }

        private static void Reader_BarcodeFound(object sender, BarcodeFoundEventArgs e)
        {
            Console.WriteLine("Found barcode with type '{0}' and value '{1}'", e.Barcode.Type, e.Barcode.Value);

            if (e.Count == 5)
            {
                // Cancel after 5 barcodes found
                e.Cancel = true;

                Console.WriteLine("Cancelled.");
            }
        }
    }
}
