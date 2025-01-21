//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new XLS document
            Spreadsheet document = new Spreadsheet();

            // Create new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add();

            // Set column width
            worksheet.Columns[1].Width = 300;
            // Set column height
            worksheet.Rows[1].Height = 100;

            // delete output file if exists already
            if (File.Exists("Output.xls")){
                File.Delete("Output.xls");
            }


            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // open in default spreadsheets viewer/editor
            Process.Start("Output.xls");

        }
    }
}
