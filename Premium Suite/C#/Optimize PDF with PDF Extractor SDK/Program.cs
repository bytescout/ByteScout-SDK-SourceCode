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
using System.IO;
using Bytescout.PDFExtractor;

namespace OptimizePDF
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.DocumentOptimizer instance
            using (DocumentOptimizer optimizer = new DocumentOptimizer("demo", "demo"))
            {
                // Try various optimization options
                OptimizationOptions optimizationOptions = new OptimizationOptions();
                optimizationOptions.ImageOptimizationFormat = ImageOptimizationFormat.JPEG;
                optimizationOptions.JPEGQuality = 25;
                optimizationOptions.ResampleImages = true;
                optimizationOptions.ResamplingResolution = 120;

                // Optimize document and save it to new file
                optimizer.OptimizeDocument(@".\sample1.pdf", @".\optimized.pdf", optimizationOptions);
            }
            
            Console.WriteLine("Optimized document has been saved as " + Path.GetFullPath(@".\optimized.pdf"));
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
