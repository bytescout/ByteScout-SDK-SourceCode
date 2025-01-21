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
using ByteScout.TextRecognition;

namespace TextRecognitionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = @".\areas-sample.pdf";
            int pageIndex = 0;
            string outputDocument = @".\result.txt";
            
            // Create and activate TextRecognizer instance
            using (TextRecognizer textRecognizer = new TextRecognizer("demo", "demo"))
            {
                try
                {
                    // Load document (image or PDF)
                    textRecognizer.LoadDocument(inputDocument);

                    // Set the location of OCR language data files
                    textRecognizer.OCRLanguageDataFolder = @"c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\";

                    // Set OCR language.
                    // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
                    // Find more language files at https://github.com/bytescout/ocrdata
                    textRecognizer.OCRLanguage = "eng"; 
                                        
                    // Get page size (in pixels). Size of PDF document is computed from PDF Points 
                    // and the rendering resolution specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
                    Size pageSize = textRecognizer.GetPageSize(pageIndex);
                    
                    // Add area of interest as a rectangle at the top-right corner of the page
                    textRecognizer.RecognitionAreas.Add(pageSize.Width / 2, 0, pageSize.Width / 2, 300);
                    // Add area of interest as a rectangle at the bottom-left corner of the page,
                    // and indicate it should be rotated at 90 deg
                    textRecognizer.RecognitionAreas.Add(0, pageSize.Height / 2, 300, pageSize.Height / 2, AreaRotation.Rotate90FlipNone);

                    // Now, you can get recognized text for further analysis as a list of objects 
                    // containing coordinates, object kind, confidence.
                    OCRObjectList ocrObjectList = textRecognizer.GetOCRObjects(pageIndex);
                    foreach (OCRObject ocrObject in ocrObjectList)
                        Console.WriteLine(ocrObject.ToString());

                    // ... or you can save recognized text pieces to file
                    textRecognizer.KeepTextFormatting = false; // save without formatting
                    textRecognizer.SaveText(outputDocument, pageIndex, pageIndex);


                    // Open the result file in default associated application (for demo purposes)
                    Process.Start(outputDocument);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
