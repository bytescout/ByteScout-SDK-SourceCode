//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDF;
using System;

namespace RemovePdfProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Files
                string fileName = "ProtectedPDFFile.pdf";
                string fileName_UnProtected = "UnProtectedPDFFile.pdf";

                //Protected file password
                string filePassword = "admin@123";

                //Process file to remove password
                using (Document document = new Document())
                {
                    document.RegistrationName = "demo";
                    document.RegistrationKey = "demo";

                    document.Load(fileName, filePassword);

                    // Remove password protection and encryption
                    document.Security.OwnerPassword = String.Empty;
                    document.Security.UserPassword = String.Empty;
                    document.Security.EncryptionAlgorithm = EncryptionAlgorithm.None;

                    // Remove restrictions
                    document.Security.AllowAccessibilitySupport = true;
                    document.Security.AllowAssemlyDocument = true;
                    document.Security.AllowContentExtraction = true;
                    document.Security.AllowFillForms = true;
                    document.Security.AllowModifyAnnotations = true;
                    document.Security.AllowModifyDocument = true;
                    document.Security.AllowPrintDocument = true;
                    document.Security.PrintQuality = PrintQuality.HightResolution;

                    //Save Unprotected file
                    document.Save(fileName_UnProtected);
                }

                Console.WriteLine("PDF restrictions removed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
