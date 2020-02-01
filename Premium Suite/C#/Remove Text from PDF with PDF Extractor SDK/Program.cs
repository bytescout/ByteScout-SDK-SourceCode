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

namespace RemoveText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover instance
            Remover remover = new Remover("demo", "demo");

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"sample1.pdf");

            // Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
            // NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
            // the whole PDF text object containing the search string.
            remover.RemoveText(0, "LOREM IPSUM", true, @"result1.pdf");

            // Remove text objects contained in the specified rectangle or intersecting with it.
            // NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
            // to split PDF text objects.
            remover.RemoveText(0, new RectangleF(74f, 550f, 489f, 67f), @"result2.pdf");

            // Remove text object contained in the specified point.
            // NOTE: The removed text might be larger than a word in the specified point. Currently the Remover is able 
            // to remove only the whole PDF text object containing the word.
            remover.RemoveText(0, new PointF(121f, 230f), @"result3.pdf");
            
            // Clean up.
            remover.Dispose();
        }
    }
}
