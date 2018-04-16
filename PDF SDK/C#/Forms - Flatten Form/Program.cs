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


using System;
using System.Diagnostics;
using Bytescout.PDF;

namespace FlattenFormExample
{
	/// <summary>
	/// This example demonstrates how to flatten a filled PDF form (make it uneditable).
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Load filled PDF form
			Document pdfDocument = new Document(@"filled_form.pdf");
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			
			// Flatten the form
			pdfDocument.FlattenDocument();

			// Save modified document
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
