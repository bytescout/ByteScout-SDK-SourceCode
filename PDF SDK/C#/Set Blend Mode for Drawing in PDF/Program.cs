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

namespace BlendModeExample
{
    /// <summary>
    /// This example demonstrates how to use blend modes - a way how 
    /// intersecting semi-transparent objects will blend on page canvas.
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

            Canvas canvas = page.Canvas;

            // Create transparent brushes
            SolidBrush brushRed = new SolidBrush(new ColorRGB(255, 0, 0));
            brushRed.Opacity = 50;
            SolidBrush brushGreen = new SolidBrush(new ColorRGB(0, 255, 0));
            brushGreen.Opacity = 50;
            SolidBrush brushBlue = new SolidBrush(new ColorRGB(0, 0, 255));
            brushBlue.Opacity = 50;

            // Normal blending
            canvas.BlendMode = BlendMode.Normal;
            canvas.DrawCircle(brushRed, 100, 100, 50);
            canvas.DrawCircle(brushGreen, 100, 150, 50);
            canvas.DrawCircle(brushBlue, 150, 100, 50);

            // Darken blending
            canvas.BlendMode = BlendMode.Darken;
            canvas.DrawCircle(brushRed, 300, 100, 50);
            canvas.DrawCircle(brushGreen, 300, 150, 50);
            canvas.DrawCircle(brushBlue, 350, 100, 50);

            // Lighten blending
            canvas.BlendMode = BlendMode.Lighten;
            canvas.DrawCircle(brushRed, 100, 300, 50);
            canvas.DrawCircle(brushGreen, 100, 350, 50);
            canvas.DrawCircle(brushBlue, 150, 300, 50);

            // Color burn blending
            canvas.BlendMode = BlendMode.ColorBurn;
            canvas.DrawCircle(brushRed, 300, 300, 50);
            canvas.DrawCircle(brushGreen, 300, 350, 50);
            canvas.DrawCircle(brushBlue, 350, 300, 50);

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
