//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.IO;
using System.Diagnostics;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Structures;

namespace InsertPageBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Add new worksheet
            Worksheet worksheet = document.Workbook.Worksheets.Add("HelloWorld");

            // Set cell value
            worksheet.Cell(0, 0).Value = "Hello, World!";
            
			// Add horizontal page break
			worksheet.HPageBreaks.Add(new CellsRange("A10"));

			// Add vertical page break
			worksheet.VPageBreaks.Add(new CellsRange("F1"));

            // Save document
            document.SaveAs("Output.xls");

            // Close Spreadsheet
            document.Close();

            // Open generated XLS document in default associated application
            Process.Start("Output.xls");
        }
    }
}
