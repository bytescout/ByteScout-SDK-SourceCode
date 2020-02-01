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
