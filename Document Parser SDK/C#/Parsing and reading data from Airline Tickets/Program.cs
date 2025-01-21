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

// This example demonstrates document data parsing to JSON, YAML and XML formats.

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string templateDocument = @".\SampleTicket.yml";
            string inputDocument = @".\SampleTicket.pdf";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {

                // Add template format
                documentParser.AddTemplate(templateDocument);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument, OutputFormat.JSON);
                
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);

                Console.WriteLine("\n\n=========================\n\n");

                // Parse document data in YAML format
                string yamlString = documentParser.ParseDocument(inputDocument, OutputFormat.YAML);

                // Display parsed data in console
                Console.WriteLine("Parsing results in YAML format:");
                Console.WriteLine();
                Console.WriteLine(yamlString);

                Console.WriteLine("\n\n=========================\n\n");

                // Parse document data in XML format
                string xmlString = documentParser.ParseDocument(inputDocument, OutputFormat.XML);
                // Display parsed data in console
                Console.WriteLine("Parsing results in XML format:");
                Console.WriteLine();
                Console.WriteLine(xmlString);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
