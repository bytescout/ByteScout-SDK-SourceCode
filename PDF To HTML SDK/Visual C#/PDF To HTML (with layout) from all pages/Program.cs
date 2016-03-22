//*******************************************************************
//       ByteScout PDF To HTML SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDF2HTML;

namespace ExtractHTML
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDF2HTML.HTMLExtractor instance
			HTMLExtractor extractor = new HTMLExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Set HTML with CSS extraction mode
			extractor.ExtractionMode = HTMLExtractionMode.HTMLWithCSS;

			// Load sample PDF document
			extractor.LoadDocumentFromFile("sample2.pdf");

			// Save extracted HTML to file
			extractor.SaveHtmlToFile("output.html");

			// Open output file in default associated application
			System.Diagnostics.Process.Start("output.html");
		}
	}
}
