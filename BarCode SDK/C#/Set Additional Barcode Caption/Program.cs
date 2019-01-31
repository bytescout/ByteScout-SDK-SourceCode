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


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Diagnostics;

using Bytescout.BarCode;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.Codabar;
            // Set value
            barcode.Value = "123456";

            // Set custom additional caption
            barcode.AdditionalCaption = "Custom caption";
            // Set additional caption font
            barcode.AdditionalCaptionFont = new Font("Comic Sans MS", 12);
            // Set additional caption position
            barcode.AdditionalCaptionPosition = CaptionPosition.Above;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
