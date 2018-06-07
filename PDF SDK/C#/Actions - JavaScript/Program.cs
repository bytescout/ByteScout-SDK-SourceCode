//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace JavaScriptActionExample
{
	/// <summary>
	/// This example demonstrates how to add JavaScript actions to document events.
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
			pdfDocument.Pages.Add(new Page(PaperFormat.A4));

			// Add action to document open event
			JavaScriptAction onOpenDocument = new JavaScriptAction("app.alert(\"OnOpenDocument\",3)");
			pdfDocument.OnOpenDocument = onOpenDocument;

			// Add action to document close event
			JavaScriptAction onBeforeClosing = new JavaScriptAction("app.alert(\"OnBeforeClosing\",3)");
			pdfDocument.OnBeforeClosing = onBeforeClosing;
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
