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
using System.Drawing.Imaging;
using System.IO;
using Bytescout.BarCodeReader;

namespace InspectDecodedBarcodes
{
    class Program
    {
        static int i = 0;
        const string ImageFile = "Code_39.png";

        static void Main()
        {
            Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(ImageFile));

            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Set barcode type to find
            reader.BarcodeTypesToFind.Code39 = true;

            reader.InspectDecodedBarcodes += Reader_InspectDecodedBarcodes;

            // Read barcodes
            FoundBarcode[] barcodes = reader.ReadFrom(ImageFile);

            foreach (FoundBarcode barcode in barcodes)
            {
                Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value);
            }
			
			// Cleanup
			reader.Dispose();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }

        /// <summary>
        /// Inspect decoded barcode event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="image"></param>
        private static void Reader_InspectDecodedBarcodes(object sender, System.Drawing.Image image)
        {
            var imageFile = $"page{++i}.png";
            image.Save(imageFile, ImageFormat.Png);

            Console.WriteLine($"Inspected image file saved as ${imageFile}");

            // You should explicitly dispose the image object to avoid resource leaks.
            image.Dispose();

        }
    }
}
