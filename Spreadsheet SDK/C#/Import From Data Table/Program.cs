//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Data;
using System.Diagnostics;
using System.IO;

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
        	const string fileName = "CSharpImportFromDataTable.xls";

        	// Create a new spreadsheet
        	Spreadsheet spreadsheet = new Spreadsheet();

        	// Get the data from the datatable that we want to import
        	DataTable periodicTable = GetDataTable();

        	// Import data into spreadheet
        	spreadsheet.ImportFromDataTable(periodicTable);

        	// Insert row with column captions
        	Worksheet worksheet = spreadsheet.Worksheets[0];
        	worksheet.Rows.Insert(0);
			for (int colIndex = 0; colIndex < periodicTable.Columns.Count; colIndex++)
        	{
				worksheet.Cell(0, colIndex).Value = periodicTable.Columns[colIndex].Caption;
        	}

        	// Save the spreadsheet
        	if (File.Exists(fileName)) File.Delete(fileName);
        	spreadsheet.SaveAs(fileName);

        	// Close spreadsheet
        	spreadsheet.Close();

        	// Open the spreadsheet
        	Process.Start(fileName);
        }

    	/// <summary>
        /// Creates a data table of the periodic table of elements
        /// </summary>
        /// <returns>A data table of the periodic table of elements</returns>
        private static DataTable GetDataTable()
        {
            DataTable periodicTable = new DataTable("PeriodicTable");

            periodicTable.Columns.Add("Name", typeof(string));
            periodicTable.Columns.Add("Symbol", typeof(string));
            periodicTable.Columns.Add("AtomicNumber", typeof(int));

            DataRow dr = periodicTable.Rows.Add();
            dr[0] = "Hydrogen";
            dr[1] = "H";
            dr[2] = "1";

            dr = periodicTable.Rows.Add();
            dr[0] = "Helium";
            dr[1] = "He";
            dr[2] = "2";

            dr = periodicTable.Rows.Add();
            dr[0] = "Lithium";
            dr[1] = "Li";
            dr[2] = "3";

            dr = periodicTable.Rows.Add();
            dr[0] = "Beryllium";
            dr[1] = "Be";
            dr[2] = "4";

            dr = periodicTable.Rows.Add();
            dr[0] = "Boron";
            dr[1] = "B";
            dr[2] = "5";

            dr = periodicTable.Rows.Add();
            dr[0] = "Carbon";
            dr[1] = "C";
            dr[2] = "6";

            return periodicTable;
        }
    }
}
