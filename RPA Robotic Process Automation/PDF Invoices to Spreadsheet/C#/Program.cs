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
using Bytescout.Spreadsheet;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace InvoicesToSpreadsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            var allInputFiles = new string[] { "Sample_Files\\InvoiceMar.pdf", "Sample_Files\\InvoiceApr.pdf" };
            var resultFileName = "output.xlsx";

            // Set page index
            var pageIndex = 0;

            // Create output Spreadsheet
            using (var document = new Spreadsheet())
            {
                // Add new worksheet
                Worksheet worksheet = document.Workbook.Worksheets.Add("Invoices");

                var ws_row = 0;
                var ws_column = 0;

                // Set Header value
                worksheet.Cell(ws_row, ws_column).Font = new Font("Arial", 11, FontStyle.Bold);
                worksheet.Cell(ws_row, (ws_column++)).Value = "Invoice";

                worksheet.Cell(ws_row, ws_column).Font = new Font("Arial", 11, FontStyle.Bold);
                worksheet.Cell(ws_row, (ws_column++)).Value = "Product Name";

                worksheet.Cell(ws_row, ws_column).Font = new Font("Arial", 11, FontStyle.Bold);
                worksheet.Cell((ws_row++), (ws_column++)).Value = "Price";
                

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
                                int columnCount = tableExtractor.GetColumnCount(pageIndex, row);

                                // Write Invoice Data
                                ws_column = 0;
                                worksheet.Cell(ws_row, (ws_column++)).Value = invName;

                                for (int col = 0; col < columnCount; col++)
                                {
                                    // Get table cell value
                                    var tableCellValue = tableExtractor.GetCellValue(pageIndex, row, col);

                                    // Write to spreadsheet
                                    worksheet.Cell(ws_row, (ws_column++)).Value = tableCellValue;
                                }

                                // Set row pointer to next row
                                ws_row++;
                            }
                        }
                    }
                }

                // Save document
                document.SaveAs(resultFileName, Bytescout.Spreadsheet.Constants.SpreadsheetFormatType.XLSX);
            }


            // Open generated XLSX file in default program
            Process.Start(resultFileName);
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
