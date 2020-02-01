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
using System.Diagnostics;
using System.IO;
using Bytescout.PDFRenderer;


namespace PDF2JPEG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Input file Url
            var inputUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf";

            // Get Input Stream
            var inpStream = GetStreamFromUrl(inputUrl);

            // Load PDF document from stream
            renderer.LoadDocumentFromStream(inpStream);

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Render document page to PNG image file.
                renderer.Save("image" + i + ".jpg", RasterImageFormat.JPEG, i, 96);
            }

            // Cleanup
            renderer.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("image0.jpg");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        /// <summary>
        /// Get stream from Url
        /// </summary>
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] oData = null;

            using (var wc = new System.Net.WebClient())
                oData = wc.DownloadData(url);

            return new MemoryStream(oData);
        }

    }
}
