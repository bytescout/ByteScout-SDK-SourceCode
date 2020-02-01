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
            // Create new PDF document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";


            // Load image from file to System.Drawing.Image object (we need it to get the image resolution)
            System.Drawing.Image sysImage = System.Drawing.Image.FromFile(@".\scanned-invoice.png");
            // Compute image size in PDF units (Points)
            float widthInPoints = sysImage.Width / sysImage.HorizontalResolution * 72f;
            float heightInPoints = sysImage.Height / sysImage.VerticalResolution * 72f;

            // Create page of computed size
            Page page = new Page(widthInPoints, heightInPoints);
            // Add page to the document
            pdfDocument.Pages.Add(page);

            Canvas canvas = page.Canvas;

            // Create Bytescout.PDF.Image object from loaded image
            Image pdfImage = new Image(sysImage);
            // Draw the image
            canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints);

            // Dispose the System.Drawing.Image object to free resources
            sysImage.Dispose();

            // Create brush
            SolidBrush transparentBrush = new SolidBrush(new ColorGray(0));
            // ... and make it transparent
            transparentBrush.Opacity = 0;

            // Draw text with transparent brush
            Font font16 = new Font(StandardFonts.Helvetica, 16);
            canvas.DrawString("Your Company Name", font16, transparentBrush, 40, 40);
            // Draw another text
            Font font10 = new Font(StandardFonts.Helvetica, 10);
            canvas.DrawString("Your Address", font10, transparentBrush, 40, 80);

            
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
