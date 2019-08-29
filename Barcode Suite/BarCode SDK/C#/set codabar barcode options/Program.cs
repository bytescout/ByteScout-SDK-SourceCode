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

            // Checksum algorithm
            barcode.Options.CodabarChecksumAlgorithm = CodabarChecksumAlgorithm.Modulo9;
            // Start symbol
            barcode.Options.CodabarStartSymbol = CodabarSpecialSymbol.C;
            // Stop symbol
            barcode.Options.CodabarStopSymbol = CodabarSpecialSymbol.A;

            // Draw intercharacter gap
            barcode.Options.DrawIntercharacterGap = true;
            // Show start/stop symbols
            barcode.Options.ShowStartStop = true;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
