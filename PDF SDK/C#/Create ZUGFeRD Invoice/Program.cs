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

namespace FileAttachmentAnnotationExample
{
    /// <summary>
    /// This example demonstrates how to attach a file to PDF document.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            
            // Load existing document
            pdfDocument.Load(@".\Invoice.pdf");

            // Attach ZUGFeRD XML file
            FileAttachmentAnnotation fileAttachment = new FileAttachmentAnnotation(@".\ZUGFeRD-invoice.xml", 0, 0, 0, 0);
            pdfDocument.Pages[0].Annotations.Add(fileAttachment);
            
            // Instruct PDF viewer applications to show attachments pane on startup (optional)
            pdfDocument.PageMode = PageMode.Attachment;
            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
