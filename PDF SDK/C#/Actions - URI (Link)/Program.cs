//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using Bytescout.PDF;

namespace UriAction
{
	/// <summary>
	/// This example demonstrates how to create URI (link) action.
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

			// Add button
			PushButton button = new PushButton(20, 20, 150, 25, "button1");
			button.Caption = "BYTESCOUT.COM";
			// Add URI action
			URIAction action = new URIAction(new Uri("http://bytescout.com/"));
			button.OnActivated = action;
			page.Annotations.Add(button);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
