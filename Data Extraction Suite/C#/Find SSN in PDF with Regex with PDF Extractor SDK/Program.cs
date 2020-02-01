//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;

namespace FindSSNNumberRegexp
{
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
                    extractor.LoadDocumentFromFile("samplePDF_SSNNo.pdf");

                    extractor.RegexSearch = true; // Enable the regular expressions

                    int pageCount = extractor.GetPageCount();

                    // Search through pages
                    for (int i = 0; i < pageCount; i++)
                    {
                        // Search SSN in format 202-55-0130
                        string regexPattern = "[0-9]{3}-[0-9]{2}-[0-9]{4}";
                        // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx

                        // Search each page for the pattern
                        if (extractor.Find(i, regexPattern, false))
                        {
                            do
                            {
                                // Iterate through each element in the found text
                                foreach (ISearchResultElement element in extractor.FoundText.Elements)
                                {
                                    Console.WriteLine("Found SSN No: " + element.Text);
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
