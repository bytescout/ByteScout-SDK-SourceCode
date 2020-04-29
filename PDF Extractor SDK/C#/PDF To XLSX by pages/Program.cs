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


using Bytescout.PDFExtractor;
using System;

namespace PDF2XLS
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.XLSExtractor instance
            XLSExtractor extractor = new XLSExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("ProductsMonthWise.pdf");

            // Uncomment this line if you need all pages converted into a single worksheet:
            //extractor.PageToWorksheet = false;

            // Set the output format to XLSX
            extractor.OutputFormat = SpreadseetOutputFormat.XLSX;

            // No of Pages
            var pageCount = extractor.GetPageCount();

            for (int i = 0; i < pageCount; i++)
            {
                string outputName = $"page_{i + 1}.xlsx";

                // Save page to spreadsheet file
                extractor.SavePageToXLSFile(i, outputName);

                Console.WriteLine("'{0}' Created", outputName);
            }

            // Cleanup
            extractor.Dispose();

            Console.ReadLine();
        }
    }
}
