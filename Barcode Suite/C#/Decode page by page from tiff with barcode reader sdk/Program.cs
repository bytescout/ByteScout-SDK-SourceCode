//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.BarCodeReader;

namespace BarcodesFromTIFF
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

            // Input filename
            string fileName = "multipage.tif";

            // Pages from which barcodes to be fetched
            int[] readFromPages = { 1, 2, 4, 6 };

            foreach (var pageNo in readFromPages)
            {
                Console.WriteLine("\n\nReading barcodes from TIFF page {0}...", pageNo);

                // Decoding barcodes from TIFF on page-by-page basis, instead of reading whole page
                FoundBarcode[] barcodes = reader.ReadFrom(fileName, (pageNo - 1));

                // Found results
                foreach (FoundBarcode barcode in barcodes)
                {
                    Console.WriteLine("Found Barcode, Type: '{0}', Value: '{1}', Position: {2}",
                        barcode.Type, barcode.Value, barcode.Rect);
                }
            }

            // Cleanup
            reader.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
