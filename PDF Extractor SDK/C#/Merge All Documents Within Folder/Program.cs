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
using Bytescout.PDFExtractor;

namespace MergeAllDocumentsWithinFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            var SourceFolder = "PDFDocs";
            var DestinationFile = "result.pdf";
            var IncludeSubFolder = true;

            using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
            {
                merger.MergeFolder(SourceFolder, DestinationFile, IncludeSubFolder);
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo(DestinationFile);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
