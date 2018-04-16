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
            extractor.LoadDocumentFromFile(@".\sample1.pdf");
            
            // Set the matching mode.
            // WordMatchingMode.None - treats the search string as substring
            // WordMatchingMode.ExactMatch - treats the search string as separate word
            // WordMatchingMode.SmartMatch - will find the word in various forms (like Adobe Reader).
            extractor.WordMatchingMode = WordMatchingMode.ExactMatch;

            int pageCount = extractor.GetPageCount();

            for (int i = 0; i < pageCount; i++)
            {
                // Search each page for "ipsum" string
                if (extractor.Find(i, "ipsum", false))
                {
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Found on page " + i + " at location " + extractor.FoundText.Bounds.ToString());
                        Console.WriteLine("");
                        // Iterate through each element in the found text
                        foreach (SearchResultElement element in extractor.FoundText.Elements)
                        {
                            Console.WriteLine ("Element #" + element.Index + " at left=" + element.Left + "; top=" + element.Top + "; width=" + element.Width + "; height=" + element.Height);
                            Console.WriteLine ("Text: " + element.Text);
                            Console.WriteLine ("Font is bold: " + element.FontIsBold); 
                            Console.WriteLine ("Font is italic:" + element.FontIsItalic);
                            Console.WriteLine ( "Font name: " + element.FontName);
                            Console.WriteLine ( "Font size:" + element.FontSize);
                            Console.WriteLine ( "Font color:" + element.FontColor);
                        }
                    }
                    while (extractor.FindNext());
                }
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
