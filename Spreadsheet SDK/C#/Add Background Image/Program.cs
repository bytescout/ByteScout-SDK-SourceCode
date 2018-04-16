//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


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
