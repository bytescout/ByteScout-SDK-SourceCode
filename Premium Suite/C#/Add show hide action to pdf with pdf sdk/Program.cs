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

namespace ShowHideWidget
{
    /// <summary>
    /// This example demonstrates how to show/hide a widget in document.
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

            // Create widget that will be shown/hidden
            EditBox editBox = new EditBox(20, 20, 100, 25, "editBox1");
            editBox.Text = "editBox1";
            page.Annotations.Add(editBox);
            
            // Create button that will show the widget
            PushButton buttonShow = new PushButton(20, 80, 50, 25, "buttonShow");
            buttonShow.Caption = "Show";
            page.Annotations.Add(buttonShow);
            // Add Show action
            HideAction showAction = new HideAction(false);
            showAction.Fields.Add(editBox);
            buttonShow.OnActivated = showAction;

            // Create button that will hide the widget
            PushButton buttonHide = new PushButton(100, 80, 50, 25, "buttonHide");
            buttonHide.Caption = "Hide";
            page.Annotations.Add(buttonHide);
            // Add Hide action
            HideAction hideAction = new HideAction(true);
            hideAction.Fields.Add(editBox);
            buttonHide.OnActivated = hideAction;

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
