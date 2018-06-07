//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;


namespace Adding_columns_into_existing_XLS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("AdvancedReport.xls");
            
            // Get Worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];

            // Add new Column
            worksheet.Columns.Insert(3, 1);
            // Set values
            worksheet.Rows[0][2].Value = "Age";

            // delete output file if exists already
            if (File.Exists("Output.xls")){
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
