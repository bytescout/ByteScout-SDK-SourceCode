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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace FindText
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
			extractor.LoadDocumentFromFile("words-with-hyphens.pdf");
			
			int pageCount = extractor.GetPageCount();

			for (int i = 0; i < pageCount; i++)
			{
				// Search each page for "hyphen" string
				if (extractor.Find(i, "hyphen", false))
				{
					do
					{
						Console.WriteLine("Found on page " + i + " at location " + extractor.FoundText.Bounds.ToString());
					}
					while (extractor.FindNext());
				}
			}

			// Cleanup
			extractor.Dispose();
			
			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
