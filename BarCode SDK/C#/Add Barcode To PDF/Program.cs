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


using Bytescout.BarCode;

namespace AddBarcodeToPdfDocument
{
    class Program
    {
        static void Main()
        {
            // Create new barcode and register it.
            Barcode barcode = new Barcode();
            barcode.RegistrationName = "demo";
            barcode.RegistrationKey = "demo";

            // Set symbology
            barcode.Symbology = SymbologyType.DataMatrix;
            // Set value
            barcode.Value = "Sample barcode";

            // Place barcode at top-right corner of every document page
            barcode.DrawToPDF("wikipedia.pdf", -1, 500, 50, "result.pdf");

            // Open output file in default PDF viewer
            System.Diagnostics.Process.Start("result.pdf");
        }
    }
}
