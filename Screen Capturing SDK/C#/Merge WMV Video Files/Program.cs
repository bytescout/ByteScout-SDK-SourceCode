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
