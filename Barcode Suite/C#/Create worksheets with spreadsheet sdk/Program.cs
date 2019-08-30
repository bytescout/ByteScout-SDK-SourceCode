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
using System.Text;
using Bytescout.Spreadsheet;
using System.IO;
using System.Diagnostics;

namespace Worksheets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add worksheets
            Worksheet worksheet1 = document.Workbook.Worksheets.Add("Demo worksheet 1");

            Worksheet worksheet2 = document.Workbook.Worksheets.Add("Demo worksheet 2");

            // Get worksheet by name
            Worksheet worksheetByName = document.Workbook.Worksheets.ByName("Demo worksheet 2");

            // Set cell values
            worksheet1.Cell(0, 0).Value = "This is Demo worksheet 1";

            worksheetByName.Cell(0, 0).Value = "This is Demo worksheet 2";

            // delete output file if exists already
            if (File.Exists("Worksheets.xls")){
                File.Delete("Worksheets.xls");
            }

            // Save document
            document.SaveAs("Worksheets.xls");


            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            // open generated XLS document in default program
            Process.Start("Worksheets.xls");
        }
    }
}
