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
using System.Diagnostics;
using System.IO;
using System.Threading;
using Bytescout.PDFExtractor;

namespace MultithreadProcessing
{
	class Program
	{
	    // Limit to 4 threads in queue.
	    // Set this value to number of your processor cores for max performance.
	    private static readonly Semaphore ThreadLimiter = new Semaphore(4, 4);

        static void Main(string[] args)
		{
			const string inputFile = "sample.pdf";
			const string resultFile = "result.pdf";

			int pageCount;

			// Get document page count
			using (var infoExtractor = new InfoExtractor("demo", "demo"))
			{
				infoExtractor.LoadDocumentFromFile(inputFile);
				pageCount = infoExtractor.GetPageCount();
			}
			
			// Process the document by 10-page pieces

			int numberOfThreads = pageCount / 10;
			if (pageCount - numberOfThreads * 10 > 0)
				numberOfThreads += 1;

			WaitHandle[] doneEvents = new WaitHandle[numberOfThreads];
			Stopwatch stopwatch = Stopwatch.StartNew();
			int startPage, endPage;
			string[] pieces = new string[numberOfThreads];

			for (int i = 0; i < numberOfThreads; i++)
			{
			    // Wait for the queue
			    ThreadLimiter.WaitOne();

                doneEvents[i] = new ManualResetEvent(false);
				startPage = i * 10;
				endPage = Math.Min(pageCount - 1, (i + 1) * 10 - 1);

				pieces[i] = string.Format("temp-{0}-{1}.pdf", startPage, endPage);
				ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc),
					new object[] { i, doneEvents[i], inputFile, pieces[i], startPage, endPage });
			}

			// Wait for all threads
			WaitHandle.WaitAll(doneEvents);

			// Merge pieces 
			using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
				merger.Merge(pieces, resultFile);

			// Delete temp files
			foreach (string tempFile in pieces)
				File.Delete(tempFile);

			Console.WriteLine("All done in {0}.", stopwatch.Elapsed);
			Console.WriteLine();

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static void ThreadProc(object stateInfo)
		{
			int threadIndex = (int) ((object[]) stateInfo)[0];
			ManualResetEvent doneEvent = (ManualResetEvent) ((object[]) stateInfo)[1];
			string inputFile = (string) ((object[]) stateInfo)[2];
			string outputFile = (string)((object[])stateInfo)[3];
			int startPage = (int)((object[])stateInfo)[4];
			int endPage = (int)((object[])stateInfo)[5];

            try
		    {
		        Console.WriteLine("Thread #{0} started with the page range from {1} to {2}.", threadIndex, startPage, endPage);

		        Stopwatch stopwatch = Stopwatch.StartNew();

		        // Extract a piece of document
		        string chunk = string.Format("temp-{0}-{1}", startPage, endPage);
		        using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
		            splitter.ExtractPageRange(inputFile, chunk, startPage + 1, endPage + 1);

		        // Process the piece
		        using (SearchablePDFMaker searchablePdfMaker = new SearchablePDFMaker("demo", "demo"))
		        {
		            searchablePdfMaker.OCRDetectPageRotation = true;
		            searchablePdfMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";
		            searchablePdfMaker.LoadDocumentFromFile(chunk);

		            // 300 DPI resolution is recommended. 
		            // Using of higher values will slow down the processing but does not guarantee the higher quality.
		            searchablePdfMaker.OCRResolution = 300;

		            searchablePdfMaker.MakePDFSearchable(outputFile);
		        }

		        File.Delete(chunk);

		        Console.WriteLine("Thread #{0} finished in {1}.", threadIndex, stopwatch.Elapsed);
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
