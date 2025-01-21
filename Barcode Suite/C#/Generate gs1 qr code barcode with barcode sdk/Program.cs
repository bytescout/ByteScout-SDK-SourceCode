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
using System.Diagnostics;
using Bytescout.BarCode;

namespace GS1QRCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create and activate barcode generator instance
                using (Barcode barcode = new Barcode("demo", "demo"))
                {
                    // Set barcode type
                    barcode.Symbology = SymbologyType.GS1_QRCode;

                    // GS1 QR Code requires a value that is formatted according to GS1 specification.
                    barcode.Value = @"(01)07046261398572(17)130331(10)TEST5632(21)19067811811";

                    // Save barcode to image file
                    barcode.SaveImage("result.png");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
