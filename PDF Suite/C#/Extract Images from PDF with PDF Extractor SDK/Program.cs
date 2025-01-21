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
using System.Drawing.Imaging;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace ExtractAllImages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.ImageExtractor instance
            ImageExtractor extractor = new ImageExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";
            
            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\sample1.pdf");

            int i = 0;

            // Initialize image enumeration
            if (extractor.GetFirstImage())
            {
                do
                {
                    string outputFileName = "image" + i + ".png";

                    // Save image to file
                    extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png);

                    i++;

                } while (extractor.GetNextImage()); // Advance image enumeration
            }

            // Cleanup
            extractor.Dispose();

            // Open first output file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("image0.png");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
