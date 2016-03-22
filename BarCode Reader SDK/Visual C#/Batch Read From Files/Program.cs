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

namespace BatchProcessing
{
    class Program
    {
        static void Main()
        {
            // Get all JPG files from the current folder
            string[] filesToScan = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.jpg");
            
            // Create barcode reader instance
            using (Reader bc = new Reader())
            {
            	bc.RegistrationName = "demo";
				bc.RegistrationKey = "demo";
			
                // Set up to search for EAN13 barcodes only to speed up the processing
                bc.BarcodeTypesToFind.EAN13 = true;
                // Set up to scan horizontal barcodes only to speed up the processing
                bc.Orientation = OrientationType.HorizontalFromLeftToRight;
                
                // Iterate over images and read barcodes
                for (int i = 0; i < filesToScan.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Reading barcodes from image \"{0}\"...", filesToScan[i]);

                    // Read barcodes from image
                    FoundBarcode[] barcodes = bc.ReadFrom(filesToScan[i]);

                    // Write out results to console
                    foreach (FoundBarcode barcode in barcodes)
                        Console.WriteLine("Found barcode with type \"{0}\" and value \"{1}\".", barcode.Type, barcode.Value);
                    
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
