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

namespace ListBoxes
{
    /// <summary>
    /// This example demonstrates how to create a listbox.
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

            // Add list box, add items and make it multi-selectable
            ListBox listBox = new ListBox(20, 20, 120, 80, "listBox1");
            listBox.Items.Add("Value 1");
            listBox.Items.Add("Value 2");
            listBox.Items.Add("Value 3");
            listBox.Items.Add("Value 4");
            listBox.Items.Add("Value 5");
            listBox.MultiSelect = true;
            // Decorate listbox
            listBox.Font = new Font(StandardFonts.Helvetica, 10);
            listBox.BorderColor = new ColorRGB(0, 0, 128);
            listBox.BackgroundColor = new ColorRGB(240, 240, 255);
            listBox.BorderWidth = 2;

            page.Annotations.Add(listBox);
            
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
