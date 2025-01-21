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
using System.Drawing;
using Bytescout.BarCode;

namespace ColoredQRCode
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

                // Set background color
                barcode.BackColor = Color.Yellow;
                // Set foreground color
                barcode.ForeColor = Color.Red;

                // Set value            
                barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890";
                
                // Save barcode to image
                barcode.SaveImage("result.png");
            }

            // Open the image in default image viewer (for demo purpose)
            Process.Start("result.png");
        }
    }
}
