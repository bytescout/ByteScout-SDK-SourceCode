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

namespace DecodeDamagedCode128
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create and activate Bytescout.BarCodeReader.Reader instance
                using (Reader reader = new Reader("demo", "demo"))
                {
                    // Set barcode type to find
                    reader.BarcodeTypesToFind.Code128 = true;

                    /* -----------------------------------------------------------------------
                    NOTE: We can read barcodes from specific page to increase performance.
                    For sample please refer to "Decoding barcodes from PDF by pages" program.
                    ----------------------------------------------------------------------- */

                    // Read barcodes
                    FoundBarcode[] barcodes = reader.ReadFrom("corrupted_barcode_code128.png");

                    foreach (FoundBarcode code in barcodes)
                        Console.WriteLine("Found barcode with type '{0}' and value '{1}'", code.Type, code.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
