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
using Bytescout.PDF;

namespace Fonts
{
	/// <summary>
	/// This example demonstrates how to use fonts.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add page
			Page page = new Page(PaperFormat.A4);
			pdfDocument.Pages.Add(page);

			Canvas canvas = page.Canvas;

			Brush brush = new SolidBrush();

			// Use standard PDF font
			Font standardFont = new Font(StandardFonts.Times, 16);
			canvas.DrawString("Standard font.", standardFont, brush, 20, 20);

			// Use font installed in system
			Font systemFont = new Font("Arial", 16);
			canvas.DrawString("Windows font.", systemFont, brush, 20, 50);

			// Use font loaded from file
			Font fontFromFile = Font.FromFile("VeraBI.ttf", 16);
			canvas.DrawString("Font loaded from file.", fontFromFile, brush, 20, 80);

			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
