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
using System.Text;
using ByteScout.InvoiceParser;

namespace ParseFolderToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFolder = @".\invoices";
            string outputFile = @".\result.csv";

            // Create InvoiceParser instance
            using (InvoiceParser parser = new InvoiceParser("demo", "demo"))
            {
                // Setup CSV output
                CSVOptions csvOptions = new CSVOptions
                {
                    Encoding = Encoding.UTF8,
                    SeparatorCharacter = ",",
                    QuotationCharacter = "\"",
                    UnwrapMultilineValues = true
                };

                // Parse all document in input folder and save results to CSV file
                BatchProcessing.ParseFolderToCSV(parser, inputFolder, outputFile, csvOptions, ProcessingCallback);
            }

            // Open generated CSV file in default associated application (for demo purpose)
            Process.Start(outputFile);
        }

        /// <summary>
        /// Callback method to display progress and interrupt processing if needed. 
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="parsingResult">Parsing result.</param>
        /// <param name="progress">Current progress in percents.</param>
        /// <param name="innerException">Exception information in case of error.</param>
        /// <param name="cancel">Set to <c>true</c> to interrupt the batch processing.</param>
        static void ProcessingCallback(string fileName, bool parsingResult, double progress, Exception innerException, ref bool cancel)
        {
            Console.WriteLine($"{progress}% Processed file \"{fileName}\"");
            Console.WriteLine($"  Result: {parsingResult}");
            if (!parsingResult)
            {
                if (innerException != null)
                    Console.WriteLine(innerException.ToString());

                Console.Write("Continue processing? (y/n): ");
                int key = Console.Read();
                if (key == 'n')
                {
                    Console.WriteLine("Interrupted.");
                    cancel = true;
                }
            }
        }
    }
}
