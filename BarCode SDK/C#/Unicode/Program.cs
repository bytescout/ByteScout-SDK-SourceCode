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
using System.Text;
using System.Diagnostics;
using System.Drawing;
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
            barcode.Symbology = SymbologyType.QRCode;

            // set QR code encoding to UTF8 so will be able to encode Unicode 
            barcode.Options.Encoding = Encoding.UTF8;

            // Set barcode value to ?           
            barcode.Value = "?";

            // show caption for 2d barcodes
            barcode.DrawCaptionFor2DBarcodes = true;

            // set caption font to Arial Unicode MS so it will display the caption
            barcode.CaptionFont = new Font("Arial Unicode MS", 8);

            // Save barcode to image
            barcode.SaveImage("qrcode.png");

            // Show image in default image viewer
            Process.Start("qrcode.png");
        }
    }
}
