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

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

            // Read barcodes
            reader.ReadFrom(ImageFile);

			// Cleanup
			reader.Dispose();
			
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
