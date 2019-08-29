//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
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
            extractor.LoadDocumentFromFile(@".\Invoice.pdf");

            extractor.RegexSearch = true; // Enable the regular expressions
            
            int pageCount = extractor.GetPageCount();

            // Search through pages
            for (int i = 0; i < pageCount; i++)
            {
                // Search dates in format 12/31/1999
                string regexPattern = "[0-9]{2}/[0-9]{2}/[0-9]{4}";
                // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx

                // Search each page for the pattern
                if (extractor.Find(i, regexPattern, false))
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Found on page " + i + " at location " + extractor.FoundText.Bounds);
                        Console.WriteLine("");

                        // Iterate through each element in the found text
                        foreach (ISearchResultElement element in extractor.FoundText.Elements)
                        {
                            Console.WriteLine("   Text: " + element.Text);
                            Console.WriteLine("   Font is bold: " + element.FontIsBold);
                            Console.WriteLine("   Font is italic: " + element.FontIsItalic);
                            Console.WriteLine("   Font name: " + element.FontName);
                            Console.WriteLine("   Font size: " + element.FontSize);
                            Console.WriteLine("   Font color: " + element.FontColor);
                            Console.WriteLine();
                        }
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
