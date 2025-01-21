//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System.Diagnostics;
using System.Drawing;

namespace RemoveSensitiveDataFromImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"scanned_sample_EmailSSN.png";
            string result = @"result.png";

            using (SensitiveDataDetector detector = new SensitiveDataDetector("demo", "demo"))
            {
                // Enable OCR mode and provide path to data folder
                detector.OCRMode = OCRMode.Auto;
                detector.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                detector.LoadDocumentFromFile(input);

                // Detect sensitive data
                SensitiveDataDetectionResults detectionResults = detector.PerformDetection();

                if (detectionResults.DetectedItems.Length > 0)
                {
                    using (var image = Image.FromFile(input))
                    {
                        // Create new bitmap, as graphics object require indexed pixel format
                        using (var newBitmap = new Bitmap(image.Width, image.Height))
                        {
                            using (Graphics g = Graphics.FromImage(newBitmap))
                            {
                                g.DrawImage(image, 0, 0);

                                foreach (var detectedItem in detectionResults.DetectedItems)
                                {
                                    // Convert coordinates from Points (1/72") to display pixels
                                    Rectangle rect = new Rectangle(
                                        (int)(detectedItem.Rectangle.X * 96 / 72),
                                        (int)(detectedItem.Rectangle.Y * 96 / 72),
                                        (int)(detectedItem.Rectangle.Width * 96 / 72),
                                        (int)(detectedItem.Rectangle.Height * 96 / 72));

                                    // Paint over the detected item with a white or black brush
                                    g.FillRectangle(Brushes.Black, rect);
                                }
                            }

                            newBitmap.Save(result);
                        }
                    }

                    // Open output file with attached application
                    ProcessStartInfo processStartInfo = new ProcessStartInfo(result);
                    processStartInfo.UseShellExecute = true;
                    Process.Start(processStartInfo);
                }
            }
        }
    }
}
