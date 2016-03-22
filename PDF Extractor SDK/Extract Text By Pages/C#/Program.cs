//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace ExtractTextByPages
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.TextExtractor instance
			TextExtractor extractor = new TextExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample2.pdf");

			// Get page count
			int pageCount = extractor.GetPageCount();

			for (int i = 0; i < pageCount; i++)
			{
				string fileName = "page" + i + ".txt";
				
				// Save extracted page text to file
				extractor.SavePageTextToFile(i, fileName);
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page1.txt");
		}
	}
}
