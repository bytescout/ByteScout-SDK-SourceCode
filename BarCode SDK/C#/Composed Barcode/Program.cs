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
using Bytescout.BarCode;
using System.Drawing;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Result file
            var resultFile = "result.png";

            using (Barcode barcode = new Barcode("demo", "demo"))
            {
                barcode.Symbology = SymbologyType.Code128;

                barcode.Margins = new Margins(0, 0, 0, 0);
                barcode.DrawQuietZones = false;

                barcode.Value = "123123";
                Image image1 = barcode.GetImage();

                barcode.Value = "123";
                Image image2 = barcode.GetImage();

                using (ImageComposer composer = new ImageComposer(innerGap: 10, margins: 5, compositionMode: CompositionMode.ArrangeHorizontally))
                {
                    composer.AddImage(image1);
                    composer.AddImage(image2, 0, 0, rotationAngle: 90);

                    composer.SaveComposedImage(resultFile);
                }
            }

            // Open output file
            Process.Start(resultFile);
        }
    }
}
