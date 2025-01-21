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

namespace QRCodewithJSON
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
                    barcode.Symbology = SymbologyType.QRCode;

                    // Set JSON string as a value
                    barcode.Value = @"{ 'name':'John', 'age':30, 'cars':[ 'Ford', 'BMW', 'Fiat' ] }";

                    // Save barcode to image
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
