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
using System.Drawing;
using System.IO;
using Bytescout.PDF;
using Bytescout.PDFExtractor;
using Bytescout.PDFRenderer;
using Image = System.Drawing.Image;
using Path = System.IO.Path;

namespace SlicePdfByLinesExample
{
    /// <summary>
    /// The example demonstrates slicing of PDF document pages by horizontal lines.
    /// The example uses three products:
    /// - PDF Extractor SDK (https://bytescout.com/products/developer/pdfextractorsdk/index.html) -
    ///     to detect lines;
    /// - PDF Renderer SDK (https://bytescout.com/products/developer/pdfrenderersdk/index.html) -
    ///     to render PDF documents to raster images;
    /// - PDF SDK (https://bytescout.com/products/developer/pdfsdk/index.html) -
    ///     to create new PDF documentsd from sliced images.
    /// </summary>
    class Program
    {
        static string InputFile = @".\sample.pdf";
        static string OutputFolder = @".\output";

        static void Main(string[] args)
        {
            if (!Directory.Exists(OutputFolder))
                Directory.CreateDirectory(OutputFolder);

            // Create LineDetector instance and load document
            LineDetector lineDetector = new LineDetector("demo", "demo");
            lineDetector.LoadDocumentFromFile(InputFile);

            // Create RasterRenderer instance and load document
            RasterRenderer rasterRenderer = new RasterRenderer("demo", "demo");
            rasterRenderer.LoadDocumentFromFile(InputFile);
            
            try
            {
                int pageCount = lineDetector.GetPageCount();

                for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
                {
                    Console.WriteLine("Processing page #{0}", pageIndex);

                    // Find horizontal lines on the page
                    FoundLinesCollection horzLines = lineDetector.FindLines(pageIndex, LineOrientationsToFind.OnlyHorizontal);
                    // Slice page by separating lines and create new PDF documents
                    Slice(pageIndex, horzLines, rasterRenderer);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                // Cleanup
                rasterRenderer.Dispose();
                lineDetector.Dispose();
            }


            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static void Slice(int pageIndex, FoundLinesCollection lines, RasterRenderer rasterRenderer)
        {
            const float pdfRenderingResolution = 300;
            float lastLineY = float.NaN;
            int sliceNum = 0;

            RectangleF pageRect = rasterRenderer.GetPageRectangle(pageIndex);

            foreach (FoundLine line in lines)
            {
                if (float.IsNaN(lastLineY))
                {
                    lastLineY = line.From.Y;
                }
                else
                {
                    // Compute slice rectangle
                    RectangleF sliceRect = new RectangleF(0, lastLineY, pageRect.Width, line.From.Y - lastLineY);
                    // Set extraction rectangle for RasterRenderer
                    rasterRenderer.SetExtractionArea(sliceRect);
                    // Render the page region to Image object
                    Image slice = rasterRenderer.GetImage(pageIndex, pdfRenderingResolution);

                    // Create PDF document
                    Document document = new Document
                    {
                        RegistrationName = "demo",
                        RegistrationKey = "demo"
                    };

                    // Create page of A4 size
                    Page page = new Page(PaperFormat.A4);
                    document.Pages.Add(page);

                    // Create PDF Image object from System.Drawing.Image
                    Bytescout.PDF.Image pdfImage = new Bytescout.PDF.Image(slice);
                    // Draw image on the page keeping the aspect ratio
                    RectangleF r = new RectangleF(0, 20, page.Width, page.Width / slice.Width * slice.Height);
                    page.Canvas.DrawImage(pdfImage, r.Left, r.Top, r.Width, r.Height);

                    // Save PDF document
                    string fileName = string.Format(@"{0}\{1}-page{2}-slice{3}.pdf", OutputFolder, Path.GetFileName(InputFile), pageIndex, ++sliceNum);
                    document.Save(fileName);

                    Console.WriteLine("Saved slice '{0}'", fileName);

                    // Cleanup
                    document.Dispose();
                    slice.Dispose();

                    lastLineY = line.From.Y;
                }
            }
        }
    }
}
