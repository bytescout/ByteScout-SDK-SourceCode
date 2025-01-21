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
using System.Drawing;
using Bytescout.PDF;
using Brush = Bytescout.PDF.Brush;
using Pen = Bytescout.PDF.Pen;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace Rectangles
{
    /// <summary>
    /// This example demonstrates how to draw rectangles.
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
            Pen borderPen = new SolidPen(new ColorGray(128), 2f);
            Brush brush1 = new SolidBrush(new ColorRGB(255, 0, 0));
            Brush brush2 = new SolidBrush(new ColorRGB(0, 255, 255));

            // Draw transparent rectangle with border only
            canvas.DrawRectangle(borderPen, 100, 100, 100, 50);
            
            // Draw rounded rectangle with broder and filling
            canvas.DrawRoundedRectangle(borderPen, brush1, 250, 100, 100, 50, 10);

            // Draw rectangle as polygon
            canvas.DrawPolygon(borderPen, brush2, new PointF[] { new PointF(400, 100), new PointF(500, 100), new PointF(500, 150), new PointF(400, 150) });
            
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
