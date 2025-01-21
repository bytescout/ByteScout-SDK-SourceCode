//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDFExtractor;
using System.Diagnostics;

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

			// Cleanup
			extractor.Dispose();

			// Open first output file in default associated application
			ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\page1.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
		}
	}
}
