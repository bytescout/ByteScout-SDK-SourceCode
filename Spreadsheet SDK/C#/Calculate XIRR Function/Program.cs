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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

using Bytescout.Spreadsheet;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Set locale
            document.Workbook.Locale = new System.Globalization.CultureInfo("en-US");

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add();

            // Fill some data
            worksheet.Cell(1, 1).Value = new DateTime(2008, 01, 01);
            worksheet.Cell(1, 2).Value = 100;
            worksheet.Cell(2, 1).Value = new DateTime(2009, 01, 01);
            worksheet.Cell(2, 2).Value = -200;

            // Apply function
            worksheet.Cell(4, 1).Formula = "=XIRR(C2:C3,B2:B3,0)";
            // Read value
            worksheet.Cell(4, 2).Value = worksheet.Cell(4, 1).Value;

            // delete output file if exists already
            if (File.Exists("Output.xls"))
            {
                File.Delete("Output.xls");
            }

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open generated XLS document in default program
            Process.Start("Output.xls");
        }
    }
}
