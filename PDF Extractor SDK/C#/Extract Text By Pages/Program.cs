//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


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
			extractor.LoadDocumentFromFile(@".\sample2.pdf");

			// Get page count
			int pageCount = extractor.GetPageCount();

			for (int i = 0; i < pageCount; i++)
			{
				string fileName = "page" + i + ".txt";
				
				// Save extracted page text to file
				extractor.SavePageTextToFile(i, fileName);
			}

			// Open first output file in default associated application
			System.Diagnostics.Process.Start(@".\page1.txt");
		}
	}
}
