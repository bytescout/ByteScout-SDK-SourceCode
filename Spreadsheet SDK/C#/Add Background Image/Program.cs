//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using System.Drawing;
using System.IO;
using Bytescout.Spreadsheet;

namespace AddBackgroundImage
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create new spreadsheet (or open existing)
			Spreadsheet doc = new Spreadsheet();
			// Add worksheet
			Worksheet worksheet = doc.Worksheets.Add();

			// Put background image on the worksheet
			worksheet.BackgroundPicture = Image.FromFile("image1.jpg");


			// Delete output file if exists
			if (File.Exists("output.xls"))
			{
				File.Delete("output.xls");
			}

			// Save document
			doc.SaveAs("output.xls");

			// Close spreadsheet
			doc.Close();

			// Open generated XLS document in default application
			Process.Start("output.xls");

			doc.Dispose();
		}
	}
}
