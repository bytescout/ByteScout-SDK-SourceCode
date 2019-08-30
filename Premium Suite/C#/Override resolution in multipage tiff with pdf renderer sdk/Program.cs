//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDFRenderer;

namespace OverrideResolutionInMultipageTiff
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFRenderer.RasterRenderer object instance and register it.
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document.
            renderer.LoadDocumentFromFile("multipage.pdf");

            int startPage = 0;
            int endPage = renderer.GetPageCount() - 1;

            // Save PDF document to black-and-white multi-page TIFF
            RenderingOptions renderingOptions = new RenderingOptions();
            renderingOptions.TIFFCompression = TIFFCompression.CCITT4;
            renderingOptions.ResolutionOverride = 300;

            // Generate 800x600 px multipage TIFF
            renderer.SaveMultipageTiff("multipage.tiff", startPage, endPage, 600, 800, renderingOptions);

            // Cleanup
            renderer.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("multipage.tiff");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
