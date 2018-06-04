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
using ByteScout.InvoiceParser;

// This example demonstrates invoice data parsing using the custom template.

namespace CustomTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            string customTemplate = @".\SampleTemplate.yml";
            string inputDocument = @".\SampleInvoice.pdf";

            // Create InvoiceParser instance
            using (InvoiceParser invoiceParser = new InvoiceParser("demo", "demo"))
            {
                Console.WriteLine($"Loading template \"{customTemplate}\"...");
                Console.WriteLine();

                invoiceParser.AddTemplateFromFile(customTemplate);
                
                Console.WriteLine($"Parsing \"{inputDocument}\"...");
                Console.WriteLine();

                // Parse invoice data in JSON format
                string jsonString = invoiceParser.ParseDocument(inputDocument, OutputFormat.JSON);
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
