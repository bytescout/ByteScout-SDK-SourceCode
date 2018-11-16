//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDF2HTML;

namespace ReduceMemoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // When processing huge PDF documents you may run into OutOfMemoryException.
            // This example demonstrates a way to spare the memory by disabling page data caching.

            // Create Bytescout.PDF2HTML.HTMLExtractor instance
            using (HTMLExtractor extractor = new HTMLExtractor("demo", "demo"))
            {
                try
                {
                    // Load sample PDF document
                    extractor.LoadDocumentFromFile("sample2.pdf");

                    // Disable page data caching, so processed pages will be disposed automatically
                    extractor.PageDataCaching = PageDataCaching.None;

                    // Save result to file
                    extractor.SaveHtmlToFile("output.html");
                }
                catch (PDF2HTMLException exception)
                {
                    Console.Write(exception.ToString());
                }
            }

            // Open the output file in default associated application
            System.Diagnostics.Process.Start("output.html");
        }
    }
}
