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

namespace MakeUnsearchablePDF
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.UnsearchablePDFMaker instance
            UnsearchablePDFMaker unsearchablePDFMaker = new UnsearchablePDFMaker();
            unsearchablePDFMaker.RegistrationName = "demo";
            unsearchablePDFMaker.RegistrationKey = "demo";

            // Load sample PDF document
            unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf");

            //maker.ImageFormat = EmbeddedImageFormat.JPEG; // use JPEG for smaller PDF file, but be ready to compression artefacts
            //maker.JPEGQuality = 75; // JPEG quality (1 - 100)
            unsearchablePDFMaker.RenderingResolution = 300; // larger resolution - longer processing and larger PDF file size

            // Enable Black and White mode
            unsearchablePDFMaker.Grayscale = true;

            // Process the document 
            unsearchablePDFMaker.MakePDFUnsearchable("result.pdf");

            // Cleanup
            unsearchablePDFMaker.Dispose();

            // Open the result PDF file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
