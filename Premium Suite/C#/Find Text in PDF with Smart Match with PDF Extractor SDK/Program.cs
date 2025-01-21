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

namespace FindTextSmartMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            TextExtractor extractor = new TextExtractor("demo", "demo");

            // Load the document
            extractor.LoadDocumentFromFile("sample2.pdf");

            // Smart match the search string like Adobe Reader
            extractor.WordMatchingMode = WordMatchingMode.SmartMatch;

            string searchString = "land";

            // Get page count
            int pageCount = extractor.GetPageCount();
            
            // Iterate through pages
            for (int i = 0; i < pageCount; i++)
            {
                // Search for text string
                if (extractor.Find(i, searchString, false))
                {
                    do
                    {
                        // Output search results
                        Console.WriteLine("Found on page " + i + " at location " + extractor.FoundText.Bounds.ToString());

                        // Now we are getting the found text
                        string extractedString = extractor.FoundText.Text;
                        Console.WriteLine("Found text: " + extractedString);
                    }
                    while (extractor.FindNext()); // Search next occurrence of the search string
                }
            }

            // Cleanup
			extractor.Dispose();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
