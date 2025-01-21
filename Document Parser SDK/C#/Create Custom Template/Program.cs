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

// This example demonstrates data parsing from an invoice using the custom template.

namespace CustomTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            string customTemplate = @".\SampleTemplate.yml";
            string inputDocument = @".\SampleInvoice.pdf";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template \"{customTemplate}\"...");
                Console.WriteLine();

                documentParser.AddTemplate(customTemplate);
                
                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse invoice data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument, OutputFormat.JSON);
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
