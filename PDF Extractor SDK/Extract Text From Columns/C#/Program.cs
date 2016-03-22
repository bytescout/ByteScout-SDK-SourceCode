//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace ExtractAllText
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
			extractor.LoadDocumentFromFile("columns.pdf");

			// set to extract text column by column
			extractor.ExtractColumnByColumn = true;

			// Save extracted text to file
			extractor.SaveTextToFile("output.txt");

			// Open output file in default associated application
			System.Diagnostics.Process.Start("output.txt");
		}
	}
}
