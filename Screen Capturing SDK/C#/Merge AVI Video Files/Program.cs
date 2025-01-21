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

namespace MergeAVIVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Capturer object
            Capturer capturer = new Capturer();

            // Merge AVI files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
            capturer.JoinAVIFiles("Sample1.avi", "Sample2.avi", "output.avi");

            Console.WriteLine("Files merged successfully!");
            Process.Start("output.avi");
        }
    }
}
