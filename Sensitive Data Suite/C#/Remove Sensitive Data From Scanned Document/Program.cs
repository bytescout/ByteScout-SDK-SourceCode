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
using System.Drawing;
using System.IO;
using Bytescout.PDFExtractor;

namespace RemoveSensitiveDataFromScannedDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream searchablePDFStream = new MemoryStream();

            // STEP-1: Make Searchable PDF
            // STEP-2: Get search text result from that searchable PDF
            // STEP-3: Remove sensitive data

            // Create Bytescout.PDFExtractor.SearchablePDFMaker instance
            using (var searchablePDFMaker = new SearchablePDFMaker("demo","demo"))
            {
                // Load sample PDF document
                searchablePDFMaker.LoadDocumentFromFile("sampleScannedPDF_EmailAddress.pdf");

                // Set the location of language data files
                searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                // Set OCR language
                searchablePDFMaker.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder

                // Set PDF document rendering resolution
                searchablePDFMaker.OCRResolution = 300;

                // Save extracted text to file
                searchablePDFMaker.MakePDFSearchable(searchablePDFStream);

                // Prepare TextExtractor
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Load stream into TextExtractor
                    textExtractor.LoadDocumentFromStream(searchablePDFStream);

                    // Search email Addresses
                    // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                    string regexPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b";

                    // Enable RegexSearch
                    textExtractor.RegexSearch = true;

                    // Set word matching options
                    textExtractor.WordMatchingMode = WordMatchingMode.None;

                    ISearchResult[] searchResults = textExtractor.FindAll(0, regexPattern, caseSensitive: false);

                    // Create Bytescout.PDFExtractor.Remover instance
                    using (var remover = new Remover2("demo","demo"))
                    {
                        // Load sample PDF document
                        remover.LoadDocumentFromStream(searchablePDFStream);

                        // Mask removed text
                        remover.MaskRemovedText = true;

                        // Make output file unsearchable
                        remover.MakePDFUnsearchable = true;

                        // Provide text to remove
                        remover.AddTextToRemove(searchResults);

                        // Remove text objects find by SearchResults.
                        remover.PerformRemoval("result1.pdf");

                    }

                 }

            }

            // Open output file in default application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result1.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
