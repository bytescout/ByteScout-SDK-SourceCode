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


using System;
using System.Diagnostics;
using Bytescout.Spreadsheet;
using ByteScout.DocumentParser;


namespace HL7ToSpreadsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Generate Parse PDF File With Template and Generate Json
            string inputPDF = "Sample_Files/Test_Report_Format.pdf";
            string template = "Sample_Files/TestReportFormat.yml";

            // Create Document Parser Instance
            DocumentParser docParser = new DocumentParser("demo", "demo");

            // Add Template
            docParser.AddTemplate(template);

            // Parse document data in JSON format
            string jsonString = docParser.ParseDocument(inputPDF, ByteScout.DocumentParser.OutputFormat.JSON);

            // Step 2: Parse Json fileds in class format
            var oInpModel = JsonParserHelper.ParseJsonHL7Fields(jsonString);

            // Step 3: Get Data in HL7 Format
            var oHL7Format = Hl7Helper.GetHL7Format(oInpModel);

            // Step 4: write HL7 to Spreadsheet
            var oResultFile = "output.xlsx";
            WriteToSpreadsheet(oHL7Format, oResultFile);

            // Open generated file with default application program 
            Process.Start(oResultFile);
        }

        /// <summary>
        /// Write HL7 to spreadsheet
        /// </summary>
        static void WriteToSpreadsheet(string strInputHl7, string oResultFile)
        {
            using (var document = new Spreadsheet())
            {
                // Add new worksheet
                Worksheet worksheet = document.Workbook.Worksheets.Add("HL7");

                var ws_row = 0;

                // Split HL7 by new lines
                string[] stringSeparators = new string[] { "\r\n", "\r" };
                var inputData = strInputHl7.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var itmData in inputData)
                {
                    // Start adding data
                    worksheet.Cell((ws_row++), 0).Value = itmData;
                }

                // Save document
                document.SaveAs(oResultFile, Bytescout.Spreadsheet.Constants.SpreadsheetFormatType.XLSX);
            }
        }

    }
}
