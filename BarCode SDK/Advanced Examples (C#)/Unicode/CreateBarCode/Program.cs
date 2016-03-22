//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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

            // Set barcode value to 是           
            barcode.Value = "是";

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
