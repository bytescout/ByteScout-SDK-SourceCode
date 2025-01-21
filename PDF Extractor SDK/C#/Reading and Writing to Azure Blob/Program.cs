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
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Bytescout.PDFExtractor;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Please note: Streams can be read/write to azure blobs, so in this example,
             we're demonstrating how to read pdf from stream, convert to csv, 
             and write to csv stream
             */

            // Create Bytescout.PDFExtractor.CSVExtractor instance
            CSVExtractor extractor = new CSVExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Get input stream
            var inputStream = GetMemoryStream("sample3.pdf");

            // Load sample PDF document from stream
            extractor.LoadDocumentFromStream(inputStream);

            // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
            //extractor.CSVSeparatorSymbol = ",";

            // Save extracted CSV data to output stream
            var outputStream = new MemoryStream();
            extractor.SaveCSVToStream(outputStream);

            // Save output stream to file, so we can take a look
            WriteStreamToFile(outputStream, "output.csv");

            // Cleanup
            extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Data has been extracted to 'output.csv' file.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...");
            Console.ReadKey();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("output.csv");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        /// <summary>
        /// Get memory stream from file
        /// </summary>
        public static Stream GetMemoryStream(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }

        /// <summary>
        /// Write stream to file
        /// </summary>
        public static void WriteStreamToFile(Stream stream, string fileName)
        {
            using (var fileStream = File.Create(fileName))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fileStream);
            }
        }

    }
}
