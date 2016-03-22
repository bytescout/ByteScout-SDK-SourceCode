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
