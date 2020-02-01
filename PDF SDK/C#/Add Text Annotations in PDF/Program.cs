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


using System.Diagnostics;
using Bytescout.PDF;

namespace TextAnnotationExample
{
    /// <summary>
    /// This example demonstrates how to add a text annotation.
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

            // Add collapsed annotation (shown as a tooltip when mouse is over the icon)
            TextAnnotation collapsedAnnotation = new TextAnnotation(20, 20);
            collapsedAnnotation.Color = new ColorRGB(255, 255, 0);
            collapsedAnnotation.Icon = TextAnnotationIcon.Comment;
            collapsedAnnotation.Author = "Mr. Important";
            collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog.";
            page.Annotations.Add(collapsedAnnotation);

            // Add expanded annotation
            TextAnnotation expandedAnnotation = new TextAnnotation(20, 50);
            expandedAnnotation.Color = new ColorRGB(255, 0, 0);
            expandedAnnotation.Icon = TextAnnotationIcon.Note;
            expandedAnnotation.Open = true;
            expandedAnnotation.Author = "John Doe";
            expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog.";
            page.Annotations.Add(expandedAnnotation);
            
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
