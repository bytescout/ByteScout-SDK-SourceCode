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

namespace GoToActionExample
{
    /// <summary>
    /// This example demonstrates how to create a button with GoTo action.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Add pages
            Page page1 = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page1);
            Page page2 = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page2);
            
            Font font = new Font(StandardFonts.Times, 18);
            Brush brush = new SolidBrush();
            
            // Mark action target with text
            page2.Canvas.DrawString("Action target", font, brush, 20, 200);
            
            // Create button
            PushButton button = new PushButton(20, 20, 100, 25, "button1");
            button.Caption = "Go To Page 2";
            // Create action to go to page 2 at 200 points from the top
            button.OnActivated = new GoToAction(new Destination(page2, 200));
            
            page1.Annotations.Add(button);
            
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
