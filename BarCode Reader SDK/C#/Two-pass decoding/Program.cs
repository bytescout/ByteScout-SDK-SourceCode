//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.BarCodeReader;
using System;

namespace TwoPassDecoding
{
    class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";
            
            // Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
            // Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
		    // or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
			reader.BarcodeTypesToFind.All1D = true;

            // Input barcode document
            var inputDocument = "example.pdf";

            Console.WriteLine("First Attempt - Reading barcodes from PDF document...");
            var foundBarcodesFirstAttempt = GetBarcodes(reader, inputDocument);

            if(foundBarcodesFirstAttempt != null && foundBarcodesFirstAttempt.Length > 0)
            {
                DisplayBarcodeResult(foundBarcodesFirstAttempt);
            }
            else
            {
                Console.WriteLine("No Barccodes found...");
                // Try Second attempt
                Console.WriteLine("\n\nSecond Attempt - Reading barcodes from PDF document...");

                // Change PDF rendering resolution
                reader.PDFRenderingResolution = 150;

                // Get found barcodes 
                var foundBarcodesSecondAttempt = GetBarcodes(reader, inputDocument);

                if(foundBarcodesSecondAttempt != null && foundBarcodesSecondAttempt.Length > 0)
                {
                    DisplayBarcodeResult(foundBarcodesSecondAttempt);
                }
            }

            // Cleanup
            reader.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// Get Barcodes
        /// </summary>
        public static FoundBarcode[] GetBarcodes(Reader reader, string inputDocument)
        {
            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */
            return reader.ReadFrom(inputDocument);
        }

        /// <summary>
        /// Display found barcodes
        /// </summary>
        public static void DisplayBarcodeResult(FoundBarcode[] foundBarcodes)
        {
            foreach (FoundBarcode barcode in foundBarcodes)
            {
                Console.WriteLine("Found barcode with type '{0}' and value '{1}' on page {2} at {3}",
                    barcode.Type, barcode.Value, barcode.Page, barcode.Rect);
            }
        }

    }
}
