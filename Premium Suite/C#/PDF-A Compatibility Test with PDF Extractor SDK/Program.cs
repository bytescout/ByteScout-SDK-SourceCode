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
            validator.LoadDocumentFromFile("sample1.pdf");

		    if (validator.IsPDFA)
		        Console.WriteLine("This file conforms to the PDF/A standard");
		    else
		    {
		        Console.WriteLine("This file doesn't conform to the PDF/A standard.");
		        Console.WriteLine("Issues:");

		        foreach (string validationError in validator.ValidationErrors)
		            Console.WriteLine(validationError);
		    }

			// Cleanup
			validator.Dispose();

			Console.WriteLine();
			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
