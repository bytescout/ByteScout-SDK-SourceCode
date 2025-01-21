//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFrom2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "CSharpImportFrom2DArray.xls";
            
            // Create a new spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Get the data from the 2D array that we want to import
            string[,] stockPrices = Get2DArray();

            // Import data into spreadheet
            spreadsheet.ImportFrom2DArray(stockPrices);

            // Save the spreadsheet
            if (File.Exists(fileName)) File.Delete(fileName);
            spreadsheet.SaveAs(fileName);

            // Close spreadsheet
            spreadsheet.Close();

            // Open the spreadsheet
            Process.Start(fileName);
        }

        /// <summary>
        /// Creates a 2D array of stock prices
        /// </summary>
        /// <returns>2d array of stock prices</returns>
        private static string[,] Get2DArray()
        {
            string[,] stockPrices = new string[10, 2];

            stockPrices[0, 0] = "AAPL"; stockPrices[0, 1] = "24,89";
            stockPrices[1, 0] = "AMZN"; stockPrices[1, 1] = "27,95";
            stockPrices[2, 0] = "DELL"; stockPrices[2, 1] = "12,68";
            stockPrices[3, 0] = "EBAY"; stockPrices[3, 1] = "57,27";
            stockPrices[4, 0] = "GOOG"; stockPrices[4, 1] = "28,98";

            stockPrices[5, 0] = "IBM "; stockPrices[5, 1] = "24,00";
            stockPrices[6, 0] = "INTC"; stockPrices[6, 1] = "12,24";
            stockPrices[7, 0] = "MSFT"; stockPrices[7, 1] = "37,85";
            stockPrices[8, 0] = "SNE "; stockPrices[8, 1] = "39,91";
            stockPrices[9, 0] = "YHOO"; stockPrices[9, 1] = "78,72";

            return stockPrices;
        }

    }
}
