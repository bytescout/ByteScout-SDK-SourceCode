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


using System.Text;
using System.Diagnostics;
using Bytescout.BarCode;

namespace UnicodeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and activate QRCode instance 
            using (QRCode barcode = new QRCode("demo", "demo"))
            {
                // Set the character encoding to UTF8
                barcode.CharacterEncoding = Encoding.UTF8;

                // Set Unicode barcode value
                barcode.Value = "日本";

                // Show barcode caption (optional)
                barcode.DrawCaption = true;

                // Save barcode image to file
                barcode.SaveImage("result.png");
            }

            // Open the image in default image viewer (for the demo purpose)
            Process.Start("result.png");
        }
    }
}
