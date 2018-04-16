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

namespace TilingPatterns
{
	/// <summary>
	/// This example demonstrates how to use tiling patterns.
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

			ColorRGB blueColor = new ColorRGB(0, 0, 255);
			ColorRGB grayColor = new ColorRGB(128, 128, 128);

			// Create tiling brush and paint on it 
			UncoloredTilingBrush tilingBrush1 = new UncoloredTilingBrush(10, 12);
			Canvas brushCanvas = tilingBrush1.Canvas;
			brushCanvas.DrawCircle(new SolidPen(blueColor), 0, 6, 6);
			tilingBrush1.Color = blueColor;

			// Create second tiling brush and paint on it using the first brush
			ColoredTilingBrush tilingBrush2 = new ColoredTilingBrush(70, 50);
			brushCanvas = tilingBrush2.Canvas;
			brushCanvas.DrawEllipse(new SolidPen(grayColor), tilingBrush1, 0, 0, 60, 20);

			// Draw rectangle and fill it with combined tiling brush
			page.Canvas.DrawRectangle(new SolidPen(), tilingBrush2, 100, 100, 400, 400);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
