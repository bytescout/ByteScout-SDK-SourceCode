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
	document.LoadFromFile("Data.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sample");

            // Minimum age
            int RangeMin = 10;
            // Maximum age
            int RangeMax = 19;

            // Spellcheck words
            for (int i = 1; i < 8; i++)
            {
                // Set current cell
                Cell currentCell = worksheet.Cell(i, 1);

                // Check current cell
                if (System.Convert.ToInt32(currentCell.Value) < RangeMin || System.Convert.ToInt32(currentCell.Value) > RangeMax)
                {
                    // Set fill pattern
                    currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid;

                    // Markup wrong cell by red color
                    currentCell.FillPatternForeColor = System.Drawing.Color.Red;
                }
            }

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
