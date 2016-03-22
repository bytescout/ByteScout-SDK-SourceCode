//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.PDFExtractor;

// To make OCR work you should add to your project references to Bytescout.PDFExtractor.dll and Bytescout.PDFExtractor.OCRExtension.dll 

namespace OCRExample
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
			extractor.LoadDocumentFromFile("sample_ocr.pdf");

			// Enable Optical Character Recognition (OCR)
			// in .Auto mode (SDK automatically checks if needs to use OCR or not)
			extractor.OCRMode = OCRMode.Auto;

			// Set the location of "tessdata" folder containing language data files
			extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\";

			// Set OCR language
			extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
			
			// Set PDF document rendering resolution
			extractor.OCRResolution = 300;

			// Save extracted text to file
			extractor.SaveTextToFile("output.txt");

			// Open output file in default associated application
			System.Diagnostics.Process.Start("output.txt");
		}
	}
}
