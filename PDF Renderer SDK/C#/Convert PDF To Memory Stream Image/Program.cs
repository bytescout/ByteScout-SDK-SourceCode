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


using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using Bytescout.PDFRenderer;


namespace PDF2PNG
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

            // Iterate through pages
            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Render document page and save to memory stream
                    renderer.Save(memoryStream, RasterImageFormat.PNG, i, 300);
                    
                    // Create image from memory stream
                    Image pngImg = Image.FromStream(memoryStream);
                    // Save image to file
                    pngImg.Save(i + ".png");
                }
            }

            // Cleanup
            renderer.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("0.png");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
