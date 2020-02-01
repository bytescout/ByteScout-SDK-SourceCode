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
using System.Diagnostics;
using Bytescout.BarCodeReader;

namespace BarcodesFromPDF
{
    class Program
    {
        static void Main()
        {
            using (var reader_default = new Reader("demo","demo"))
            {
                // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
                // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
                // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
                reader_default.BarcodeTypesToFind.All1D = true;

                // Using StopWatch to track operation time
                var sw_reader_default = new Stopwatch();
                sw_reader_default.Start();

                Console.WriteLine("Reading barcodes from PDF document with default resolution ...\n");

                FoundBarcode[] barcodes = reader_default.ReadFrom("example.pdf");

                foreach (FoundBarcode barcode in barcodes)
                {
                    Console.WriteLine("Found barcode with type '{0}' and value '{1}' on page {2} at {3}",
                        barcode.Type, barcode.Value, barcode.Page, barcode.Rect);
                }

                sw_reader_default.Stop();

                Console.WriteLine("\nELAPSED TIME (in milliseconds): " + sw_reader_default.ElapsedMilliseconds);
            }

            Console.WriteLine("\n===============\n");

            using (var reader_with_filter = new Reader("demo", "demo"))
            {
                // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
                // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
                // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
                reader_with_filter.BarcodeTypesToFind.All1D = true;

                // Setting PDF rendering resolution to 150
                reader_with_filter.PDFRenderingResolution = 150;

                // Using StopWatch to track operation time
                var sw_reader_optimized = new Stopwatch();
                sw_reader_optimized.Start();

                Console.WriteLine("Reading barcodes from PDF document with filter set for resolution ...\n");

                FoundBarcode[] barcodes = reader_with_filter.ReadFrom("example.pdf");

                foreach (FoundBarcode barcode in barcodes)
                {
                    Console.WriteLine("Found barcode with type '{0}' and value '{1}' on page {2} at {3}",
                        barcode.Type, barcode.Value, barcode.Page, barcode.Rect);
                }

                sw_reader_optimized.Stop();

                Console.WriteLine("\nELAPSED TIME (in milliseconds): " + sw_reader_optimized.ElapsedMilliseconds);

            }

             

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
