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

namespace RightToLeftText
{
    /// <summary>
    /// This example demonstrates how to draw right-to-left text.
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

            Font font = new Font("Arial", 16);
            Brush brush = new SolidBrush();
            
            // Set right to left text direction
            StringFormat stringFormat = new StringFormat();
            stringFormat.DirectionRightToLeft = true;

            page.Canvas.DrawString("???? ????? ?????", font, brush, page.Width - 20, 30, stringFormat);
            page.Canvas.DrawString("???, ?????, ????", font, brush, page.Width - 20, 50, stringFormat);
            page.Canvas.DrawString("?? ?? ??", font, brush, page.Width - 20, 70, stringFormat);

            
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
