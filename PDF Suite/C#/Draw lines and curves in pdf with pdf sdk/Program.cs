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

namespace LinesAndCurves
{
    /// <summary>
    /// This example demonstrates how to draw lines and curves.
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

            SolidPen solidPen = new SolidPen();
            SolidPen dashedPen = new SolidPen();
            dashedPen.DashPattern = new DashPattern(new float[] { 2, 2 });

            // Draw dashed lines
            canvas.DrawLine(dashedPen, 100, 100, 200, 100);
            canvas.DrawLine(dashedPen, 200, 100, 200, 200);
            canvas.DrawLine(dashedPen, 200, 200, 100, 200);
            // Draw besier curve by the same points
            canvas.DrawCurve(solidPen, 100, 100, 200, 100, 200, 200, 100, 200);
            
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
