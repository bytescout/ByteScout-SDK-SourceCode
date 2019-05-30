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
using Bytescout.PDFExtractor;

namespace Parallel_Processing
{
    class Program
    {
        // Limit to 4 threads in queue.
        // Set this value to number of your processor cores for max performance.
        private static readonly Semaphore ThreadLimiter = new Semaphore(4, 4);

        static void Main(string[] args)
        {
            // Get all PDF files in a folder
            string[] files = Directory.GetFiles(@"..\..\..\..\", "*.pdf");
            // Array of events to wait
            ManualResetEvent[] doneEvents = new ManualResetEvent[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                // Wait for the queue
                ThreadLimiter.WaitOne();

                // Start thread with filename and event in params
                doneEvents[i] = new ManualResetEvent(false);
                object[] threadData = new object[] { files[i], doneEvents[i] };
                ThreadPool.QueueUserWorkItem(ConvertPdfToTxt, threadData);
            }

            // Wait until all threads finish
            WaitHandle.WaitAll(doneEvents);

            Console.WriteLine();
            Console.WriteLine("All is done.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ConvertPdfToTxt(object state)
        {
            // Get filename and event from params
            string file = (string) ((object[]) state)[0];
            ManualResetEvent doneEvent = (ManualResetEvent)((object[])state)[1];

            string resultFileName = Path.GetFileName(file) + ".txt";

            try
            {
                Console.WriteLine("Converting " + file);

                using (TextExtractor extractor = new TextExtractor("demo", "demo"))
                {
                    extractor.LoadDocumentFromFile(file);
                    extractor.SaveTextToFile(resultFileName);
                }

                Console.WriteLine("Finished " + resultFileName);
            }
            finally
            {
                // Signal the thread is finished
                doneEvent.Set();
                // Release semaphore
                ThreadLimiter.Release();
            }
        }
    }
}
