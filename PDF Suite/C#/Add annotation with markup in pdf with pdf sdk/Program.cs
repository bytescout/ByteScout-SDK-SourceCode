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
using System.Drawing;
using Bytescout.PDF;

namespace MarkupAnnotation
{
    /// <summary>
    /// This example demonstrates how to add markup annotations.
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

            // Draw sample markup annotations

            SquareAnnotation squareAnnotation = new SquareAnnotation(20, 20, 80, 80);
            squareAnnotation.BackgroundColor = new ColorRGB(255, 240, 240);
            squareAnnotation.BorderStyle.Style = BorderStyle.Dashed;
            squareAnnotation.BorderStyle.DashPattern = new DashPattern(new float[] { 3, 1, 3});
            page.Annotations.Add(squareAnnotation);

            CircleAnnotation circleAnnotation = new CircleAnnotation(120, 20, 80, 80);
            circleAnnotation.BackgroundColor = new ColorRGB(240, 250, 240);
            circleAnnotation.Color = new ColorRGB(128, 0 ,128);
            circleAnnotation.BorderEffect.Effect = BorderEffect.Cloudy;
            circleAnnotation.BorderEffect.Intensity = 2;
            page.Annotations.Add(circleAnnotation);

            LineAnnotation lineAnnotation = new LineAnnotation(20, 180, 100, 120);
            lineAnnotation.Color = new ColorRGB(255, 0, 0);
            lineAnnotation.StartLineStyle = LineEndingStyle.Butt;
            lineAnnotation.EndLineStyle = LineEndingStyle.OpenArrow;
            page.Annotations.Add(lineAnnotation);

            PointF[] pp = { new PointF(120, 120), new PointF(130, 130), new PointF(140, 120), new PointF(150, 130), new PointF(160, 120), new PointF(170, 130) };
            PointsArray points = new PointsArray(pp);
            PolylineAnnotation polylineAnnotation = new PolylineAnnotation(points);
            polylineAnnotation.BorderStyle.Width = 2;
            page.Annotations.Add(polylineAnnotation);
            
            
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
