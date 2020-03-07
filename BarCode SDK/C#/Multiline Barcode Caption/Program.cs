//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
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
            barcode.Symbology = SymbologyType.GS1_DataMatrix;

            // Set GS1 barcode value            
            barcode.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811";

            // you may also set the value without brackets and the SDK will automatically add brackets where needed
            // also some values may include "|" character as the additional separator (for example, GS1 Australian Post)
            // barcode.Value = "01034531200000111729103010ABC123"; // it will be converted into "(01)03453120000011(17)291030(10)ABC123" automatically

            // you may also optionally check if this value is valid according to GS1 subtype rules
            // bool isValidValue = barcode.ValueIsValidGS1(barcode.Value));

            // Set additional caption
            barcode.AdditionalCaption = "New Caption Text";
            barcode.AdditionalCaption += "\nNew Caption Text 2nd Line";

            // Set additional caption position
            barcode.AdditionalCaptionPosition = CaptionPosition.After;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
