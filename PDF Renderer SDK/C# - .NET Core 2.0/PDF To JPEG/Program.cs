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

namespace PdfToJpeg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document
            renderer.LoadDocumentFromFile(@".\multipage.pdf");

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Render document page to JPEG image file.
                renderer.Save("image" + i + ".jpg", RasterImageFormat.JPEG, i, 96);
            }

            // Cleanup
            renderer.Dispose();

            // Open the first output file in default image viewer.
            Process.Start(new ProcessStartInfo("image0.jpg") { UseShellExecute = true });
        }        
    }
}
