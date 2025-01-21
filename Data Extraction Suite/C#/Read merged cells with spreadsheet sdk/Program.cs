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

namespace ReadingMergedCells
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
document.LoadFromFile("Input.xls");

            // Get worksheet by name
            Worksheet worksheet = document.Workbook.Worksheets["Sheet1"];

            // Read merged cell
            Cell cell = worksheet.Cell("C12").MergedWithCell;

            // Read cell value
            Console.WriteLine(cell.Value);

            // Close document
            document.Close();
        }
    }
}
