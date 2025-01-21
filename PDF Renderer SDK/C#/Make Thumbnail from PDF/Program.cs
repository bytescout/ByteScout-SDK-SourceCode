//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Drawing;
using System.Diagnostics;
using Bytescout.PDFRenderer;

namespace MakeThumbnail
{
    static class Program
    {
        static void Main()
        {
            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document
            renderer.LoadDocumentFromFile("multipage.pdf");

            // Get size of the page in Points (standard PDF document units; 1 Point = 1/72")
            RectangleF rectangle = renderer.GetPageRectangle(0);

            int width, height;

            if (rectangle.Width < rectangle.Height) // portrait page orientation
            {
                width = -1; // width will be calculated from height keeping the aspect ratio
                height = 100;
            }
            else // landscape page orientation
            {
                width = 100;
                height = -1; // height will be calculated from width keeping the aspect ratio
            }
            
            // Render first page of the document to JPEG image file
            renderer.Save("thumbnail.jpg", RasterImageFormat.JPEG, 0, width, height);

            // Cleanup
            renderer.Dispose();
            
            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("thumbnail.jpg");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
