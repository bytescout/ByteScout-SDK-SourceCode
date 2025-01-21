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

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFromJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "CSharpImportFromJaggedArray.xls";
            
            // Create a new spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Get the data from the jagged array that we want to import
            string[][] periodicTable = GetJaggedArray();

            // Import data into spreadheet
            spreadsheet.ImportFromJaggedArray(periodicTable);

            // Save the spreadsheet
            if (File.Exists(fileName)) File.Delete(fileName);
            spreadsheet.SaveAs(fileName);

            // Close spreadsheet
            spreadsheet.Close();
            
            // Open the spreadsheet
            Process.Start(fileName);
        }

        /// <summary>
        /// Creates a jagged array of the period table of elements
        /// </summary>
        /// <returns>Jagged array of the periodic table of elements</returns>
        private static string[][] GetJaggedArray()
        {
              string[][] periodicTable = {
                           new string[] {"H","He"},
                           new string[] {"Li","Be","B","C", "N", "O", "F", "Ne"},
                           new string[] {"Na","Mg","Al","Si", "P", "S", "Cl", "Ar"},
                           new string[] {"K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr"}
                        };
            return periodicTable;
        }
    }
}
