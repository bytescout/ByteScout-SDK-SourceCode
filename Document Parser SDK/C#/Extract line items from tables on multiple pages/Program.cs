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
using ByteScout.DocumentParser;

// This example demonstrates extracting line items from tables on multiple pages with two different approaches.
// See comments in the code of templates.

namespace ExtractLineItemFromTableOnMultiplePages
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\MultiPageTable.pdf";
            string template1 = @".\MultiPageTable-template1.yml";
            string template2 = @".\MultiPageTable-template2.yml";

            // Process using template-1
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

            // Process using template-2
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
