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

namespace PasswordsAndPermissions
{
    /// <summary>
    /// This example demonstrates how to lock the document with a password. 
    /// PDF format supports two kinds of passwords: owner and user password.
    /// User password allows to view document and perform allowed actions.
    /// Owner password allows everything, including changing passwords and permissions.
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
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));


            // Set document encryption algorythm
            pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.RC4_40bit;
            // Set various user permissions
            pdfDocument.Security.AllowPrintDocument = false;
            pdfDocument.Security.AllowContentExtraction = false;
            pdfDocument.Security.AllowModifyAnnotations = false;
            pdfDocument.Security.PrintQuality = PrintQuality.LowResolution;
            
            // Set owner password
            pdfDocument.Security.OwnerPassword = "ownerpassword";
            
            // Set user password
            pdfDocument.Security.UserPassword = "userpassword";
            
            
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
