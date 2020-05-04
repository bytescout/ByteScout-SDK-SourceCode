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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;

namespace InvoicesToGoogleSheets
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = new string[] { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets Demo";

        static void Main(string[] args)
        {
            var allInputFiles = new string[] { "Sample_Files\\InvoiceMar.pdf", "Sample_Files\\InvoiceApr.pdf" };

            // Google Sheet data to write
            var reqRowData = new List<RowData>();

            // Set page index
            var pageIndex = 0;

            // Loop through all input files
            foreach (var itmFile in allInputFiles)
            {
                var invName = Path.GetFileNameWithoutExtension(itmFile);

                // Create TextExtractor instance
                using (var tableExtractor = new StructuredExtractor("demo", "demo"))
                {
                    var tableExtractionArea = GetTableExtractionArea(itmFile);
                    if (tableExtractionArea.HasValue)
                    {
                        // Load document from file
                        tableExtractor.LoadDocumentFromFile(itmFile);

                        // Set extraction area
                        tableExtractor.SetExtractionArea(tableExtractionArea.Value);

                        // Prepare table structure
                        tableExtractor.PrepareStructure(pageIndex);

                        int rowCount = tableExtractor.GetRowCount(pageIndex);

                        // Ignoring first title row
                        for (int row = 1; row < rowCount; row++)
                        {
                            // Google Sheet RowData Input
                            var itmRowData = new RowData();

                            // Google Sheet CellData Input
                            var lstCellData = new List<CellData>();

                            int columnCount = tableExtractor.GetColumnCount(pageIndex, row);

                            // Add invName to CellData Collection
                            lstCellData.Add(new CellData { UserEnteredValue = new ExtendedValue() { StringValue = invName } });

                            for (int col = 0; col < columnCount; col++)
                            {
                                // Get table cell value
                                var tableCellValue = tableExtractor.GetCellValue(pageIndex, row, col);

                                // Google Sheet CellData Input
                                var itmCellData = new CellData { UserEnteredValue = new ExtendedValue() { StringValue = tableCellValue } };

                                // Add to CellData Collection
                                lstCellData.Add(itmCellData);
                            }

                            // Add to Google Sheet RowData Request
                            reqRowData.Add(new RowData { Values = lstCellData });
                        }
                    }
                }
            }

            // Proceed with writing to Google Sheets
            UserCredential credential;

            // Follow article "https://developers.google.com/sheets/api/quickstart/dotnet" to generate credentials.json
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completed for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine($"Credential file saved to : {credPath}");
            }

            // Create Google Sheets API Service
            var service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            // Fill following parameter with your google spreadsheet Id
            // Usually find at url of spreadsheet: https://docs.google.com/spreadsheets/d/...ThisIsSpreadsheetId.../edit
            var spreadsheetId = "xxxxxxSpreadsheetIdxxxxxxxxxx";

            // Get exising row counts
            var existingRowCount = service.Spreadsheets.Values.Get(spreadsheetId, range: "A1:D").Execute().Values.Count;

            var lstRequsts = new List<Request>();
            lstRequsts.Add(new Request
            {
                // New data to be written
                UpdateCells = new UpdateCellsRequest()
                {
                    Range = new GridRange { StartRowIndex = existingRowCount, StartColumnIndex = 0 },
                    Rows = reqRowData,
                    Fields = "*"
                }
            });

            // Prepare batch update spreadsheet request
            var batchUpdateSpreadsheetRequest = new BatchUpdateSpreadsheetRequest()
            {
                Requests = lstRequsts
            };
            var batchUpdateRequest = service.Spreadsheets.BatchUpdate(batchUpdateSpreadsheetRequest, spreadsheetId);

            // Perform google sheet updation
            batchUpdateRequest.Execute();

            Console.WriteLine("Google spreadsheet updated!");
            Console.ReadLine();
        }

        /// <summary>
        /// Gets table extraction area
        /// </summary>
        private static RectangleF? GetTableExtractionArea(string inputFile, int pageIndex = 0)
        {
            // Create Bytescout.PDFExtractor.TableDetector instance
            using (var tableDetector = new TableDetector("demo", "demo"))
            {
                // Set table detection mode to "bordered tables" - best for tables with closed solid borders.
                tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables;

                // We should define what kind of tables we should detect.
                // So we set min required number of columns to 2 ...
                tableDetector.DetectionMinNumberOfColumns = 2;
                // ... and we set min required number of rows to 2
                tableDetector.DetectionMinNumberOfRows = 2;

                tableDetector.LoadDocumentFromFile(inputFile);

                if (!tableDetector.FindTable(pageIndex))
                {
                    return null;
                }

                // Getting first found table location
                return tableDetector.FoundTableLocation;
            }


        }

    }
}
