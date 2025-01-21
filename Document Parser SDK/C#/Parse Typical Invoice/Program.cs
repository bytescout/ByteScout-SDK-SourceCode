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

// This example demonstrates parsing of typical invoice.

namespace ParseTypicalInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\SampleInvoice.pdf";
            
            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add an internal generic template for typical invoices.
                // Note, if it does not parse all required fields, you should create
                // own template using Template Editor application.
                documentParser.AddTemplate("internal://invoice");
                
                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
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
