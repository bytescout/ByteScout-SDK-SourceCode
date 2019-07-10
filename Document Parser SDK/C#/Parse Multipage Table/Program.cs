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
using ByteScout.DocumentParser;

// This example demonstrates parsing of multipage tables in two different approaches.
// See comments in the code of templates.

namespace ParseMultipageTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\MultiPageTable.pdf";
            string template1 = @".\MultiPageTable-template1.yml";
            string template2 = @".\MultiPageTable-template1.yml";

            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template 1...");
                documentParser.AddTemplate(template1);

                Console.WriteLine($"Template 1 loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                documentParser.ParseDocument(inputDocument, "result1.json", OutputFormat.JSON);

                Console.WriteLine("Parsing results saved to `result1.json`.");
                Console.WriteLine();
            }

            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template 2...");
                documentParser.AddTemplate(template2);

                Console.WriteLine($"Template 2 loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                documentParser.ParseDocument(inputDocument, "result2.json", OutputFormat.JSON);

                Console.WriteLine("Parsing results saved to `result2.json`.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
