//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;
using System.Collections.Generic;
using System.IO;

namespace IndexDocsInFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Output file list
                var lstAllFilesInfo = new List<FileIndexOutput>();

                // Get all files inside directory
                var allFiles = Directory.GetFiles(@".\Files", "*.*");

                // Iterate all files, and get details
                foreach (var itmFile in allFiles)
                {
                    // Get basic file information
                    FileInfo fileInfo = new FileInfo(itmFile);

                    // Check whether file is supported
                    if (_IsFileSupported(fileInfo))
                    {
                        // Fill file index model
                        var oFileIndex = new FileIndexOutput();
                        oFileIndex.fileName = fileInfo.Name;
                        oFileIndex.fileDate = fileInfo.CreationTime;
                        oFileIndex.content = _GetFileContent(fileInfo);

                        // Add to final list
                        lstAllFilesInfo.Add(oFileIndex);
                    }
                }

                // Print all output
                Console.WriteLine("Total {0} files indexed\n", lstAllFilesInfo.Count);
                foreach (var itmFileInfo in lstAllFilesInfo)
                {
                    Console.WriteLine("fileName: {0}", itmFileInfo.fileName);
                    Console.WriteLine("fileDate: {0}", itmFileInfo.fileDate.ToString("MMM dd yyyy hh:mm:ss"));
                    Console.WriteLine("content: {0}", itmFileInfo.content.Trim());
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get File Content
        /// </summary>
        private static string _GetFileContent(FileInfo fileInfo)
        {
            string fileExtension = System.IO.Path.GetExtension(fileInfo.FullName);

            if (fileExtension == ".pdf")
            {
                return _GetPdfFileContent(fileInfo);
            }
            else if (fileExtension == ".png" || fileExtension == ".jpg")
            {
                return _GetImageContet(fileInfo);
            }

            throw new Exception("File not supported.");
        }

        /// <summary>
        /// Get PDF File Content
        /// </summary>
        private static string _GetPdfFileContent(FileInfo fileInfo)
        {
            //Read all file content...
            using (TextExtractor textExtractor = new TextExtractor("demo","demo"))
            {
                //Load Document
                textExtractor.LoadDocumentFromFile(fileInfo.FullName);

                return textExtractor.GetText();
            }
        }

        /// <summary>
        /// Get Image Contents
        /// </summary>
        private static string _GetImageContet(FileInfo fileInfo)
        {
            //Read all file content...
            using (TextExtractor extractor = new TextExtractor())
            {
                // Load document
                extractor.LoadDocumentFromFile(fileInfo.FullName);

                //Set option to repair text
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts;

                // Enable Optical Character Recognition (OCR)
                // in .Auto mode (SDK automatically checks if needs to use OCR or not)
                extractor.OCRMode = OCRMode.Auto;

                // Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                // Set OCR language
                extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                // Find more language files at https://github.com/bytescout/ocrdata

                // Set PDF document rendering resolution
                extractor.OCRResolution = 300;

                // Read all text
                return extractor.GetText();
            }
        }

        /// <summary>
        /// Check whether file is valid
        /// </summary>
        private static bool _IsFileSupported(FileInfo fileInfo)
        {
            //Get File Extension
            string fileExtension = Path.GetExtension(fileInfo.Name);

            //Check whether file extension is valid
            return (fileExtension == ".pdf" || fileExtension == ".png" || fileExtension == ".jpg");
        }

    }

    /// <summary>
    /// FileIndexOutput class
    /// </summary>
    public class FileIndexOutput
    {
        public string fileName { get; set; }

        public DateTime fileDate { get; set; }

        public string content { get; set; }
    }

}
