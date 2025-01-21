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
