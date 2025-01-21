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
			extractor.LoadDocumentFromFile(@".\sample1.pdf");

			Console.WriteLine("Author:       " + extractor.Author);
			Console.WriteLine("Creator:      " + extractor.Creator);
			Console.WriteLine("Producer:     " + extractor.Producer);
			Console.WriteLine("Subject:      " + extractor.Subject);
			Console.WriteLine("Title:        " + extractor.Title);
			Console.WriteLine("CreationDate: " + extractor.CreationDate);
			Console.WriteLine("Keywords:     " + extractor.Keywords);
			Console.WriteLine("Bookmarks:    " + extractor.Bookmarks);
			Console.WriteLine("Encrypted:    " + extractor.Encrypted);


			// Cleanup
			extractor.Dispose();

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
