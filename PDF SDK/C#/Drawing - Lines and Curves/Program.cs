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

namespace LinesAndCurves
{
	/// <summary>
	/// This example demonstrates how to draw lines and curves.
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

			SolidPen solidPen = new SolidPen();
			SolidPen dashedPen = new SolidPen();
			dashedPen.DashPattern = new DashPattern(new float[] { 2, 2 });

			// Draw dashed lines
			canvas.DrawLine(dashedPen, 100, 100, 200, 100);
			canvas.DrawLine(dashedPen, 200, 100, 200, 200);
			canvas.DrawLine(dashedPen, 200, 200, 100, 200);
			// Draw besier curve by the same points
			canvas.DrawCurve(solidPen, 100, 100, 200, 100, 200, 200, 100, 200);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
