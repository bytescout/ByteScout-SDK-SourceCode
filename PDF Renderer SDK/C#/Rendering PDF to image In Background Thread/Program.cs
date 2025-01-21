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
using System.IO;
using System.Threading;
using Bytescout.PDFRenderer;

namespace RenderingInBackgroundThread
{
    class Program
    {
        private static ManualResetEvent _doneEvent = new ManualResetEvent(false); // synchronization event
        private static int _counter; // thread counter

        static void Main(string[] args)
        {
            // Get all PDF files in current directory
            string[] pdfFiles = Directory.GetFiles(".", "*.pdf");
            _counter = pdfFiles.Length;

            // Render PDF files in separate threads
            foreach (string pdfFile in pdfFiles)
            {
                Thread backgroundThread = new Thread(BackgroundThreadProc);
                backgroundThread.Start(pdfFile);
                Console.WriteLine(pdfFile + " - conversion started.");
            }

            // Wait until threads finished
            _doneEvent.WaitOne();
            
            Console.WriteLine("Done.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Rendering thread function
        private static void BackgroundThreadProc(object data)
        {
            string fileName = (string) data;

            try
            {
                // Create renderer
                using (RasterRenderer renderer = new RasterRenderer())
                {
                    renderer.LoadDocumentFromFile(fileName);
                    
                    // Setup rendering
                    RenderingOptions renderingOptions = new RenderingOptions();
                    renderingOptions.JPEGQuality = 90;

                    float renderingResolution = 300;
                    
                    // Render document pages
                    for (int i = 0; i < renderer.GetPageCount(); i++)
                    {
                        renderer.Save(fileName + ".page" + i + ".jpg", RasterImageFormat.JPEG, i, renderingResolution, renderingOptions);
                    }
                }

                Console.WriteLine(fileName + " - successfully converted.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            if (Interlocked.Decrement(ref _counter) == 0)
            {
                // Set event if all threads finished
                _doneEvent.Set();
            }
        }
    }
}
