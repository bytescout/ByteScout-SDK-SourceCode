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
using System.Data;

namespace Bytescout.Spreadsheet.Demo.Csharp.ExportToDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFile = @"PeriodicTableOfElementsSpreadsheet.xls";

            // Open and load spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(inputFile);

            // Get the data from the spreadsheet
            DataSet dataSet = spreadsheet.ExportToDataSet();

            // Close spreadsheet
            spreadsheet.Close();

            // Display data in the first data table in the dataset
            DataTable dt = dataSet.Tables[0];
            Console.WriteLine("Displaying contents of first datatable");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Pause
            Console.ReadLine();
        }
    }
}
