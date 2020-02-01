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
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace Layers
{
    /// <summary>
    /// This example demonstrates how to add layers with optional content.
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

            // Add main layer
            Layer allContents = new Layer("Main Layer");
            canvas.BeginMarkedContent(allContents);

            // Add sub-layer
            Layer layer1 = new Layer("Square");
            canvas.BeginMarkedContent(layer1);
            canvas.DrawRectangle(new SolidBrush(new ColorRGB(0, 255, 0)), 20, 20, 100, 100);
            canvas.EndMarkedContent();

            // Add second sub-layer
            Layer layer2 = new Layer("Circle");
            canvas.BeginMarkedContent(layer2);
            canvas.DrawCircle(new SolidBrush(new ColorRGB(255, 0, 0)), 70, 180, 50);
            canvas.EndMarkedContent();

            // Add third sub-layer
            Layer layer3 = new Layer("Triangle");
            canvas.BeginMarkedContent(layer3);
            canvas.DrawPolygon(new SolidBrush(new ColorRGB(0, 0, 255)), new PointF[] { new PointF(20, 340), new PointF(70, 240), new PointF(120, 340) });
            canvas.EndMarkedContent();

            canvas.EndMarkedContent();

            pdfDocument.OptionalContents.Layers.Add(layer1);
            pdfDocument.OptionalContents.Layers.Add(layer2);
            pdfDocument.OptionalContents.Layers.Add(layer3);
            pdfDocument.OptionalContents.Layers.Add(allContents);

            // Configure layers

            // Group sub-layers
            OptionalContentGroup group = new OptionalContentGroup();
            group.Add(new OptionalContentGroupLayer(layer1));
            group.Add(new OptionalContentGroupLayer(layer2));
            group.Add(new OptionalContentGroupLayer(layer3));

            // Order sub-layers
            pdfDocument.OptionalContents.Configuration.Order.Add(new OptionalContentGroupLayer(allContents));
            pdfDocument.OptionalContents.Configuration.Order.Add(group);

            // Make the third layer invisible by default (for example)
            pdfDocument.OptionalContents.Configuration.OFF.Add(layer3);

            // Force the PDF viewer to show the layers panel initially
            pdfDocument.PageMode = PageMode.OptionalContent;
            
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
