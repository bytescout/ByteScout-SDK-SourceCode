//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


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

            extractor.Dispose();


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
