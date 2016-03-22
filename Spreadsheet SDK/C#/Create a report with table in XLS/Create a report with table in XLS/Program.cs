//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Bytescout.Spreadsheet;
using System.IO;
using System.Diagnostics;

namespace Create_a_report_with_table_in_XLS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("SimpleReport");

            // Set Values
            worksheet.Cell(0, 0).Value = "Name";
            worksheet.Cell(0, 1).Value = "Full Name";

            // Set font bold for headers
            worksheet.Cell(0, 0).Font = new Font("Arial", 12, FontStyle.Bold);
            worksheet.Cell(0, 1).Font = new Font("Arial", 12, FontStyle.Bold);

            worksheet.Cell(1, 0).Value = "Homer";
            worksheet.Cell(1, 1).Value = "Homer Jay Simpson";

            worksheet.Cell(2, 0).Value = "Marjorie";
            worksheet.Cell(2, 1).Value = "Marjorie Marge Simpson (Bouvier)";

            worksheet.Cell(3, 0).Value = "Bartholomew";
            worksheet.Cell(3, 1).Value = "Bartholomew Jojo Bart Simpson";

            worksheet.Cell(4, 0).Value = "Lisa";
            worksheet.Cell(4, 1).Value = "Lisa Marie Simpson";

            worksheet.Cell(5, 0).Value = "Margaret";
            worksheet.Cell(5, 1).Value = "Margaret Maggie ";

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
