//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF;

namespace RightToLeftText
{
	/// <summary>
	/// This example demonstrates how to draw right-to-left text.
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
			
			// Set right to left text direction
			StringFormat stringFormat = new StringFormat();
			stringFormat.DirectionRightToLeft = true;

			page.Canvas.DrawString("واحد اثنين ثلاثة", font, brush, page.Width - 20, 30, stringFormat);
			page.Canvas.DrawString("אחת, שתיים, שלוש", font, brush, page.Width - 20, 50, stringFormat);
			page.Canvas.DrawString("یک دو سه", font, brush, page.Width - 20, 70, stringFormat);

			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
