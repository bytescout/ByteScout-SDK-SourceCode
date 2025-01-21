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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using Bytescout.PDF;
using Image = Bytescout.PDF.Image;

namespace Images
{
    /// <summary>
    /// This example demonstrates how to create PDF from multipage TIFF image. 
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Get Tiff file in Bitmap
            Bitmap multipageTiffImage = (Bitmap)System.Drawing.Image.FromFile("MultipageTiffFile.tiff");

            // Tiff images can contain multiple images named as frame
            int count = multipageTiffImage.GetFrameCount(FrameDimension.Page);
            for (int idx = 0; idx < count; idx++)
            {
                // save each frame to a bytestream
                multipageTiffImage.SelectActiveFrame(FrameDimension.Page, idx);
                MemoryStream byteStream = new MemoryStream();
                multipageTiffImage.Save(byteStream, ImageFormat.Tiff);

                // Fix Image Orientation
                var sysImage = FixImageOrientation(byteStream);

                using (sysImage)
                {
                    var image = new Image(sysImage, ImageCompression.DCT, 75);
                    float w = sysImage.Width / sysImage.HorizontalResolution * 72f;
                    float h = sysImage.Height / sysImage.VerticalResolution * 72f;

                    // Create PDF page
                    var page = new Page(w, h);

                    var canvas = page.Canvas;
                    canvas.DrawImage(image, 0, 0, w, h);

                    // Add PDF document
                    pdfDocument.Pages.Add(page);
                }

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

        /// <summary>
        /// Fix image orientation
        /// </summary>
        static System.Drawing.Image FixImageOrientation(Stream fileStream)
        {
            System.Drawing.Image sysImage = System.Drawing.Image.FromStream(fileStream, false, false);

            // fix orientation by EXIF rotation tag
            const int exifRotationTag = 0x0112;
            int[] propertyItemIDs = sysImage.PropertyIdList;

            int found = Array.BinarySearch(propertyItemIDs, 0, propertyItemIDs.Length, exifRotationTag);

            if (found > -1)
            {
                PropertyItem pi = sysImage.GetPropertyItem(exifRotationTag);
                int orientation = pi.Value[0];

                switch (orientation)
                {
                    case 2:
                        sysImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        break;
                    case 3:
                        sysImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 4:
                        sysImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        break;
                    case 5:
                        sysImage.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    case 6:
                        sysImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        sysImage.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                    case 8:
                        sysImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                    default:
                        break;
                }

                sysImage.RemovePropertyItem(0x0112);
            }

            return sysImage;
        }

    }
}
