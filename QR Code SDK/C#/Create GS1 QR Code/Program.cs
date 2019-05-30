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

namespace GS1QRCode
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

                // Enable generation of GS1 version of QR Code
                barcode.IsGS1 = true;

                // Set value that is formatted according to GS1 specification
                barcode.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811";

                // Save barcode image to file
                barcode.SaveImage("result.png");
            }

            // Open the image in default image viewer (for demo purpose)
            Process.Start("result.png");
        }
    }
}
