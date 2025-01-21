//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using Bytescout.PDFRenderer;

namespace RenderPartOfPdfPage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Set high quality resolution 600 dpi (600 dots per inch)
            float renderingResolution = 600;

            // Load PDF document.
            renderer.LoadDocumentFromFile("sample_table.pdf");

            // Set extraction area
            renderer.SetExtractionArea(205.5f, 108.75f, 331.5f, 121.5f);

            // Render part of document to PNG image file.
            renderer.Save($"result_{renderingResolution}.png", RasterImageFormat.PNG, 0, renderingResolution);

            // Cleanup
            renderer.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo($"result_{renderingResolution}.png");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
