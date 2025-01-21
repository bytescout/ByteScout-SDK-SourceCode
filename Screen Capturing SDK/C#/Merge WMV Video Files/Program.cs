//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using BytescoutScreenCapturingLib; // import bytescout screen capturing activex object 
using System;
using System.Diagnostics;

namespace MergeWMVVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Capturer object
            Capturer capturer = new Capturer();

            // Merge WMV files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
            capturer.JoinWMVFiles("Sample1.wmv", "Sample2.wmv", "output.wmv");

            Console.WriteLine("Files merged successfully!");
            Process.Start("output.wmv");
        }
    }
}
