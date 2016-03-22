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
			extractor.LoadDocumentFromFile("sample1.pdf");

			// Get page count
			int pageCount = extractor.GetPageCount();

            string outputText = "";

            for (int i = 0; i < pageCount; i++)
			{
                // create new file stream
			    FileStream fStream = new FileStream("page" + i.ToString() + ".txt", FileMode.Create);
                
                // save text from page #i to the file stream
                extractor.SavePageTextToStream(i, fStream);

                // close stream
                fStream.Close();
				
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start("page1.txt");
		}
	}
}
