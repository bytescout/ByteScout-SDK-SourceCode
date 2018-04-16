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

namespace IntercharacterSpacing
{
	/// <summary>
	/// This example demonstrates how to change the intercharacter spacing.
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

			Font font = new Font("Arial", 16);
			Brush brush = new SolidBrush();
			StringFormat stringFormat = new StringFormat();

			// Standard spacing
			stringFormat.CharacterSpacing = 0.0f;
			canvas.DrawString("Standard intercharacter spacing 0.0", font, brush, 20, 20, stringFormat);

			// Increased spacing 
			stringFormat.CharacterSpacing = 1.0f;
			canvas.DrawString("Increased intercharacter spacing 1.0", font, brush, 20, 50, stringFormat);

			// Reduced spacing
			stringFormat.CharacterSpacing = -0.75f;
			canvas.DrawString("Reduced intercharacter spacing -0.75", font, brush, 20, 80, stringFormat);

			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
