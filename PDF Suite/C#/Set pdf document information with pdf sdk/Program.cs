//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.PDF;

namespace DocumentInformation
{
    /// <summary>
    /// This example demonstrates how to set various document properties.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Change document information.
            // Open Document Properties in PDF viewer to see the changes.
            pdfDocument.DocumentInfo.Author = "John Doe";
            pdfDocument.DocumentInfo.Creator = "My Application";
            pdfDocument.DocumentInfo.Keywords = "accounting,invoice";
            pdfDocument.DocumentInfo.Title = "Invoice #12345";
            pdfDocument.DocumentInfo.Subject = "Invoice";
            pdfDocument.DocumentInfo.CreationDate = new DateTime(2015, 12, 21);
            pdfDocument.DocumentInfo.ModificationDate = DateTime.Now;

            // Add empty page to make the document valid
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));

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
