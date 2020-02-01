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
using System.Diagnostics;

namespace RemoveSNNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\samplePDF_SSNNo.pdf";
            string outputDocument = @".\samplePDF_SSNNo_edited.pdf";

            try
            {
                // Create Bytescout.PDFExtractor.TextExtractor instance
                using (TextExtractor extractor = new TextExtractor("demo", "demo"))
                {
                    // Create Bytescout.PDFExtractor.Remover2 instance
                    using (Remover2 remover = new Remover2("demo", "demo"))
                    {
                        // Load sample PDF document
                        extractor.LoadDocumentFromFile("samplePDF_SSNNo.pdf");
                        remover.LoadDocumentFromFile(inputDocument);

                        extractor.RegexSearch = true; // Enable the regular expressions

                        int pageCount = extractor.GetPageCount();

                        // Search through pages
                        for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
                        {
                            // Search SSN in format 202-55-0130 using regular expression.
                            // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                            string regexPattern = "[0-9]{3}-[0-9]{2}-[0-9]{4}";

                            // Search each page for the pattern
                            ISearchResult[] searchResults = extractor.FindAll(pageIndex, regexPattern, caseSensitive: false);
                            
                            foreach (var element in searchResults)
                            {
                                Console.WriteLine("Found SSN No: " + element.Text);
                                // Add rectangle of the found SSN to Remover
                                remover.AddTextToRemove(pageIndex, element.Bounds);
                            }
                        }

                        // Mask replaced text with black rectangle
                        remover.MaskRemovedText = true;
                        // Change the color of the mask rectangle, if necessary
                        //remover.MaskColor = Color.Red;

                        remover.PerformRemoval(outputDocument);

                        Console.WriteLine("Found SSNs removed, result saved to file \"" + outputDocument + "\"");
                    }
                }

                // Open result file in default associated application (for the demonstration purpose)
                var processStartInfo = new ProcessStartInfo(outputDocument) { UseShellExecute = true };
                Process.Start(processStartInfo);
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
