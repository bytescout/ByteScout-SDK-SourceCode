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
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;

namespace LinkToPage
{
    /// <summary>
    /// This example demonstrates how to create a navigation link to a page.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            // Add two pages
            Page page1 = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page1);
            Page page2 = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page2);

            Font font = new Font(StandardFonts.Times, 12);
            Brush brush = new SolidBrush();
            
            // Create link annotation pointing to Page 2, 200 Points from the top.
            Destination destination = new Destination(page2, 200);
            LinkAnnotation link = new LinkAnnotation(destination, 20, 20, 100, 25);
            link.Color = new ColorRGB(255, 0, 0); // you can change the link color
            page1.Annotations.Add(link);

            // Draw link text (optional)
            page1.Canvas.DrawString("Link to Page 2", font, brush, new RectangleF(20, 20, 100, 25), 
                new StringFormat {HorizontalAlign = HorizontalAlign.Center, VerticalAlign = VerticalAlign.Center});
            
            // Draw a text at the link target
            page2.Canvas.DrawString("Link target", font, brush, 20, 200);
            
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
