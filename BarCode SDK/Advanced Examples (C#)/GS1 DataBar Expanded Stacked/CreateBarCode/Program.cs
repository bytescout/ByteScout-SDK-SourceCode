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
            barcode.Symbology = SymbologyType.GS1_DataBar_Expanded_Stacked;
            // Set value
            barcode.Value = "(01)04512345678906(3930)3921980(17)091225(10)10000";
            
            // Set the number of segments in line
			barcode.Options.SegmentsNumber = 6;

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
