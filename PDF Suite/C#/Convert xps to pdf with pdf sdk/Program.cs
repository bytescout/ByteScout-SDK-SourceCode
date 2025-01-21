//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;

using System.Drawing.Imaging;
using System.IO;

using Bytescout.PDF;
using Image = Bytescout.PDF.Image;

using xps2img;

namespace Images
{
    /// <summary>
    /// This example demonstrates converting xps document to pdf
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            //Create instance and load file
            Xps2Image xps2Image = new Xps2Image("Sample.xps");

            // Set parameter
            Parameters oParam = new Parameters();
            oParam.Dpi = 300; // Set Dpi
            oParam.ImageType = ImageType.Png; // Output image type

            // Get Bitmap from input file
            var outBitmapList = xps2Image.ToBitmap(oParam);

            foreach (var itmBitmap in outBitmapList)
            {
                // Create new pdf page
                Page page = new Page(PaperFormat.A4);

                // Save image to a bytestream
                MemoryStream byteStream = new MemoryStream();
                itmBitmap.Save(byteStream, ImageFormat.Png);

                // Fill page with image
                Image pageImage = new Image(byteStream);
                page.Canvas.DrawImage(pageImage, 5, 5, pageImage.Width / 2, pageImage.Height/3);

                // Add pdf page to pdf document
                pdfDocument.Pages.Add(page);
            }

            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
