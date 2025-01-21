//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


//
// This example demonstrates how to provide password for protected PDF files.
//

using System;
using System.IO;
using Bytescout.PDFExtractor;

namespace SplittingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @".\encrypted (password is 'password').pdf";

            using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
            {
                // Handle `PasswordRequired` event
                splitter.PasswordRequired += new PasswordEventHandler(splitter_PasswordRequired);

                // Ignore document permissions
                splitter.CheckPermissions = false;

                // Split document
                splitter.Split(inputFile, "part1.pdf", @"part2.pdf", 3);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();			
        }

        static void splitter_PasswordRequired(object sender, string document, ref string password)
        {
            // Ask user for password and put it to `Password` property.
            password = "password";
        }
    }
}
