//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;

namespace FindZipCodeWithRegexp
{

    // Note: if you are looking for a more higher level API to extract data from invoices, reports, statements
    // then please check Document Parser SDK and Web API at https://bytescout.com/products/developer/documentparsersdk/index.html
    // and https://pdf.co for secure and scalable web api

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create Bytescout.PDFExtractor.TextExtractor instance
                using (TextExtractor extractor = new TextExtractor())
                {
                    extractor.RegistrationName = "demo";
                    extractor.RegistrationKey = "demo";

                    // Load sample PDF document
                    extractor.LoadDocumentFromFile("SampleInvoice.pdf");

                    extractor.RegexSearch = true; // Enable the regular expressions

                    int pageCount = extractor.GetPageCount();

                    // Search through pages
                    for (int i = 0; i < pageCount; i++)
                    {
                        // Search five digit zip code
                        string regexPattern = @"\d{5}";
                        // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx

                        // Search each page for the pattern
                        if (extractor.Find(i, regexPattern, false))
                        {
                            do
                            {
                                // Iterate through each element in the found text
                                foreach (ISearchResultElement element in extractor.FoundText.Elements)
                                {
                                    Console.WriteLine("Found Zip Code Number: " + element.Text);
                                }
                            }
                            while (extractor.FindNext());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
