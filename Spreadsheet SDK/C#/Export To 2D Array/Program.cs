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

namespace Bytescout.Spreadsheet.Demo.Csharp.ExportTo2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFile = @"StockPricesSpreadsheet.xls";

            // Open and load spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(inputFile);

            // Get the data from the spreadsheet
            string[,] stockPrices = spreadsheet.ExportTo2DArray();

            // Close spreadsheet
            spreadsheet.Close();

            // Display data in data table
            for(int i = 0; i < stockPrices.GetLength(0); i++)
            {
                for(int j = 0; j < stockPrices.GetLength(1); j++)
                {
                    Console.Write(stockPrices[i,j] + " ");
                }
                Console.WriteLine();
            }

            // Pause
            Console.ReadLine();
        }
    }
}
