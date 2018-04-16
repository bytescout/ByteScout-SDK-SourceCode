//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Diagnostics;

using BytescoutImageToVideo;


namespace ImageToVideoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Converting JPG slides to video, please wait...");

                // Create ImageToVideo object instance
                ImageToVideo converter = new ImageToVideo();

                // Activate the component
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                // Add images and set the duration for every slide
                Slide slide;
                slide = converter.AddImageFromFileName("slide1.jpg");
                slide.Duration = 3000; // 3000ms = 3s
                slide = converter.AddImageFromFileName("slide2.jpg");
                slide.Duration = 3000;
                slide = converter.AddImageFromFileName("slide3.jpg");
                slide.Duration = 3000;

                // Set output video size
                converter.OutputWidth = 640;
                converter.OutputHeight = 480;

                // Set output video file name
                converter.OutputVideoFileName = "result.wmv";

                // Run the conversion
                converter.RunAndWait();

                // Release resources
                System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

                // Open the result video file in default media player
                Process.Start("result.wmv");

                Console.WriteLine("Done. Press any key to continue..");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine();
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
