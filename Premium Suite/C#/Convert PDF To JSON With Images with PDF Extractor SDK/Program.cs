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

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.JSONExtractor instance
            JSONExtractor extractor = new JSONExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile("sample1.pdf");

            // Uncomment this line to get rid of empty nodes in JSON
            //extractor.PreserveFormattingOnTextExtraction = false;

            // Set output image format
            extractor.ImageFormat = OutputImageFormat.PNG;
            
            // Save images to external files
            extractor.SaveImages = ImageHandling.OuterFile;
            extractor.ImageFolder = "images"; // Folder for external images
            extractor.SaveJSONToFile("result_with_external_images.json");

            // Embed images into JSON as Base64 encoded string
            extractor.SaveImages = ImageHandling.Embed;
            extractor.SaveJSONToFile("result_with_embedded_images.json");

            // Cleanup
			extractor.Dispose();
        }
    }
}
