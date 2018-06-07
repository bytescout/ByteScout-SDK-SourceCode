//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;

namespace FindTableAndExtractAsCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor csvExtractor = new CSVExtractor();
            csvExtractor.RegistrationName = "demo";
            csvExtractor.RegistrationKey = "demo";

            // Create Bytescout.PDFExtractor.TableDetector instance
            TableDetector tableDetector = new TableDetector();
            tableDetector.RegistrationKey = "demo";
            tableDetector.RegistrationName = "demo";

            // We should define what kind of tables we should detect.
            // So we set min required number of columns to 3 ...
            tableDetector.DetectionMinNumberOfColumns = 3;
            // ... and we set min required number of rows to 3
            tableDetector.DetectionMinNumberOfRows = 3;

            // Load sample PDF document
            csvExtractor.LoadDocumentFromFile(@".\sample3.pdf");
            tableDetector.LoadDocumentFromFile(@".\sample3.pdf");

            // Get page count
            int pageCount = tableDetector.GetPageCount();

            for (int i = 0; i < pageCount; i++)
            {
                int t = 1;
                // Find first table and continue if found
                if (tableDetector.FindTable(i))
                {
                    do
                    {
                        // Set extraction area for CSV extractor to rectangle received from the table detector
                        csvExtractor.SetExtractionArea(tableDetector.FoundTableLocation);
                        // Export the table to CSV file
                        csvExtractor.SavePageCSVToFile(i, "page-" + i + "-table-" + t + ".csv");
                        t++;
                    } 
                    while (tableDetector.FindNextTable()); // search next table
                }
            }

            // Cleanup
			csvExtractor.Dispose();
            tableDetector.Dispose();

            // Open first output file in default associated application (for demo purposes)
            System.Diagnostics.Process.Start("page-0-table-1.csv");
        }
    }
}
