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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace RemoveSensitiveDataFromRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover instance
            Remover remover = new Remover("demo", "demo");

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"sample1.pdf");

            // Remove text objects contained in the specified rectangle or intersecting with it.
            // NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
            // to split PDF text objects.
            remover.RemoveText(0, new RectangleF(45f, 101f, 183f, 310f), @"result1.pdf");

            // Open output file in default application
            System.Diagnostics.Process.Start("result1.pdf");

            // Clean up.
            remover.Dispose();
        }
    }
}
