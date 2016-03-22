//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF;

namespace LoadDocument
{
	/// <summary>
	/// This example demonstrates how to load and modify an existing document.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new Document object
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			
			// Load existing document
			pdfDocument.Load("sample.pdf");
			
			// Add new page to loaded document
			Page page = new Page(PaperFormat.A4);
			Font font = new Font(StandardFonts.Times, 24);
			Brush brush = new SolidBrush();
			page.Canvas.DrawString("New Page", font, brush, 20, 20);
			pdfDocument.Pages.Add(page);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
