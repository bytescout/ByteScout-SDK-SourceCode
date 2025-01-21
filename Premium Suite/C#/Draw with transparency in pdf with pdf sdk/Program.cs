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

namespace Transparency
{
    /// <summary>
    /// This example demonstrates how to draw transparent objects.
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

            // Prepare pens and brushes
            Pen borderPen = new SolidPen(new ColorRGB(0, 0, 0), 2f);
            
            SolidBrush brush1 = new SolidBrush(new ColorRGB(255, 0, 0));
            SolidBrush brush2 = new SolidBrush(new ColorRGB(0, 0, 255));
            
            borderPen.Opacity = 50;
            brush1.Opacity = 30;
            brush2.Opacity = 60;

            // Draw normal rectangles
            canvas.DrawRectangle(brush1, 100, 100, 100, 100);
            canvas.DrawRectangle(borderPen, brush2, 150, 150, 100, 100);

            borderPen.Opacity = 80;
            brush1.Opacity = 60;
            brush2.Opacity = 30;

            // Draw rounded rectangles
            canvas.DrawRoundedRectangle(brush1, 220, 100, 100, 100, 10);
            canvas.DrawRoundedRectangle(borderPen, brush2, 270, 150, 100, 100, 10);
            
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
