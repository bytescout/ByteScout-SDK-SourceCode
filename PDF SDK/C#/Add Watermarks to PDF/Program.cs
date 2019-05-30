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

namespace Watermarks
{
    /// <summary>
    /// This example demonstrates how add text watermark to document page.
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
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));

            // Add tiling watermark
            TextWatermark watermark1 = new TextWatermark("Tiling Watermark");
            watermark1.WatermarkLocation = TextWatermarkLocation.Tiled;
            watermark1.Angle = 30;
            SolidBrush brush1 = new SolidBrush(new ColorRGB(0, 0, 255));
            brush1.Opacity = 50; // make the brush semitransparent
            watermark1.Brush = brush1;
            pdfDocument.Watermarks.Add(watermark1);

            // Add autosized watermark to every page of the document
            TextWatermark watermark2 = new TextWatermark("Diagonal Watermark");
            watermark2.WatermarkLocation = TextWatermarkLocation.DiagonalFromBottomLeftToTopRight;
            watermark2.Font = new Font("Times New Roman", 16);
            SolidBrush brush2 = new SolidBrush(new ColorRGB(255, 0, 0));
            brush2.Opacity = 50; // make the brush semitransparent
            watermark2.Brush = brush2;
            watermark2.Pen = new SolidPen(new ColorRGB(255, 0, 0)); // outline pen is optional
            pdfDocument.Watermarks.Add(watermark2);

            // Add watermark of custom size and location to the first page only
            TextWatermark watermark3 = new TextWatermark("Simple Watermark");
            watermark3.Font = new Font(StandardFonts.HelveticaBold, 24);
            watermark3.Brush = new SolidBrush(new ColorRGB(0, 128, 0));
            watermark3.Left = 350;
            watermark3.Top = 800;
            pdfDocument.Pages[0].Watermarks.Add(watermark3);
            
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
