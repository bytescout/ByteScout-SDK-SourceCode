//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using Bytescout.PDFExtractor;

namespace CompareDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load first document
            TextExtractor document1 = new TextExtractor();
            document1.RegistrationName = "demo";
            document1.RegistrationKey = "demo";
            document1.LoadDocumentFromFile(@".\comparison1.pdf");

            // Load second  document
            TextExtractor document2 = new TextExtractor();
            document2.RegistrationName = "demo";
            document2.RegistrationKey = "demo";
            document2.LoadDocumentFromFile(@".\comparison2.pdf");

            // Compare documents
            TextComparer comparer = new TextComparer();
            comparer.RegistrationName = "demo";
            comparer.RegistrationKey = "demo";
            comparer.Compare(document1, document2);

            // Generate report
            comparer.GenerateHtmlReport(@".\report.html");

            document1.Dispose();
            document2.Dispose();

            // Open the report in default browser
            System.Diagnostics.Process.Start(@".\report.html");
        }
    }
}
