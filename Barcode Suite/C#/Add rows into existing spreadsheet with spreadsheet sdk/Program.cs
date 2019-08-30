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
using System.Diagnostics;
using System.IO;

namespace Adding_rows_to_existing_XLS
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

            // Add new row
            worksheet.Rows.Insert(6, 1);
	    // Set values
            worksheet.Rows[6][0].Value = "New Name";
            worksheet.Rows[6][1].Value = "New Full Name";

            // delete output file if exists already
            if (File.Exists("AdvancedReport_Modified.xls")){
                File.Delete("AdvancedReport_Modified.xls");
            }


            // Save document
            document.SaveAs("AdvancedReport_Modified.xls");

            // Close Spreadsheet
            document.Close();

            // open in default spreadsheets viewer/editor
            Process.Start("AdvancedReport_Modified.xls");


        }
    }
}
