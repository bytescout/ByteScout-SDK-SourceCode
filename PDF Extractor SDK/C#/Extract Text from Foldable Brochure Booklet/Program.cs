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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace ExtractTextFromFoldableBrochure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set extraction regions
            // Use Bytescout Template Editor / Bytescout PDF Multitool or other tool to know region co-ordinates
            var lstExtractionRegion = new List<RectangleF>();
            lstExtractionRegion.Add(new RectangleF(7.5f, 33.8f, 244.5f, 353.3f));
            lstExtractionRegion.Add(new RectangleF(273.8f, 201.8f, 247.5f, 198.0f));
            lstExtractionRegion.Add(new RectangleF(537.8f, 27.0f, 246.0f, 268.5f));

            // Ouput File
            var resFile = "result.txt";
            var sRes = new StringBuilder(string.Empty);

            // Create Bytescout.PDFExtractor.TextExtractor instance
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(@".\SampleFoldable.pdf");

            // Loop through all extraction regions, and extract text
            foreach (var oRegion in lstExtractionRegion)
            {
                var extractedText = GetTextFromRegion(extractor, oRegion);
                sRes.AppendLine(extractedText);
            }

            // Cleanup
            extractor.Dispose();

            // Write all reslut to output file
            File.WriteAllText(resFile, sRes.ToString());

            // Open result file in default associated application
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@".\result.txt");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }

        /// <summary>
        /// Get text from particular region
        /// </summary>
        private static string GetTextFromRegion(TextExtractor textExtractor, RectangleF extractionRegion, int pageIndex = 0)
        {
            // Set Extraction Area
            textExtractor.SetExtractionArea(extractionRegion);

            // Get Text from that region
            return textExtractor.GetTextFromPage(pageIndex);
        }
    }
}
