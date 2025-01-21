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


namespace PDF2BMP
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

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Render first page of the document to BMP image file.
                renderer.Save("image" + i + ".bmp", RasterImageFormat.BMP, i, 300);
            }

            // Cleanup
            renderer.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("image0.bmp");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
