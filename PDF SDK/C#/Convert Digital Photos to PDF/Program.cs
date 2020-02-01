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
using Bytescout.PDF;
using Image = Bytescout.PDF.Image;

namespace Images
{
    /// <summary>
    /// This example demonstrates how to add images in their proper orientation and size
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Input image array
            var arrImages = new string[]{ "Image1.jpg", "Image2.jpg" };

            // Process each image
            foreach (var itmImage in arrImages)
            {
                var sysImage = FixImageOrientation(itmImage);

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

            // Save PDF document
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
        static System.Drawing.Image FixImageOrientation(string fileName)
        {
            System.Drawing.Image sysImage = System.Drawing.Image.FromFile(fileName, false);

            // fix orientation by EXIF rotation tag
            const int exifRotationTag = 0x0112;
            int[] propertyItemIDs = sysImage.PropertyIdList;

            int found = Array.BinarySearch(propertyItemIDs, 0, propertyItemIDs.Length, exifRotationTag);

            if (found > -1)
            {
                System.Drawing.Imaging.PropertyItem pi = sysImage.GetPropertyItem(exifRotationTag);
                int orientation = pi.Value[0];

                switch (orientation)
                {
                    case 2:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
                        break;
                    case 3:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
                        break;
                    case 4:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY);
                        break;
                    case 5:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipX);
                        break;
                    case 6:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipX);
                        break;
                    case 8:
                        sysImage.RotateFlip(System.Drawing.RotateFlipType.Rotate270FlipNone);
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
