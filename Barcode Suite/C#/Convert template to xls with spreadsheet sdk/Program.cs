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
using System.IO;
using Bytescout.Spreadsheet;

namespace TemplateToXls
{
	class Program
	{
		static void Main(string[] args)
		{
			// Open spreadsheet from file
			Spreadsheet document = new Spreadsheet();
			document.LoadFromFile("template.xls");

			// Get first worksheet
			Worksheet worksheet = document.Workbook.Worksheets[0];

			// Find macros and replace them with values
			Replace(worksheet, "<PRODUCT_NAME1>", "Product 1", null);
			Replace(worksheet, "<PRODUCT_NAME2>", "Product 2", null);
			Replace(worksheet, "<PRICE1>", 24.99f, "0.00");
			Replace(worksheet, "<PRICE2>", 29.99f, "0.00");
			Replace(worksheet, "<QANTITY1>", 5, null);
			Replace(worksheet, "<QANTITY2>", 10, null);


			// Delete output file if exists
			if (File.Exists("output.xls"))
			{
				File.Delete("output.xls");
			}

			// Save document
			document.SaveAs("output.xls");

			// Close spreadsheet
			document.Close();

			// Open generated XLS document in default application
			Process.Start("output.xls");
		}

		static void Replace(Worksheet worksheet, string macro, object value, string format)
		{
			Cell cell = worksheet.Find(macro, true, false, false);

			while (cell != null)
			{
				cell.Value = value;

				if (!String.IsNullOrEmpty(format))
				{
					cell.NumberFormatString = format;
				}

				cell = worksheet.FindNext();
			}
		}
	}
}
