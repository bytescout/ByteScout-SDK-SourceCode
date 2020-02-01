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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace CheckForSensitiveAndPIIDataFromPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover2 instance
            Remover2 remover = new Remover2("demo", "demo");

            // Mask removed text, which ultimately black out region
            remover.MaskRemovedText = true;

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"samplePDF_EmailSSN.pdf");

            // Prepare TextExtractor
            using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
            {
                // Load document into TextExtractor
                textExtractor.LoadDocumentFromFile(@"samplePDF_EmailSSN.pdf");

                // Enable RegexSearch
                textExtractor.RegexSearch = true;

                // Set word matching options
                textExtractor.WordMatchingMode = WordMatchingMode.None;

                // Search SSN in format 202-55-0130
                string regexPatternSSN = "[0-9]{3}-[0-9]{2}-[0-9]{4}";

                // Search email Addresses
                string regexPatternEmail = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}\b";

                // Search results for SSN
                ISearchResult[] searchResultsSSN = textExtractor.FindAll(0, regexPatternSSN, caseSensitive: false);

                // Search results for Email
                ISearchResult[] searchResultEmail = textExtractor.FindAll(0, regexPatternEmail, caseSensitive: false);

                // Remove SSN result text objects find by SearchResults.
                remover.AddTextToRemove(searchResultsSSN);

                // Remove Email result text objects find by SearchResults.
                remover.AddTextToRemove(searchResultEmail);

                // Perform removal of specified objects
                remover.PerformRemoval(@"result1.pdf");
            }

            // Open output file in default application
            System.Diagnostics.Process.Start("result1.pdf");

            // Clean up.
            remover.Dispose();
        }
    }
}
