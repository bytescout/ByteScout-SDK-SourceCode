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

namespace ExportToHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("SimpleReport.xls");

            // Get Worksheet
            Worksheet worksheet = document.Workbook.Worksheets[0];


            // delete output file if exists already
            if (File.Exists("SimpleReport.htm")){
                File.Delete("SimpleReport.htm");
            }

            // Export to HTML
            worksheet.SaveAsHTML("SimpleReport.htm");

            // Close Spreadsheet
            document.Close();

            // open generated HTML
            Process.Start("SimpleReport.htm");
        }
    }
}
