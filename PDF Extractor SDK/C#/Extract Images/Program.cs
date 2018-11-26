//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
