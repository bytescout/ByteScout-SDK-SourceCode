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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing.Imaging;
using Bytescout.PDFExtractor;
using Bytescout.PDF;
using System.Diagnostics;

namespace ReadPDFWithImageHindiText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Files
                string fileName = "hindi_text_with_image.pdf";
                string destFileName = "output_hindi_text_with_image.pdf";
                string destFileName_serachable = "output_hindi_text_with_image_searchable.pdf";

                // Read all text from pdf file
                string allTextExtracted = "";
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    // Read all text directly
                    allTextExtracted = extractor.GetText();
                }

                // Get image from pdf file
                MemoryStream memoryStream = new MemoryStream();
                using (ImageExtractor extractor = new ImageExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    if (extractor.GetFirstImage())
                    {
                        extractor.SaveCurrentImageToStream(memoryStream, ImageFormat.Png);
                    }
                }

                // Load image from file to System.Drawing.Image object (we need it to get the image resolution)
                using (System.Drawing.Image sysImage = System.Drawing.Image.FromStream(memoryStream))
                {
                    // Compute image size in PDF units (Points)
                    float widthInPoints = sysImage.Width / sysImage.HorizontalResolution * 72f;
                    float heightInPoints = sysImage.Height / sysImage.VerticalResolution * 72f;

                    // Create new PDF document
                    using (Document outPdfDocument = new Document())
                    {
                        outPdfDocument.RegistrationName = "demo";
                        outPdfDocument.RegistrationKey = "demo";

                        // Create page of computed size
                        Page page = new Page(widthInPoints, heightInPoints);

                        // Add page to the document
                        outPdfDocument.Pages.Add(page);

                        Canvas canvas = page.Canvas;

                        // Create Bytescout.PDF.Image object from loaded image
                        Image pdfImage = new Image(sysImage);

                        // Draw the image
                        canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints);

                        // Dispose the System.Drawing.Image object to free resources
                        sysImage.Dispose();

                        // Create brush
                        SolidBrush transparentBrush = new SolidBrush(new ColorGray(0));

                        // ... and make it transparent
                        transparentBrush.Opacity = 0;

                        // Draw text with transparent brush
                        // Need to set Font which supports hindi characters.
                        Font font16 = new Font("Arial Unicode MS", 16);
                        canvas.DrawString(allTextExtracted, font16, transparentBrush, 40, 40);

                        // Save document to file
                        outPdfDocument.Save(destFileName);
                    }
                }


                // Make PDF file with hindi text searchable to OCR.
                using (SearchablePDFMaker searchablePDFMaker = new SearchablePDFMaker())
                {
                    //Load PDF document
                    searchablePDFMaker.LoadDocumentFromFile(destFileName);

                    // Set the location of "tessdata" folder containing language data files
                    /*
                     * It used following files for hindi language support. Need to put these files into "testdata" folder. Below location contains these files.
                     * https://github.com/tesseract-ocr/tessdata/tree/3.04.00 
                     hin.traineddata
                     hin.cube.bigrams
                     hin.cube.lm
                     hin.cube.nn
                     hin.cube.params
                     hin.cube.word-freq
                     hin.tesseract_cube.nn
                     */
                    searchablePDFMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\";

                    // Set OCR language
                    searchablePDFMaker.OCRLanguage = "hin";

                    // Need to set Font which supports hindi characters
                    searchablePDFMaker.LabelingFont = "Arial Unicode MS";

                    // Set PDF document rendering resolution
                    searchablePDFMaker.OCRResolution = 300;

                    searchablePDFMaker.MakePDFSearchable(destFileName_serachable);
                }

                // Open document in default PDF viewer app
                Process.Start(destFileName_serachable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR:" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
