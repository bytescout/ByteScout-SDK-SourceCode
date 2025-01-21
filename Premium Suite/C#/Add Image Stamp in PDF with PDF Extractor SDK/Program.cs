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
using System.Drawing;
using Bytescout.PDFExtractor;

namespace AddImageStampInPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @".\Invoice.pdf";
            string outputFile = @".\Invoice_Stamped.pdf";
            string stampImageFile = @".\stamp_image.png";

            using (Stamper stamper = new Stamper("demo", "demo"))
            {
                // Optionally make the image background transparent
                // stamper.MakeStampImageTransparent = true;

                using (Image image = Image.FromFile(stampImageFile))
                {
                    // Get image size in PDF units
                    SizeF imageSizeInPoints = stamper.GetImageSizeInPoints(image);

                    RectangleF rectangle = new RectangleF(440, 370, imageSizeInPoints.Width / 3, imageSizeInPoints.Height / 3);

                    stamper.Stamp(inputFile, outputFile, image, rectangle, 0, -1);
                }
            }

            // Open first output file in default associated application (for demo purposes)
            ProcessStartInfo processStartInfo = new ProcessStartInfo(outputFile);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
