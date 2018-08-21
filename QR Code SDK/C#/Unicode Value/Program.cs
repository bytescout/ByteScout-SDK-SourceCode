//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
