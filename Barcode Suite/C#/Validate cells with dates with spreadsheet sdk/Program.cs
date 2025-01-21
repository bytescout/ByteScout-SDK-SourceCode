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


// in this sample we scan cells with ages data for people
// then mark all dates where age is between 10 and 19 years and mark these cells with red color


            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("Data.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Sample");

            // Years range
            int RangeMin = 10;
            int RangeMax = 19;

            // Minimum age
            DateTime YearMin = DateTime.Now;
            // Maximum age
            DateTime YearMax = DateTime.Now;

            // Minimum year
            YearMax = YearMax.AddYears(-RangeMin);
            // Maximum year
            YearMin = YearMin.AddYears(-RangeMax);

            // Check dates
            for (int i = 1; i < 8; i++)
            {
                // Set current cell
                Cell currentCell = worksheet.Cell(i, 1);

                DateTime dateBirth = currentCell.ValueAsDateTime;

                // Check current cell
                if (dateBirth < YearMin || dateBirth > YearMax)
                {
                    // Set fill pattern
                    currentCell.FillPattern = Bytescout.Spreadsheet.Constants.PatternStyle.Solid;

                    // Markup wrong cell by red color
                    currentCell.FillPatternForeColor = System.Drawing.Color.Red;
                }

                // Set cell format
                currentCell.NumberFormatString = "dd.mm.yyyy";
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
