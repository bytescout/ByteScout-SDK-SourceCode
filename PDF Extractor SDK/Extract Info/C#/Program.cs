//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace ExtractInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.InfoExtractor instance
			InfoExtractor extractor = new InfoExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample1.pdf");

			Console.WriteLine("Author:       " + extractor.Author);
			Console.WriteLine("Creator:      " + extractor.Creator);
			Console.WriteLine("Producer:     " + extractor.Producer);
			Console.WriteLine("Subject:      " + extractor.Subject);
			Console.WriteLine("Title:        " + extractor.Title);
			Console.WriteLine("CreationDate: " + extractor.CreationDate);
			Console.WriteLine("Keywords:     " + extractor.Keywords);
			Console.WriteLine("Bookmarks:    " + extractor.Bookmarks);
			Console.WriteLine("Encrypted:    " + extractor.Encrypted);
			
			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
