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

namespace ExtractZUGFeRD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.AttachmentExtractor instance
            AttachmentExtractor extractor = new AttachmentExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\ZUGFeRD-invoice.pdf");

            // Extract the XML invoice that is stored as an attachment
            for (int i = 0; i < extractor.Count; i++)
            {
                Console.WriteLine("Saving XML invoice attachment: " + extractor.GetFileName(i));
                
                // Save file to current folder
                extractor.Save(i, extractor.GetFileName(i));

                Console.WriteLine("Done.");
            }

            // Cleanup
			extractor.Dispose();
            
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
