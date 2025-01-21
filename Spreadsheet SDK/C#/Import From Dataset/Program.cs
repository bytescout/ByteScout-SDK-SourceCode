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

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "CSharpImportFromDataSet.xls";

            // Create a new spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Get the data from the dataset that we wish to import
            DataSet periodicTableAndScientists = GetDataSet();

            // Import data into spreadheet
            spreadsheet.ImportFromDataSet(periodicTableAndScientists);

			// Insert row with column captions
			for (int i = 0; i < periodicTableAndScientists.Tables.Count; i++)
			{
				DataTable dataTable = periodicTableAndScientists.Tables[i];
				Worksheet worksheet = spreadsheet.Worksheets[i];

				worksheet.Rows.Insert(0);

				for (int colIndex = 0; colIndex < dataTable.Columns.Count; colIndex++)
				{
					worksheet.Cell(0, colIndex).Value = dataTable.Columns[colIndex].Caption;
				}
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
        /// Creates a data set of the periodic table of elements and some famous scientists
        /// </summary>
        /// <returns>A data set of the periodic table of elements and some scientists</returns>
        private static DataSet GetDataSet()
        {
            DataTable periodicTable = GetDataTableOfElements();
            DataTable scientists = GetDataTableOfScientists();

            DataSet dataset = new DataSet();
            dataset.Tables.Add(periodicTable);
            dataset.Tables.Add(scientists);
            
            return dataset;
        }


        /// <summary>
        /// Creates a data table of the periodic table of elements
        /// </summary>
        /// <returns>A data table of the periodic table of elements</returns>
        private static DataTable GetDataTableOfElements()
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

        /// <summary>
        /// Creates a data table of scientists
        /// </summary>
        /// <returns>A data table of scientists</returns>
        private static DataTable GetDataTableOfScientists()
        {
            DataTable scientistsTable = new DataTable("Scientists");

            scientistsTable.Columns.Add("Name", typeof(string));

            DataRow dr = scientistsTable.Rows.Add();
            dr[0] = "Antoine Lavoisier";

            dr = scientistsTable.Rows.Add();
            dr[0] = "Julius Lothar Meyer ";

            dr = scientistsTable.Rows.Add();
            dr[0] = "Dmitri Ivanovich Mendeleev";

            return scientistsTable;
        }
    }
}
