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
using System.Threading;
using BytescoutImageToVideo;

namespace MultipleInstances
{
    class Program
    {
        private static int numBusy;
        private static ManualResetEvent doneEvent;

        static void Main(string[] args)
        {
            doneEvent = new ManualResetEvent(false);

            Console.WriteLine("Converting JPG slides to video in multiple threads, please wait...");

            numBusy = 10; // 10 threads to start

            // Start threads
            for (int i = 1; i <= numBusy; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, i);
            }

            // wait for all threads finished
            doneEvent.WaitOne();

            Console.WriteLine("All threads are finished. Press any key to continue..");
            Console.ReadKey();
        }
        
        static TransitionEffectType GetRandomEffect()
        {
            Random rr = new Random();
            return (TransitionEffectType)(rr.Next((int)TransitionEffectType.teZoomOut, (int)TransitionEffectType.teBlinds3DHorz));
        }

        static void DoWork(object data)
        {
            int index = (int)data;

            try
            {
                Console.WriteLine("Thread {0} started...", index);

				// Create BytescoutImageToVideo.ImageToVideo object instance
				ImageToVideo converter = new ImageToVideo();

                // Activate the component
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                // Add images and set the duration for every slide
                Slide slide;
                slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
                slide.Duration = 3000; // 3000ms = 3s
                slide.InEffect = GetRandomEffect();
                slide.OutEffect = GetRandomEffect();


                slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
                slide.Duration = 3000;
                slide.InEffect = GetRandomEffect();
                slide.OutEffect = GetRandomEffect();

                slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide3.jpg");
                slide.Duration = 3000;
                slide.InEffect = GetRandomEffect();
                slide.OutEffect = GetRandomEffect();
                
                // Set output video size
                converter.OutputWidth = 640;
                converter.OutputHeight = 480;

                // Set output video file name
                converter.OutputVideoFileName = String.Format("result_{0}.wmv", index);

                // Run the conversion
                converter.RunAndWait();

                // Release resources
                System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

                Console.WriteLine("Thread {0} finished.", index);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thread {0} failed: {1}", index, ex.Message);
            }

            // check until numBusy is equal to 0 (as it we use it as a counter to count finished threads)
            if (Interlocked.Decrement(ref numBusy) == 0)
            {
                doneEvent.Set();
            }
        }
    }
}
