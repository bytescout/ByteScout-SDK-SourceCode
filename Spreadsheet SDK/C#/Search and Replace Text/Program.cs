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
using System.Diagnostics;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.BaseClasses;

namespace SearchAndReplaceText
{
	class Program
	{
		static void Main(string[] args)
		{
			// Open spreadsheet from file
			Spreadsheet document = new Spreadsheet();
			document.LoadFromFile("example.xls");

			string valueToFind = ",";
			string valueToReplaceWith = ";";
			string outputFileName = "output.xls";

			// Get first worksheet
			Worksheet worksheet = document.Workbook.Worksheets[0];

			// Find cells
            Cell cell = worksheet.Find(
				valueToFind, false /*case insesitive*/, false /*not regexp*/, false /*search forward*/);

			// Iterate through all cells and perform replace
			while (cell != null)
			{
				// Print found cell address and value to console
				CellAddress address = cell.GetAddress();

				Console.WriteLine("({0}, {1}) - {2}", address.Row, address.Column, cell.ValueAsString);

				// Perform replace 
				cell.Value = cell.ValueAsString.Replace(valueToFind, valueToReplaceWith);

				cell = worksheet.FindNext();
			}

			// Save output file
			document.SaveAs(outputFileName);
			Console.WriteLine("\nOutput File Saved at {0}\n", outputFileName);

			document.Dispose();

			// Open output file
			Process.Start(outputFileName);

			Console.WriteLine();
			Console.WriteLine("Press any key to continue ...");
			Console.ReadKey(true);
		}
	}
}
