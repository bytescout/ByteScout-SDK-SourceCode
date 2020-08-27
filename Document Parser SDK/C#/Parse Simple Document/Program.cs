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


using System;
using System.Text;
using ByteScout.DocumentParser;

// This example demonstrates document data parsing to JSON, YAML and XML formats.

namespace GeneralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var templates = new string[] { "DigitalOcean.yml", "AmazonAWS.yml", "Google.yml" } ;

            string inputDocument1 = @".\DigitalOcean.pdf";
            string inputDocument2 = @".\AmazonAWS.pdf";
            string inputDocument3 = @".\Google.pdf";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                Console.WriteLine($"Loading templates...");

                foreach (var template in templates)
                {
                    documentParser.AddTemplate(template);
                }

                Console.WriteLine($"Templates loaded.");
                Console.WriteLine();

                Console.WriteLine($"Parsing \"{inputDocument1}\"...");
                Console.WriteLine();

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(inputDocument1, OutputFormat.JSON);
                // Display parsed data in console
                Console.WriteLine("Parsing results in JSON format:");
                Console.WriteLine();
                Console.WriteLine(jsonString);

                Console.WriteLine();
                Console.WriteLine($"Parsing \"{inputDocument2}\"...");
                Console.WriteLine();

                // Parse document data in YAML format
                string yamlString = documentParser.ParseDocument(inputDocument2, OutputFormat.YAML);
                // Display parsed data in console
                Console.WriteLine("Parsing results in YAML format:");
                Console.WriteLine();
                Console.WriteLine(yamlString);
                
                Console.WriteLine();
                Console.WriteLine($"Parsing \"{inputDocument3}\"...");
                Console.WriteLine();

                // Parse document data in CSV format
                string xmlString = documentParser.ParseDocument(inputDocument3, OutputFormat.CSV, new CSVOptions
                {
                    GenerateColumnHeaders = true,
                    SeparatorCharacter = ",",
                    QuotationCharacter = "\"",
                    Encoding = Encoding.UTF8
                });

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
