//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF;

namespace ColorProfiles
{
	/// <summary>
	/// This example demonstrates how to use color profiles.
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

			// Load ICC color profile
			ICCBasedColorspace iccProfile = new ICCBasedColorspace("USWebCoatedSWOP.icc");
			// Create profiled color brush
			ColorICC iccColor = new ColorICC(iccProfile, new ColorCMYK(0, 100, 0, 0));
			SolidBrush iccBrush = new SolidBrush(iccColor);
			// Draw a circle using the brush
			page.Canvas.DrawCircle(iccBrush, 200, 200, 100);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
