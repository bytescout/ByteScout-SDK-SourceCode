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

namespace SuperscripAndSubscript
{
	/// <summary>
	/// This example demonstrates how to draw subscript or superscript text adjusting the text baseline.
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


			Font font = new Font("Arial", 16);
			Brush brush = new SolidBrush();
			StringFormat stringFormat = new StringFormat();
			float xPosition = 20;

			// Draw normal string
			page.Canvas.DrawString("Normal text ", font, brush, xPosition, 50, stringFormat);
			xPosition += font.GetTextWidth("Normal text ");

			// Draw subscript string 
			stringFormat.Rise = -5;
			page.Canvas.DrawString("Subscript", font, brush, xPosition, 50, stringFormat);
			xPosition += font.GetTextWidth("Subscript");

			// draw superscript string
			stringFormat.Rise = +5;
			page.Canvas.DrawString("Superscript", font, brush, xPosition, 50, stringFormat);
			xPosition += font.GetTextWidth("Superscript");

			// Draw the baseline
			Pen pen = new SolidPen(new ColorRGB(0, 0, 255));
			pen.Opacity = 50;
			page.Canvas.DrawLine(pen, 20, 50 + font.Size, xPosition, 50 + font.Size);

			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
