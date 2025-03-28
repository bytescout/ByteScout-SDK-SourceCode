//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.BarCode;

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and activate QRCode instance
            using (QRCode barcode = new QRCode())
            {
                barcode.RegistrationName = "demo";
                barcode.RegistrationKey = "demo";

                // Set value            
                barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890";

                // Uncomment if you don't need margins
                //barcode.Margins = new Margins(0, 0, 0, 0);
                //barcode.DrawQuietZones = false;

                // Save barcode image to file
                barcode.SaveImage("result.png");
            }

            // Open the image in default image viewer (for demo purpose)
            Process.Start("result.png");
        }
    }
}
