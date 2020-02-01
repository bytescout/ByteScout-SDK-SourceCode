//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.Drawing;
using Bytescout.Spreadsheet;

namespace AddBackgroundImage
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create new spreadsheet (or open existing)
			Spreadsheet doc = new Spreadsheet();
			doc.RegistrationName = "demo";
            doc.RegistrationKey = "demo";

			// Add worksheet
			Worksheet worksheet = doc.Worksheets.Add();

			// Put background image on the worksheet
			worksheet.BackgroundPicture = Image.FromFile("image1.jpg");
            
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
