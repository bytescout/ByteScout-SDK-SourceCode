//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace FindText
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
			extractor.LoadDocumentFromFile("words-with-hyphens.pdf");
			
			int pageCount = extractor.GetPageCount();

			for (int i = 0; i < pageCount; i++)
			{
				// Search each page for "hyphen" string
				if (extractor.Find(i, "hyphen", false))
				{
					do
					{
						Console.WriteLine("Found on page " + i + " at location " + extractor.FoundText.Bounds.ToString());

					}
					while (extractor.FindNext());
				}
			}
			
			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
