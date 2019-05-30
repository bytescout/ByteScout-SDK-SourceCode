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

namespace StringScaling
{
    /// <summary>
    /// This example demonstrates how to use the font scaling to expand a string.
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

            stringFormat.Scaling = 100f;
            page.Canvas.DrawString("Normal string 100.0%", font, brush, 20, 20, stringFormat);

            stringFormat.Scaling = 50.0f;
            page.Canvas.DrawString("Squeezed string 50.0%", font, brush, 20, 50, stringFormat);

            stringFormat.Scaling = 150.0f;
            page.Canvas.DrawString("Expanded string 150.0%", font, brush, 20, 80, stringFormat);

            
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
