//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.PDF;

namespace UriAction
{
    /// <summary>
    /// This example demonstrates how to create URI (link) action.
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

            // Set Url action
            URIAction action = new URIAction(new Uri("https://bytescout.com"));

            // Add link annotation
            LinkAnnotation linkAnnotation = new LinkAnnotation(action, 20, 20, 150, 25);

            // Set highlight mode
            linkAnnotation.HighlightingMode = LinkAnnotationHighlightingMode.Outline;

            // Set color
            linkAnnotation.Color = new ColorRGB(0, 0, 255);

            // Add Link
            page.Annotations.Add(linkAnnotation);

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
