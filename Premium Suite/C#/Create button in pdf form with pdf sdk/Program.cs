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

namespace Buttons
{
    /// <summary>
    /// This example demonstrates how to create a button and decorate it.
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

            // Create a button
            PushButton button = new PushButton(50, 50, 100, 30, "button1");
            button.Caption = "Button";
            // Decorate the button with various styles
            button.BackgroundColor = new ColorRGB(192, 192, 255);
            button.BorderWidth = 2;
            button.BorderStyle = BorderStyle.Beveled;
            button.BorderColor = new ColorRGB(0, 0, 128);
            button.Font = new Font(StandardFonts.Times, 16);
            button.FontColor = new ColorRGB(0, 0, 0);
            button.HighlightingMode = PushButtonHighlightingMode.Outline;

            // Add button to the page
            page.Annotations.Add(button);
            
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
