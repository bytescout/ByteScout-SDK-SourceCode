//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
