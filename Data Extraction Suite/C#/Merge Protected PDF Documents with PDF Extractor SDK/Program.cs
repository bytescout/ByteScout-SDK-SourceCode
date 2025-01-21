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
using Bytescout.PDFExtractor;

namespace MergeDocuments
{
    //
    // This example demonstrates how to provide password for protected PDF files.
    //
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputFiles = new string[]
            {
                @".\encrypted1 (password is 'password').pdf", 
                @".\encrypted2 (password is 'password').pdf",
            };

            using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
            {
                // Handle `PasswordRequired` event
                merger.PasswordRequired += new PasswordEventHandler(merger_PasswordRequired);

                // Ignore document permissions
                merger.CheckPermissions = false;

                merger.Merge(inputFiles, @".\result.pdf");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        static void merger_PasswordRequired(object sender, string document, ref string password)
        {
            // Ask user for password and return it using `password` parameter
            password = "password";
        }
    }
}
