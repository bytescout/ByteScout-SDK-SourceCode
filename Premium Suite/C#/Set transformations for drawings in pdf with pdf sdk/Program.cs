//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace Transformations
{
    /// <summary>
    /// This example demonstrates how to use coordinate space transformations.
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

            // Prepare pens
            Pen blackPen = new SolidPen(new ColorRGB(0, 0, 0), 2f);
            blackPen.Opacity = 50;
            Pen bluePen = new SolidPen(new ColorRGB(0, 0, 255), 2f);
            bluePen.Opacity = 50;
            Pen greenPen = new SolidPen(new ColorRGB(0, 255, 0), 2f);
            greenPen.Opacity = 50;

            // Move coordinate space zero point to (200, 200) and draw a rectangle of 50x50 dize
            canvas.TranslateTransform(200, 200);
            canvas.DrawRectangle(blackPen, 0, 0, 50, 50);

            // Now zoom the coordinate space in twice and draw the same rectangle in green
            canvas.ScaleTransform(2, 2);
            canvas.DrawRectangle(greenPen, 0, 0, 50, 50);

            // Now rotate the coordinate space by 30 degrees and draw the same rectangle in blue
            canvas.RotateTransform(30);
            canvas.DrawRectangle(bluePen, 0, 0, 50, 50);
            
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
