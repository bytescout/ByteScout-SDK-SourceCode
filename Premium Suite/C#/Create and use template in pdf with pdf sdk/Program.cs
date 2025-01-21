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
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace Templates
{
    /// <summary>
    /// This example demonstrates how to use templates.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            
            // Prepare simple template (for example, a logo) and draw it on every page

            // Create template of specified size
            GraphicsTemplate template = new GraphicsTemplate(250, 50);
            // Draw the logo
            template.DrawRectangle(new SolidBrush(new ColorRGB(192, 192, 255)), 0, 0, 250, 50);
            template.DrawString("My Company Logo", new Font(StandardFonts.TimesBoldItalic, 24), new SolidBrush(), 30, 10);

            // Add few pages and draw the prepared template on each one
            for (int i = 0; i < 3; i++)
            {
                Page page = new Page(PaperFormat.A4);
                page.Canvas.DrawTemplate(template, 10, 10);
                pdfDocument.Pages.Add(page);
            }
            
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
