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
using System.Diagnostics;
using Bytescout.PDFRenderer;

namespace PdfTo1BitBmp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document.
            renderer.LoadDocumentFromFile("multipage.pdf");

            RenderingOptions renderingOptions = new RenderingOptions();
            // Set pixel format to 1-bit
            renderingOptions.ImageBitsPerPixel = ImageBitsPerPixel.BPP1;

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Save 1-bit image to file
                renderer.Save("image" + i + ".bmp", RasterImageFormat.BMP, i, 200, renderingOptions);
            }

            // Cleanup
            renderer.Dispose();

            // Open the first output image in default image viewer.
            Process.Start(new ProcessStartInfo("image0.bmp") { UseShellExecute = true });
        }        
    }
}
