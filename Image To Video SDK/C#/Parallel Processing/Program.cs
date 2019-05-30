//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Threading;
using BytescoutImageToVideo;

namespace ImageToVideoParallelProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ManualResetEvent event1 = new ManualResetEvent(false);
                ManualResetEvent event2 = new ManualResetEvent(false);

                ThreadPool.QueueUserWorkItem(ThreadProc1, event1);

                // (!) Start the second thread with a delay because codecs are locked during the video initialization.
                Thread.Sleep(1000);

                ThreadPool.QueueUserWorkItem(ThreadProc2, event2);

                WaitHandle.WaitAll(new WaitHandle[] { event1, event2 });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erorr: {0}", ex.Message);
            }

            Console.WriteLine("Done. Press enter key to exit...");
            Console.ReadLine();
        }


        static void ThreadProc1(object state)
        {
            ManualResetEvent event1 = (ManualResetEvent)state;

            try
            {
                ImageToVideo converter = new ImageToVideo();
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                Array x = Enum.GetValues(typeof(PanZoomEffectType));

                foreach (string file in Directory.GetFiles(@".\images"))
                {
                    Slide slide = converter.AddImageFromFileName(file);
                    slide.Duration = 3000;
                    slide.PanZoomEffect = (PanZoomEffectType)x.GetValue((new Random()).Next(8));
                    slide.InEffect = TransitionEffectType.teFade;
                    slide.InEffectDuration = 250;
                    slide.OutEffect = TransitionEffectType.teFade;
                    slide.OutEffectDuration = 250;
                }

                converter.OutputVideoFileName = "result1.wmv";
                converter.OutputWidth = 800;
                converter.OutputHeight = 600;
                converter.RunAndWait();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

                Console.WriteLine("First thread finished.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            finally
            {
                event1.Set();
            }
        }

        static void ThreadProc2(object state)
        {
            ManualResetEvent event2 = (ManualResetEvent)state;

            try
            {
                ImageToVideo converter = new ImageToVideo();
                converter.RegistrationName = "demo";
                converter.RegistrationKey = "demo";

                Array x = Enum.GetValues(typeof(PanZoomEffectType));

                foreach (string file in Directory.GetFiles(@".\images"))
                {
                    Slide slide = converter.AddImageFromFileName(file);
                    slide.Duration = 3000;
                    slide.PanZoomEffect = (PanZoomEffectType)x.GetValue((new Random()).Next(8));
                    slide.InEffect = TransitionEffectType.teFade;
                    slide.InEffectDuration = 250;
                    slide.OutEffect = TransitionEffectType.teFade;
                    slide.OutEffectDuration = 250;
                }

                converter.OutputVideoFileName = "result2.wmv";
                converter.OutputWidth = 640;
                converter.OutputHeight = 480;
                converter.RunAndWait();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

                Console.WriteLine("Second thread finished.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            finally
            {
                event2.Set();
            }
        }
    }

}
