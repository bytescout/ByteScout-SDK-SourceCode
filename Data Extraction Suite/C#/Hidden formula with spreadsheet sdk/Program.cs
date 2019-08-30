//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace HiddenFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open spreadsheet from file
            Spreadsheet document = new Spreadsheet();
           document.LoadFromFile("example.xls");

            // Get first worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            // Hide formula in B9 cell
            worksheet.Cell("B9").HiddenFormula = true;
            // Protect the worksheet with password
            worksheet.Protect("password");
            
            // Delete output file if exists
            if (File.Exists("changed.xls"))
            {
                File.Delete("changed.xls");
            }

            // Save document
            document.SaveAs("changed.xls");

            // Close spreadsheet
            document.Close();

            // Open generated XLS document in default program
            Process.Start("changed.xls");
        }
    }
}
