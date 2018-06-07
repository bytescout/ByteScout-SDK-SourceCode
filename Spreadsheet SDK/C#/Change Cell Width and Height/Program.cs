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

namespace Change_cell_width_and_height
{
    class Program
    {
        static void Main(string[] args)
        {
            Spreadsheet document = new Spreadsheet();

            Worksheet worksheet = document.Workbook.Worksheets.Add();

            worksheet.Rows[1].Height = 100;

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }

            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open in default spreadsheets viewer/editor
            Process.Start("Output.xls");
        }
    }
}
