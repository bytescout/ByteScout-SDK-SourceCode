//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.IO;
using Bytescout.PDFExtractor;

namespace BatchProcessing
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Get PDF files 
            string[] pdfFiles = Directory.GetFiles(".", "*.pdf");

            foreach (string file in pdfFiles)
            {
                // Load document
                extractor.LoadDocumentFromFile(file);

                // Save extracted text to .txt file
                extractor.SaveTextToFile(Path.ChangeExtension(file, ".txt"));

                // Reset the extractor before load another file
                extractor.Reset();
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
