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

namespace InvisibleTextOverImage
{
    /// <summary>
    /// This example demonstrates how to create PDF document from scanned document image and add invisible text over it. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            var output = @".\output.pdf";

            using (Document pdfDocument = new Document())
            {
                pdfDocument.RegistrationName = "demo";
                pdfDocument.RegistrationKey = "demo";

                Page page = new Page(PaperFormat.A4);
                pdfDocument.Pages.Add(page);

                var longText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.";
                var font = new Font("Arial", 12);
                var brush = new SolidBrush();
                var stringFormat = new StringFormat();
                
                float paragraphWidth = 500;
                float paragraphSpace = 15;
                float x = 40;
                float y = 20;

                // Measure and draw normal paragraph
                var paragraphHeight = page.Canvas.MeasureString(longText, font, paragraphWidth, stringFormat) + 3; // 3 is small adjustment to avoid text clipping
                page.Canvas.DrawString(longText, font, brush, new System.Drawing.RectangleF(x, y, paragraphWidth, paragraphHeight), stringFormat);

                y += paragraphHeight + paragraphSpace;

                // Measure and draw another paragraph with Line Spacing (leading) = 1.5
                stringFormat.Leading = 1.5f;
                paragraphHeight = page.Canvas.MeasureString(longText, font, paragraphWidth, stringFormat) + 3;
                page.Canvas.DrawString(longText, font, brush, new System.Drawing.RectangleF(x, y, paragraphWidth, paragraphHeight), stringFormat);
                
                y += paragraphHeight + paragraphSpace;
                
                // Measure and draw another paragraph justified
                stringFormat.HorizontalAlign = HorizontalAlign.Justify;
                paragraphHeight = page.Canvas.MeasureString(longText, font, paragraphWidth, stringFormat) + 3;
                page.Canvas.DrawString(longText, font, brush, new System.Drawing.RectangleF(x, y, paragraphWidth, paragraphHeight), stringFormat);
                
                y += paragraphHeight + paragraphSpace;
                
                // Draw further ...

                pdfDocument.Save(output);
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo(output);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
