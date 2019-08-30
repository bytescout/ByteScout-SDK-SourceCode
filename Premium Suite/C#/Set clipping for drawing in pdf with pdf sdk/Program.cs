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


using System;
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDF;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace Clipping
{
    /// <summary>
    /// This example demonstrates how to use the graphics clipping.
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

            PointF center = new PointF(200, 200);

            // Create clipping path from circle
            Path path = new Path();
            path.AddCircle(center, 100);
            page.Canvas.SetClip(path);

            // Paint rectangle over the clipping circle.
            // Only part of the rectangle intersecting the clipping circle will be drawn.
            SolidBrush brush = new SolidBrush(new ColorRGB(255, 0, 0));
            page.Canvas.DrawRectangle(brush, center.X - 50, center.Y - 50, 200, 200);

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
