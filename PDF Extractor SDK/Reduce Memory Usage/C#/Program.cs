//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace ReduceMemoryUsage
{
	class Program
	{
		static void Main(string[] args)
		{
            // When processing huge PDF documents you may run into OutOfMemoryException.
            // This example demonstrates a way to spare the memory by disabling page data caching.

			// Create Bytescout.PDFExtractor.TextExtractor instance
			using (TextExtractor extractor = new TextExtractor("demo", "demo"))
			{
			    try
			    {
			        // Load sample PDF document
			        extractor.LoadDocumentFromFile("sample2.pdf");

					// Disable page data caching, so processed pages wiil be disposed automatically
					extractor.PageDataCaching = PageDataCaching.None;

					// Save extracted text to file
					extractor.SaveTextToFile("output.txt");
                }
                catch (PDFExtractorException exception)
                {
                    Console.Write(exception.ToString());
                }
			}

			// Open the output file in default associated application
            System.Diagnostics.Process.Start("output.txt");
		}
	}
}
