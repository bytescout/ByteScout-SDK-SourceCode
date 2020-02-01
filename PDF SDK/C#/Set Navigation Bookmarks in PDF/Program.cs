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


using System.CodeDom;
using System.Diagnostics;
using Bytescout.PDF;

namespace Bookmarks
{
    /// <summary>
    /// This example demonstrates how to create document outlines (bookmarks).
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            
            Font font = new Font(StandardFonts.Times, 18);
            Brush brush = new SolidBrush();

            // Create pages
            for (int i = 0; i < 3; i++)
            {
                Page page = new Page(PaperFormat.A4);
                page.Canvas.DrawString(string.Format("Page {0}", i + 1), font, brush, 20, 20);
                pdfDocument.Pages.Add(page);
            }

            // Create outlines:

            Destination destination1 = new Destination(pdfDocument.Pages[0]);
            Outline outline1 = new Outline("Page 1", destination1);
            pdfDocument.Outlines.Add(outline1);

            // Example of sub-bookmark
            Destination destination2 = new Destination(pdfDocument.Pages[1]);
            Outline outline2 = new Outline("Page 2", destination2);
            pdfDocument.Outlines[0].Kids.Add(outline2);

            Destination destination3 = new Destination(pdfDocument.Pages[2]);
            Outline outline3 = new Outline("Page 3", destination3);
            pdfDocument.Outlines.Add(outline3);

            // Force PDF viewer to show Bookmarks panel at start up.
            pdfDocument.PageMode = PageMode.Outlines;
            
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
