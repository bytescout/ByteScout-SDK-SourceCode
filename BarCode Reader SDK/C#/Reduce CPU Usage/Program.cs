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

namespace ReduceCPUUsage
{
    class Program
    {
        static void Main()
        {
            // Barcode reader instance
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";

            /*
             If you are reading barcodes from PDF then you may reduce CPU and RAM load using the following approach:
                - instead of using All1D or All2D barcode types, set it to the specific types you have in your documents like PDF417 or Code 39. You may set multiple barcode types if you need to
                - reduce PDF rendering resolution to 200-150 dpi (depends on your document)
                - set specific pages to read barcodes from. If you have barcodes on 2 first pages only then change the code to read barcodes from first 2 pages only.
                - if barcodes are always located / printed in the same corner then also specify the area to read from instead of whole page for scanning
             */

            // Input filename
            string inputFileName = "barcode_multipage.pdf";

            // Set specific barcode type to read
            reader.BarcodeTypesToFind.Code128 = true;

            // Reduce PDF rendering resolution
            reader.PDFRenderingResolution = 150;

            // Set specific area to read from
            reader.CustomAreaLeft = 407;
            reader.CustomAreaTop = 494;
            reader.CustomAreaHeight = 605;
            reader.CustomAreaWidth = 999;

            // Set specific page to read from along with filename
            reader.ReadFromPdfFilePage(inputFileName, 1, 1);

            // Get all found barcodes
            FoundBarcode[] barcodes = reader.FoundBarcodes;

            // Display found barcodes
            Console.WriteLine("Reading barcode(s) from PDF file...");

            foreach (FoundBarcode barcode in barcodes)
            {
                Console.WriteLine("Found Barcode - Type: '{0}', Value: '{1}'", barcode.Type, barcode.Value);
            }

            // Cleanup
            reader.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
