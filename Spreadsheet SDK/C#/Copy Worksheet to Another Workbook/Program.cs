//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.Spreadsheet;
using System.Diagnostics;
using System.IO;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open existing Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile("Input.xls");

            Spreadsheet document2 = new Spreadsheet();
            document2.LoadFromFile("Input2.xls");

            var exportedDataTable = document.ExportToDataTable(0); // Worksheet to copy 

            var newWorkSheetName = "WorkSheet B";
            document2.Worksheets.Add(newWorkSheetName); // Create new worksheet
            document2.ImportFromDataTable(exportedDataTable, newWorkSheetName); // Import data into newly created worksheet

            // delete output file if exists already
            if (File.Exists("Output.xls"))
            {
                File.Delete("Output.xls");
            }

            // Save document
            document2.SaveAs("Output.xls");

            // Close document
            document2.Close();

            // Open document in default xls viewer
            Process.Start("Output.xls");
        }
    }
}
