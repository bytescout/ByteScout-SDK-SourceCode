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
using ByteScout.InvoiceParser;

// This example demonstrates invoice data parsing to JSON and YAML formats.

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument1 = @".\DigitalOcean.pdf";
            string inputDocument2 = @".\AmazonAWS.pdf";

            // Create InvoiceParser instance
            using (InvoiceParser invoiceParser = new InvoiceParser("demo", "demo"))
            {
                Console.WriteLine($"Parsing \"{inputDocument1}\"...");
                Console.WriteLine();

                // Parse invoice data in JSON format
                string jsonString = invoiceParser.ParseDocument(inputDocument1, OutputFormat.JSON);
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);

                Console.WriteLine();
                Console.WriteLine($"Parsing \"{inputDocument2}\"...");
                Console.WriteLine();

                // Parse invoice data in YAML format
                string yamlString = invoiceParser.ParseDocument(inputDocument2, OutputFormat.YAML);
                // Display parsed data in console
                Console.WriteLine("Parsing results in YAML format:");
                Console.WriteLine();
                Console.WriteLine(yamlString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
