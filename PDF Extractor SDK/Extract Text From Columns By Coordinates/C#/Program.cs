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


			// read width of the very first page (zero index)
			float pageWidth = extractor.GetPageRect_Width(0);
			float pageHeight = extractor.GetPageRect_Height(0);

			// now we are extracting content assuming we have 3 columns 
			// equally distributed on pages

			// first calculate the width of the one column by dividing page width by number of columns (3)
			float columnWidth = pageWidth / 3f;

			// iterate through 3 columns
			for (int i=0; i<3; i++)
			{

				// set the extraction area to the #i column 
				extractor.SetExtractionArea(i * columnWidth, 0, columnWidth , pageHeight);

				string outFileName = "columns-column" + i + ".txt";
				extractor.SavePageTextToFile (0, outFileName);

				// Open output file in default associated application
				System.Diagnostics.Process.Start(outFileName);

			}

		}
	}
}
