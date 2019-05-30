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
            Barcode barcode = new Barcode("demo", "demo");

            // Set symbology
            barcode.Symbology = SymbologyType.QRCode;

            // set QR code encoding to UTF8 so will be able to encode Unicode 
            barcode.Options.Encoding = Encoding.UTF8;

            // Set Unicode barcode value string 日本
            barcode.Value = "日本";

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
