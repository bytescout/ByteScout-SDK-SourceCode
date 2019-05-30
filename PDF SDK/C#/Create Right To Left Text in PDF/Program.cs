//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace RightToLeftText
{
    /// <summary>
    /// This example demonstrates how to draw right-to-left text.
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

            Font font = new Font("Arial", 16);
            Brush brush = new SolidBrush();
            
            // Set right to left text direction
            StringFormat stringFormat = new StringFormat();
            stringFormat.DirectionRightToLeft = true;

            page.Canvas.DrawString("???? ????? ?????", font, brush, page.Width - 20, 30, stringFormat);
            page.Canvas.DrawString("???, ?????, ????", font, brush, page.Width - 20, 50, stringFormat);
            page.Canvas.DrawString("?? ?? ??", font, brush, page.Width - 20, 70, stringFormat);

            
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
