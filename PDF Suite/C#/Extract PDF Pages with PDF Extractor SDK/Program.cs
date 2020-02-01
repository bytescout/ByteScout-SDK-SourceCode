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


// This example demonstrates various PDF document splitting scenarios:
// - extract a single page;
// - split in two parts;
// - split by ranges specified in text form: "1-5,6,7-10,11-".

using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace SplittingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputFile = @".\sample.pdf";

            using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
            {
                splitter.OptimizeSplittedDocuments = true;

                // Extracting specific page:
                // =========================

                splitter.ExtractPage(inputFile, "page3.pdf", 3); // (!) Note: page number is 1-based.
                
                Console.WriteLine(@"Extracted page 3 to file ""page3.pdf""");
                Console.WriteLine();

                // Split in two parts:
                // ===================

                splitter.Split(inputFile, "part1.pdf", "part2.pdf", 3); // (!) Note: page number is 1-based.

                Console.WriteLine(@"Splitted at page 3 to files ""part1.pdf"" and ""part2.pdf""");
                Console.WriteLine();

                // Split by ranges:
                // ================

                string[] files = splitter.Split(inputFile, "1-3,4-6,7,8-"); // (!) Note: page numbers are 1-based; ending "-" means "to the end".
                
                Console.WriteLine(@"Splitted by ranges: ");
                foreach (string file in files)
                    Console.WriteLine("    " + Path.GetFileName(file));
            }

			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();			
		}
	}
}
