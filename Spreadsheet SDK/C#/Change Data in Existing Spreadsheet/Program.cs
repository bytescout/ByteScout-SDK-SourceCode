//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace Changing_data_in_existing_XLS
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

            // Set cell value
            worksheet.Cell(1, 1).Value = "Homer Jay Simpson 2";

            // delete output file if exists already
            if (File.Exists("AdvancedReport_Modified.xls")){
                File.Delete("AdvancedReport_Modified.xls");
            }


            // Save document
            document.SaveAs("AdvancedReport_Modified.xls");

            // Close Spreadsheet
            document.Close();

            // open output document in default viewer
            Process.Start("AdvancedReport_Modified.xls");
        }
    }
}
