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
            barcode.Symbology = SymbologyType.Code128;
            // Set value
            barcode.Value = "123456";

            // Set Code 128 alphabet
            barcode.Options.Code128Alphabet = Code128Alphabet.C;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
