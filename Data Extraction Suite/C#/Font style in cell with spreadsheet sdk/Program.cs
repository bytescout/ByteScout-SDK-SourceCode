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


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sheet1");

            // Apply rich text formatting
            worksheet.Cell(0, 0).Value = "Arial Italic Bold, Size=23";
            worksheet.Cell(0, 0).Font = new Font("Arial", 23, FontStyle.Bold | FontStyle.Italic);

            // delete output file if exists already
            if (File.Exists("FontStyleForCell.xls")){
                File.Delete("FontStyleForCell.xls");
            }

            // Save document
            document.SaveAs("FontStyleForCell.xls");

            // open generated document
            Process.Start("FontStyleForCell.xls");

        }
    }
}
