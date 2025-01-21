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
using System.Drawing;
using System.Drawing.Imaging;
using Bytescout.BarCode;

namespace GeneratePharmaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create new barcode
                using (Barcode barcode = new Barcode())
                {
                    barcode.RegistrationName = "demo";
                    barcode.RegistrationKey = "demo";

                    // Set symbology
                    barcode.Symbology = SymbologyType.PharmaCode;

                    // optional margins
                    barcode.Margins = new Margins(5, 5, 5, 5);

                    // Set Value
                    barcode.Value = "12345";

                    // Set PharmaCode options:
                    //barcode.Options.PharmaCodeSupplementaryCode = true;
                    //barcode.Options.PharmaCodeSupplementaryBarColor = Color.Orange;
                    //barcode.Options.PharmaCodeMiniature = true;
                    //barcode.Options.PharmaCodeTwoTrack = true;

                    // Save 300 DPI Image
                    barcode.ResolutionX = barcode.ResolutionY = 300;
                    barcode.SaveImage("300dpi.png", ImageFormat.Png);

                    // Save 600 DPI Image
                    barcode.ResolutionX = barcode.ResolutionY = 600;
                    barcode.SaveImage("600dpi.png", ImageFormat.Png);
                }

                // Show image in default image viewer
                Process.Start("300dpi.png");
                Process.Start("600dpi.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
