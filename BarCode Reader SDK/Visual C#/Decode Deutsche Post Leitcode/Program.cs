//*******************************************************************
//       ByteScout BarCode Reader SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
