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
using System.Threading;
using BytescoutSWFToVideo;

namespace MultipleInstances
{
    class Program
    {
        private static int _numBusy;
        private static ManualResetEvent _doneEvent;

        static void Main(string[] args)
        {
            _doneEvent = new ManualResetEvent(false);

            Console.WriteLine("Converting SWF movies to video in multiple threads, please wait...");

            _numBusy = 3;

            // start 3 conversion threads
            ThreadPool.QueueUserWorkItem(DoWork, 1);
            ThreadPool.QueueUserWorkItem(DoWork, 2);
            ThreadPool.QueueUserWorkItem(DoWork, 3);

            // wait for all threads finished
            _doneEvent.WaitOne();

            Console.WriteLine("All threads are finished. Press any key to continue..");
            Console.ReadKey();
        }

        static void DoWork(object data)
        {
            int index = (int)data;

            try
            {
                Console.WriteLine("Thread {0} started...", index);

                // Create BytescoutImageToVideo.ImageToVideo object instance
                SWFToVideo converter = new SWFToVideo();

                // Activate the component
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                converter.SWFConversionMode = SWFConversionModeType.SWFAnimation;

                // set input SWF file 
                converter.InputSWFFileName = string.Format("movie{0}.swf", index);

                // Set output video file name
                converter.OutputVideoFileName = String.Format("result_{0}.wmv", index);

                // set FPS 
                converter.FPS = 29.97f;

                // Set output video size
                converter.OutputWidth = 640;
                converter.OutputHeight = 480;

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

            if (Interlocked.Decrement(ref _numBusy) == 0)
            {
                _doneEvent.Set();
            }
        }
    }
}
