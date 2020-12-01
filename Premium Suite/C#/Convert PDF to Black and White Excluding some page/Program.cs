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

            // Enable Black and White Mode
            unsearchablePDFMaker.Grayscale = true;

            // Enable skipping black and white conversation of pages in range
            unsearchablePDFMaker.KeepSkippedPages = true;

            // "ranges" param is comma-separated list of page ranges in form "1-4,5,7,8-15,16-". 
            // Pages covered by it will be converted to Black and White.
            // Page numbers are 1-based. Ending "-" means "to the last page".
            // You can also use inverted page numbers adding '!' before the number. E.g. "!1" means "the last page", 
            // "2-!2" means "from the second to the penultimate page", "!2-" - last two pages
            unsearchablePDFMaker.MakePDFUnsearchable("result.pdf", ranges: "1");

            // Cleanup
            unsearchablePDFMaker.Dispose();

            // Open the result PDF file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
