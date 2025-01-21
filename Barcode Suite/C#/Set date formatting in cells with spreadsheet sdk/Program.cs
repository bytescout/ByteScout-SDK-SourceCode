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
using System.Diagnostics;
using Bytescout.Spreadsheet;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.Add("Sample");

            // Set captions
            worksheet.Cell(0, 0).Value = "#";
            worksheet.Cell(0, 1).Value = "Date";

            for (int i = 1; i < 8; i++)
            {
                // Set number
                worksheet.Cell(i, 0).Value = i;

                // Set current cell
                Cell currentCell = worksheet.Cell(i, 1);

                // Set date
                currentCell.ValueAsDateTime = DateTime.Now;

                // Set date format
                currentCell.NumberFormatString = "dd.mm.yyyy";
            }

            // delete output file if exists already
            if (File.Exists("Sample.xls")){
                File.Delete("Sample.xls");
            }

            // Save document
            document.SaveAs("Sample.xls");

            // Close document
            document.Close();

            // open generated XLS document in default program
            Process.Start("Sample.xls");
        }
    }
}
