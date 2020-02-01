//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Drawing.Imaging;
using Bytescout.PDFExtractor;
using System.Diagnostics;

namespace ExtractImagesByPages
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

            // Get count of pages
            int pageCount = extractor.GetPageCount();

            // Extract images from each page
            for (int i = 0; i < pageCount; i++)
            {
                int j = 0;
                
                // Initialize page images enumeration
                if (extractor.GetFirstPageImage(i))
                {
                    do
                    {
                        string outputFileName = "page" + i + "image" + j + ".png";

                        // Save image to file
                        extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png);

                        j++;

                    } while (extractor.GetNextImage()); // Advance image enumeration
                }
            }

            // Cleanup
            extractor.Dispose();
            
            // Open first output file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("page0image0.png");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
