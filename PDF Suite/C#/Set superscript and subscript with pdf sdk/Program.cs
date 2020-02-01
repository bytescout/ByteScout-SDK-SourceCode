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

namespace SuperscripAndSubscript
{
    /// <summary>
    /// This example demonstrates how to draw subscript or superscript text adjusting the text baseline.
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
            StringFormat stringFormat = new StringFormat();
            float xPosition = 20;

            // Draw normal string
            page.Canvas.DrawString("Normal text ", font, brush, xPosition, 50, stringFormat);
            xPosition += font.GetTextWidth("Normal text ");

            // Draw subscript string 
            stringFormat.Rise = -5;
            page.Canvas.DrawString("Subscript", font, brush, xPosition, 50, stringFormat);
            xPosition += font.GetTextWidth("Subscript");

            // draw superscript string
            stringFormat.Rise = +5;
            page.Canvas.DrawString("Superscript", font, brush, xPosition, 50, stringFormat);
            xPosition += font.GetTextWidth("Superscript");

            // Draw the baseline
            Pen pen = new SolidPen(new ColorRGB(0, 0, 255));
            pen.Opacity = 50;
            page.Canvas.DrawLine(pen, 20, 50 + font.Size, xPosition, 50 + font.Size);

            
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
