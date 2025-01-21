//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDF;
using System.Diagnostics;
using System.Drawing;
using Brush = Bytescout.PDF.Brush;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;


namespace DrawHeaderAndFooterOnRotatedPage
{
    /// <summary>
    /// This example demonstrates how to add header and footer to rotated PDF pages.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Load document
            Document pdfDocument = new Document(@".\RotatedPages.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // If you wish to load an existing document uncomment the line below and comment the Add page section instead
            // pdfDocument.Load(@".\existing_document.pdf");

            string headerText = "Sample Header";
            string footerText = "Sample Footer";

            // Prepare StringFormat with Center text alignment
            StringFormat stringFormat = new StringFormat { HorizontalAlign = HorizontalAlign.Center };
            // Prepare drawing tools
            Font font = new Font(StandardFonts.Helvetica, 9);
            Brush brush = new SolidBrush(new ColorRGB(255, 0, 0));
            
            for (int i = 0; i < pdfDocument.Pages.Count; ++i)
            {
                Page page = pdfDocument.Pages[i];
                
                page.Canvas.SaveGraphicsState();

                // Calculate the coordinates of the text taking into account the page rotation:

                float headerY = 10;
                float footerY;
                float textRectWidth;
                float textRectHeight = font.GetTextHeight() + 5;

                if (page.RotationAngle == RotationAngle.Rotate0 || page.RotationAngle == RotationAngle.Rotate180)
                {
                    footerY = page.Height - textRectHeight - 10;
                    textRectWidth = page.Width;
                }
                else
                {
                    footerY = page.Width - textRectHeight - 10;
                    textRectWidth = page.Height;
                }

                // Rotate page canvas according to page rotation
                switch (page.RotationAngle)
                {
                    case RotationAngle.Rotate90:
                        page.Canvas.RotateTransform(-90);
                        page.Canvas.TranslateTransform(-page.Height, 0);
                        break;
                    case RotationAngle.Rotate180:
                        page.Canvas.RotateTransform(180);
                        page.Canvas.TranslateTransform(-page.Width, -page.Height);
                        break;
                    case RotationAngle.Rotate270:
                        page.Canvas.RotateTransform(-270);
                        page.Canvas.TranslateTransform(0, -page.Width);
                        break;
                }
                
                // Draw header and footer
                page.Canvas.DrawString(headerText, font, brush, new RectangleF(0, headerY, textRectWidth, textRectHeight), stringFormat);
                page.Canvas.DrawString(footerText, font, brush, new RectangleF(0, footerY, textRectWidth, textRectHeight), stringFormat);

                page.Canvas.RestoreGraphicsState();
            }
            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result PDF document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
