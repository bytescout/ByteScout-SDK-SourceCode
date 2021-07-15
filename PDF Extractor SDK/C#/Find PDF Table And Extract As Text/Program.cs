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


using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace FindTableAndExtractAsText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor textExtractor = new TextExtractor();
            textExtractor.RegistrationName = "demo";
            textExtractor.RegistrationKey = "demo";

            // Create Bytescout.PDFExtractor.TableDetector instance
            TableDetector tableDetector = new TableDetector();
            tableDetector.RegistrationKey = "demo";
            tableDetector.RegistrationName = "demo";

            // Set table detection mode to "bordered tables" - best for tables with closed solid borders.
            tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables;

            // We should define what kind of tables we should detect.
            // So we set min required number of columns to 3 ...
            tableDetector.DetectionMinNumberOfColumns = 3;
            // ... and we set min required number of rows to 3
            tableDetector.DetectionMinNumberOfRows = 3;

            // Load sample PDF document
            textExtractor.LoadDocumentFromFile(@".\sample3.pdf");
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
                        textExtractor.SetExtractionArea(tableDetector.FoundTableLocation);
                        // Export the table to TEXT file
                        textExtractor.SavePageTextToFile(i, "page-" + i + "-table-" + t + ".txt");
                        t++;
                    } 
                    while (tableDetector.FindNextTable()); // search next table
                }
            }

            // Cleanup
            textExtractor.Dispose();
            tableDetector.Dispose();

            // Open first output file in default associated application (for demo purposes)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("page-0-table-1.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
