//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Charts;

namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// create new Spreadsheet object
				Spreadsheet spreadsheet = new Spreadsheet();

				// add new worksheet
				Worksheet sheet = spreadsheet.Workbook.Worksheets.Add("Sample");

				// add a constants
				for (int i = 1; i < 8; i++)
				{
					sheet[i, 1].Value = i;
				}

				// add a formulas
				sheet.Range("D2:D8").Formula = "=RAND()*10";

				//Select the cells containing constants
				Range range1 = sheet.Range("A1:E9").SpecialCells(XlCellType.Constants, null);
				range1.FillPattern = PatternStyle.Solid;
				range1.FillPatternForeColor = Color.Yellow;

				//Select the cells containing formulas
				Range range2 = sheet.Range("A1:E9").SpecialCells(XlCellType.Formulas, null);
				range2.FillPattern = PatternStyle.Solid;
				range2.FillPatternForeColor = Color.Cyan;

				if (File.Exists("Output.xls"))
				{
					File.Delete("Output.xls");
				}

				// Save it as XLS
				spreadsheet.SaveAs("Output.xls");

				// close the document
				spreadsheet.Close();

				// open output XLS
				Process.Start("Output.xls");
			}
			catch (Exception e)
			{
				Console.WriteLine("CAN NOT EXECUTE: " + e.ToString());
				Console.WriteLine("\nPress any key to exit");
				Console.ReadKey();
			}
		}
	}
}
