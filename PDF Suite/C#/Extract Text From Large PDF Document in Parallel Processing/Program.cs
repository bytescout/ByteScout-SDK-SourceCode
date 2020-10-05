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
using System.Diagnostics;
using System.IO;
using System.Threading;
using Bytescout.PDFExtractor;

namespace MultithreadProcessing
{
    class Program
    {
        // Limit to 4 threads in queue.
        // Set this value to number of cores in your CPU for max performance.
        private static readonly Semaphore _threadLimiter = new Semaphore(4, 4);
        private static int _runningThreadsCounter;

        static void Main(string[] args)
        {
            const string inputFileName = "sample.pdf";
            const string resultFileName = "result.txt";
            int CHUNK_SIZE = 10;

            int pageCount;

            // Get document page count
            using (var infoExtractor = new InfoExtractor("demo", "demo"))
            {
                infoExtractor.LoadDocumentFromFile(inputFileName);
                pageCount = infoExtractor.GetPageCount();
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            int numberOfThreads = pageCount / CHUNK_SIZE;
            if (pageCount - numberOfThreads * CHUNK_SIZE > 0)
                numberOfThreads += 1;

            ManualResetEvent allFinishedEvent = new ManualResetEvent(false);
            _runningThreadsCounter = 0;
            string[] chunks = new string[numberOfThreads];

            for (int i = 0; i < numberOfThreads; i++)
            {
                // Wait for the queue
                _threadLimiter.WaitOne();

                var startPage = i * CHUNK_SIZE;
                var endPage = Math.Min(pageCount - 1, (i + 1) * CHUNK_SIZE - 1);

                // Prepare temp file name for the chunk
                chunks[i] = string.Format("temp-{0}-{1}.txt", startPage, endPage);

                // Increase the thread counter
                Interlocked.Increment(ref _runningThreadsCounter);

                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc),
                    new object[] { i, allFinishedEvent, inputFileName, chunks[i], startPage, endPage });
            }

            // Wait for all threads
            allFinishedEvent.WaitOne();

            // Merge pieces into a single text file
            using (Stream resultFileStream = File.Create(resultFileName))
            {
                foreach (string tempFile in chunks)
                    using (Stream srcStream = File.OpenRead(tempFile))
                        srcStream.CopyTo(resultFileStream);
            }

            // Delete temp files
            foreach (string tempFile in chunks)
                File.Delete(tempFile);


            Console.WriteLine("All done in {0}.", stopwatch.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ThreadProc(object stateInfo)
        {
            int threadIndex = (int) ((object[]) stateInfo)[0];
            ManualResetEvent allFinishedEvent = (ManualResetEvent) ((object[]) stateInfo)[1];
            string inputFile = (string) ((object[]) stateInfo)[2];
            string outputFile = (string) ((object[]) stateInfo)[3];
            int startPage = (int) ((object[]) stateInfo)[4];
            int endPage = (int) ((object[]) stateInfo)[5];

            try
            {
                Console.WriteLine("Thread #{0} started with the page range from {1} to {2}.", threadIndex, startPage, endPage);

                Stopwatch stopwatch = Stopwatch.StartNew();

                // Process the piece
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Set page separator. Default is '\f' (Form Feed)
                    textExtractor.PageSeparator = Environment.NewLine;
                    // Since we are only extracting text, disable the caching to reduce memory usage
                    textExtractor.PageDataCaching = PageDataCaching.None;

                    textExtractor.OCRMode = OCRMode.Auto;
                    textExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";
                    textExtractor.OCRLanguage = "eng";
                    // 300 DPI resolution is recommended. 
                    // Using of higher values will slow down the processing but does not guarantee the higher quality.
                    textExtractor.OCRResolution = 300;

                    textExtractor.LoadDocumentFromFile(inputFile);

                    textExtractor.SaveTextToFile(startPage, endPage, outputFile);
                }

                Console.WriteLine("Thread #{0} finished in {1}.", threadIndex, stopwatch.Elapsed);
            }
            finally
            {
                // If it was the last thread, signal the main thread about the finish.
                if (Interlocked.Decrement(ref _runningThreadsCounter) == 0)
                    allFinishedEvent.Set();

                // Release semaphore
                _threadLimiter.Release();
            }
        }
    }
}
