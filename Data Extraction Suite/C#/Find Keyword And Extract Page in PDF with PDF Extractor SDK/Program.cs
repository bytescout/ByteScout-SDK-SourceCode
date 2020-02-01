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


// This example page extraction by found keyword.

using System;
using Bytescout.PDFExtractor;

namespace SplittingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputFile = @".\sample2.pdf";

         	// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
            extractor.LoadDocumentFromFile(inputFile);
			
			int pageCount = extractor.GetPageCount();
			
			// Search each page for a keyword 
			for (int i = 0; i < pageCount; i++)
			{
                if (extractor.Find(i, "bombardment", false))
				{
                    // Extract page
                    using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
                    {
                        splitter.OptimizeSplittedDocuments = true;

                        int pageNumber = i + 1;  // (!) page number in ExtractPage() is 1-based
                        string outputFile = @".\page" + pageNumber + ".pdf";
                        splitter.ExtractPage(inputFile, outputFile, pageNumber);

                        Console.WriteLine("Extracted page " + pageNumber + " to file \"" + outputFile +"\"");
                    }
				}
			}

			// Cleanup
			extractor.Dispose();
			
			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();			
		}
	}
}
