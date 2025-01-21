//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// This example demonstrates how to split document into seperate pages

using Bytescout.PDFExtractor;
using System;
using System.IO;
using System.Linq;

namespace SplittingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "sample.pdf";

            using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
            {
                splitter.OptimizeSplittedDocuments = true;

                //# Create list of page numbers in form "1,2,3,4,5,...,n" #
                // 1. Get Page Count
                int pageCount = splitter.GetPageCount(inputFile);
                // 2. Get all page numbers
                var pageNumbers = Enumerable.Range(1, pageCount);
                // 3. Split Range
                var splitRange = string.Join(",", pageNumbers);

                // Perform split by ranges
                string[] files = splitter.Split(inputFile, splitRange);

                Console.WriteLine(@"Splitted by parts: ");
                foreach (string file in files)
                    Console.WriteLine("    " + Path.GetFullPath(file));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();			
        }
    }
}
