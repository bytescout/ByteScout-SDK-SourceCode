//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace WriteXLS
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create new Spreadsheet
			Spreadsheet document = new Spreadsheet();

			// Add worksheets
			Worksheet worksheet1 = document.Workbook.Worksheets.Add("Demo worksheet 1");
			Worksheet worksheet2 = document.Workbook.Worksheets.Add("Demo worksheet 2");

			// Fill cell on the first worksheet
			worksheet1.Cell(0, 0).Value = "This is Demo worksheet 1";

			// Get worksheet by name and fill a cell there
			Worksheet worksheetByName = document.Workbook.Worksheets.ByName("Demo worksheet 2");
			worksheetByName.Cell(0, 0).Value = "This is Demo worksheet 2";

			// Get current directory
			String currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
			
			// Construct output file name
			String outputFile = currentDirectory + "\\Worksheets.xls";

			// delete output file if exists 
			if (File.Exists(outputFile))
			{
				File.Delete(outputFile);
			}

			// Save document
			document.SaveAs(outputFile);

			// open generated XLS document in default program
			Process.Start(outputFile, "");
		}
	}
}
