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

namespace FileAttachmentAnnotationExample
{
	/// <summary>
	/// This example demonstrates how to attach a file to PDF document.
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

			// Attach file
			FileAttachmentAnnotation fileAttachment = new FileAttachmentAnnotation("sample_attachment.txt", 20, 20, 20, 20);
			fileAttachment.Icon = FileAttachmentAnnotationIcon.Paperclip;
			page.Annotations.Add(fileAttachment);
			
			// Instruct PDF viewer application to show attachments pane on startup
			pdfDocument.PageMode = PageMode.Attachment;
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
