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

namespace GetCellColor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing XLS document
            Spreadsheet spreadSheet = new Spreadsheet();
	spreadSheet.LoadFromFile("input.xls");

            // Take existing worksheet
            Worksheet sheet = spreadSheet.Worksheet(0);

            // Take cell
            Cell cell = sheet.Cell(0,0);

            // Print back color of fill patter
            Console.WriteLine(cell.FillPatternBackColor.ToString());

            // Print fore color of fill pattern
            Console.WriteLine(cell.FillPatternForeColor.ToString());

            // Close spreadsheet
            spreadSheet.Close();
        }
    }
}
