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
using System.Collections.Generic;

namespace FindBorderlessTableAndExtractAsCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor csvExtractor = new CSVExtractor();
            csvExtractor.RegistrationName = "demo";
            csvExtractor.RegistrationKey = "demo";

            // Create Bytescout.PDFExtractor.TableDetector2 instance
            TableDetector2 tableDetector = new TableDetector2();
            tableDetector.RegistrationKey = "demo";
            tableDetector.RegistrationName = "demo";

            // Load sample PDF document
            csvExtractor.LoadDocumentFromFile(@".\sample_borderless.pdf");
            tableDetector.LoadDocumentFromFile(@".\sample_borderless.pdf");

            // Get page count
            int pageCount = tableDetector.GetPageCount();

            var extractedCsvFiles = new List<string>();

            for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
            {
                var foundTables = tableDetector.FindTables(pageIndex).ToArray();

                // Find first table and continue if found
                if (foundTables.Length > 0)
                {
                    for (int indexTable = 0; indexTable < foundTables.Length; indexTable++)
                    {
                        // Set extraction area for CSV extractor to rectangle received from the table detector
                        csvExtractor.SetExtractionArea(foundTables[indexTable].Bounds);

                        // Result CSV file name
                        var outputCsvName = $"page-{pageIndex + 1}-table-{indexTable + 1}.csv";

                        // Export the table to CSV file
                        csvExtractor.SavePageCSVToFile(pageIndex, outputCsvName);
                        extractedCsvFiles.Add(outputCsvName);
                    }
                }
            }

            // Cleanup
            csvExtractor.Dispose();
            tableDetector.Dispose();

            // Show Summary
            Console.Clear();
            if (extractedCsvFiles.Count > 0)
            {
                Console.WriteLine($"Total {extractedCsvFiles.Count} tables found!");
                Console.WriteLine("--------------------------");
                Console.WriteLine(string.Join("\n", extractedCsvFiles));
            }
            else
            {
                Console.WriteLine("No Table Found!");
            }

            Console.ReadLine();
        }
    }
}
