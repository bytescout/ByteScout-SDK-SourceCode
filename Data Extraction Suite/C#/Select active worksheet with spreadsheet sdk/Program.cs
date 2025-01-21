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
using Bytescout.Spreadsheet.Constants;
using System.Diagnostics;
using System.IO;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheets
            Worksheet worksheet1 = document.Workbook.Worksheets.Add("Worksheet1");
            Worksheet worksheet2 = document.Workbook.Worksheets.Add("Worksheet2");
            Worksheet worksheet3 = document.Workbook.Worksheets.Add("Worksheet3");

            // Activate worksheet2
            worksheet2.Active = true;

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
