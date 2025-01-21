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
using Bytescout.PDFExtractor;

namespace RemoveSensitiveTextUsingRegexExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover instance
            Remover remover = new Remover("demo", "demo");

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"samplePDF_EmailAddress.pdf");

            // Prepare TextExtractor
            using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
            {
                // Load document into TextExtractor
                textExtractor.LoadDocumentFromFile(@"samplePDF_EmailAddress.pdf");

                // Search email Addresses
                // See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx
                string regexPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b";

                // Enable RegexSearch
                textExtractor.RegexSearch = true;

                // Set word matching options
                textExtractor.WordMatchingMode = WordMatchingMode.None;

                ISearchResult[] searchResults = textExtractor.FindAll(0, regexPattern, caseSensitive: false);

                // Remove text objects find by SearchResults.
                // NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
                // to split PDF text objects.
                remover.RemoveText(searchResults, @"result1.pdf");
            }

            // Open output file in default application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result1.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);

            // Clean up.
            remover.Dispose();
        }
    }
}
