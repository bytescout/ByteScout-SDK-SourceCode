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
            barcode.Symbology = SymbologyType.GS1_DataBar_Expanded;
            // Set value
            barcode.Value = "(01)08481234500016(11)080919(10)XYZ";

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
