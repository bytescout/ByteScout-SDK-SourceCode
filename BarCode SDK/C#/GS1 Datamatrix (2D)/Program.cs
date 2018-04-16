//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


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
            barcode.Value = "(01)03453120000011(17)291030(10)ABC123";

 	    // you may also set the value without brackets and the SDK will automatically add brackets where needed
	    // also some values may include "|" character as the additional separator (for example, GS1 Australian Post)
	    // barcode.Value = "01034531200000111729103010ABC123"; // it will be converted into "(01)03453120000011(17)291030(10)ABC123" automatically

	    // you may also optionally check if this value is valid according to GS1 subtype rules
	    // bool isValidValue = barcode.ValueIsValidGS1(barcode.Value));

            // Save barcode to image
            barcode.SaveImage("result.png");

            // Show image in default image viewer
            Process.Start("result.png");
        }
    }
}
