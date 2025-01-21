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
using Bytescout.PDFExtractor;

namespace ExtractAttachments
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.AttachmentExtractor instance
            AttachmentExtractor extractor = new AttachmentExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\attachments.pdf");

            for (int i = 0; i < extractor.Count; i++)
            {
                Console.WriteLine("Saving attachment: " + extractor.GetFileName(i));
                // Save attachment to file
                extractor.Save(i, extractor.GetFileName(i));
                Console.WriteLine("File size: " + extractor.GetSize(i));
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
