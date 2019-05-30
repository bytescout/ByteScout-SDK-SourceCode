//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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
