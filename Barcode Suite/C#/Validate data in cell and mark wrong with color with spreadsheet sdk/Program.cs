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

            // Spellcheck words
            for (int i = 0; i < 5; i++)
            {
                // Set current cell
                Cell currentCell = worksheet.Cell(0, i);

                // Spellcheck current cell
                if ((string)currentCell.Value == "Simpsan")
                {
                    // Set fill pattern
                    currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid;

                    // Markup wrong word by red color
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
