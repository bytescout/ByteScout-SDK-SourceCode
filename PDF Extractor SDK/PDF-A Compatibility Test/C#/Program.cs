//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace PDFATest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.PDFAValidator instance
			PDFAValidator validator = new PDFAValidator();
			validator.RegistrationName ="demo";
			validator.RegistrationKey = "demo";

			// Load sample PDF document
			validator.LoadDocumentFromFile("good0016.pdf");
			
			if (validator.IsPDFA)
				Console.WriteLine("This file conforms to the PDF/A standard");
			else
				Console.WriteLine("This file doesn't conform to the PDF/A standard. Check .ValidationErros for the list of errors");

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
