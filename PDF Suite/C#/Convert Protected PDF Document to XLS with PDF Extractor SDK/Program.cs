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


using System.IO;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace PDF2XLS
{
    //
    // This example demonstrates how to provide password for protected PDF files.
    //
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.XLSExtractor instance
            XLSExtractor extractor = new XLSExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            File.Delete("output.xls");

            // Document Password Can be set in two ways
            // 1. Using Property
            // 2. Using Events

            // 1. Handle document password using Property
            // extractor.Password = "password"

            // 2. Handle document password using Event
            extractor.PasswordRequired += new System.EventHandler(extractor_PasswordRequired);

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\encrypted (password is 'password').pdf");

            // Set the output format to XLS
            extractor.OutputFormat = SpreadseetOutputFormat.XLS;
            
            // Save the spreadsheet to file
            extractor.SaveToXLSFile("output.xls");

            // Cleanup
            extractor.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.xls");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        static void extractor_PasswordRequired(object sender, System.EventArgs e)
        {
            // Ask user for password and put it to `Password` property.
            ((XLSExtractor) sender).Password = "password";
        }
    }
}
