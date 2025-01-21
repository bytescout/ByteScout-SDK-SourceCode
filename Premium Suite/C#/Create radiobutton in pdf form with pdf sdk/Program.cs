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

namespace RadioButtons
{
    /// <summary>
    /// This example demonstrates how to create radio buttons.
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

            Font font = new Font(StandardFonts.Times, 12);
            SolidBrush brush = new SolidBrush();

            // Add a group of radio buttons
            RadioButton radioButton1 = new RadioButton(20, 20, 15, 15, "group1", "value1");
            RadioButton radioButton2 = new RadioButton(20, 40, 15, 15, "group1", "value2");
            page.Annotations.Add(radioButton1);
            page.Annotations.Add(radioButton2);
            // Add labels
            page.Canvas.DrawString("Value 1.1", font, brush, 40, 20);
            page.Canvas.DrawString("Value 1.2", font, brush, 40, 40);

            // Add another independent group of radio buttons
            RadioButton radioButton3 = new RadioButton(120, 20, 15, 15, "group2", "value3");
            RadioButton radioButton4 = new RadioButton(120, 40, 15, 15, "group2", "value4");
            page.Annotations.Add(radioButton3);
            page.Annotations.Add(radioButton4);
            // Add labels
            page.Canvas.DrawString("Value 2.1", font, brush, 140, 20);
            page.Canvas.DrawString("Value 2.2", font, brush, 140, 40);

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
