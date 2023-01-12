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


using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("Input.xls");

            Spreadsheet document2 = new Spreadsheet();
            document2.LoadFromFile("Input2.xls");

            var exportedDataTable = document.ExportToDataTable(0); // Worksheet to copy 

            var newWorkSheetName = "WorkSheet B";
            document2.Worksheets.Add(newWorkSheetName); // Create new worksheet
            document2.ImportFromDataTable(exportedDataTable, newWorkSheetName); // Import data into newly created worksheet

            // delete output file if exists already
            if (File.Exists("Output.xls"))
            {
                File.Delete("Output.xls");
            }

            // Save document
            document2.SaveAs("Output.xls");

            // Close document
            document2.Close();

            // Open document in default xls viewer
            Process.Start("Output.xls");
        }
    }
}
