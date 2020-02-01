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

            // Open file to export results
            StreamWriter resultsCsvFile = File.CreateText("results.csv");

            // Create barcode reader instance
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";

            // Set barcode types for searching
            reader.BarcodeTypesToFind.EAN13 = true;
            
            // Iterate over images and read barcodes
            foreach (string file in filesToScan)
            {
                Console.WriteLine();
                Console.WriteLine("Reading barcodes from image \"{0}\"...", file);

                /* -----------------------------------------------------------------------
                NOTE: We can read barcodes from specific page to increase performance .
                For sample please refer to "Decoding barcodes from PDF by pages" program.
                ----------------------------------------------------------------------- */

                // Read barcodes from image
                FoundBarcode[] barcodes = reader.ReadFrom(file);

                // Display results in console
                foreach (FoundBarcode barcode in barcodes)
                    Console.WriteLine("Found barcode with type \"{0}\" and value \"{1}\".", barcode.Type, barcode.Value);

                // Write results to file in CSV format. Note, you can also export to TXT and XML.
                string csv = reader.ExportFoundBarcodesToCSV();
                resultsCsvFile.Write(csv);
            }

			// Cleanup
            reader.Dispose();
            resultsCsvFile.Dispose();


            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
