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


// This example demonstrates how to split document into seperate pages

using Bytescout.PDFExtractor;
using System;
using System.IO;
using System.Linq;

namespace SplittingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "sample.pdf";

            using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
            {
                splitter.OptimizeSplittedDocuments = true;

                //# Create list of page numbers in form "1,2,3,4,5,...,n" #
                // 1. Get Page Count
                int pageCount = splitter.GetPageCount(inputFile);
                // 2. Get all page numbers
                var pageNumbers = Enumerable.Range(1, pageCount);
                // 3. Split Range
                var splitRange = string.Join(",", pageNumbers);

                // Perform split by ranges
                string[] files = splitter.Split(inputFile, splitRange);

                Console.WriteLine(@"Splitted by parts: ");
                foreach (string file in files)
                    Console.WriteLine("    " + Path.GetFullPath(file));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();			
        }
    }
}
