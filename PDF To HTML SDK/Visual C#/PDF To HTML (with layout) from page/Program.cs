//*******************************************************************
//       ByteScout PDF To HTML SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDF2HTML;

namespace ExtractHTMLFromPage
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

			// Convert 2-nd page to HTML and save it to file
			extractor.SaveHtmlPageToFile(1, "output.html");

			// Open output file in default associated application
			System.Diagnostics.Process.Start("output.html");
		}
	}
}
