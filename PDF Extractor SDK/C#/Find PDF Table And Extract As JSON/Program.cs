//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace FindTableAndExtractAsJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.JSONExtractor instance
            JSONExtractor jsonExtractor = new JSONExtractor();
            jsonExtractor.RegistrationName = "demo";
            jsonExtractor.RegistrationKey = "demo";

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
            jsonExtractor.LoadDocumentFromFile(@".\sample3.pdf");
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
                        jsonExtractor.SetExtractionArea(tableDetector.FoundTableLocation);
                        // Export the table to JSON file
                        jsonExtractor.SaveJSONToFile(i, "page-" + i + "-table-" + t + ".json");
                        t++;
                    } 
                    while (tableDetector.FindNextTable()); // search next table
                }
            }

            // Cleanup
            jsonExtractor.Dispose();
            tableDetector.Dispose();

            // Open first output file in default associated application (for demo purposes)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("page-0-table-1.json");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
