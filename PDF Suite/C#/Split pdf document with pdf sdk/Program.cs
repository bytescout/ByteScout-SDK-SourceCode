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


using System.Diagnostics;
using Bytescout.PDF;

namespace SplitDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open first document
            Document document1 = new Document("document1.pdf");
            document1.RegistrationName = "demo";
            document1.RegistrationKey = "demo";

            // Create result document that will contain only required pages
            Document document2 = new Document();
            document2.RegistrationName = "demo";
            document2.RegistrationKey = "demo";
            
            // Add 1st and 3rd pages of the first document to the result document
            document2.Pages.Add(document1.Pages[0]);
            document2.Pages.Add(document1.Pages[2]);

            // Save result document
            document2.Save("result.pdf");

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
