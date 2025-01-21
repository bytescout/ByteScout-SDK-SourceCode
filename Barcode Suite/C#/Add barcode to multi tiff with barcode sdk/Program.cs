//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.BarCode;

namespace AddBarcodeToMultipageTiff
{
	class Program
	{
		static void Main()
		{
            // Create new barcode and register it.
            Barcode barcode = new Barcode();
			barcode.RegistrationName = "demo";
			barcode.RegistrationKey = "demo";

            // Set symbology
            barcode.Symbology = SymbologyType.PDF417;
            // Set value
            barcode.Value = "Sample barcode";

            // Place barcode at bottom-right corner of the the first TIFF page
			barcode.DrawToImage("wikipedia.tif", 0, 550, 1100, "result.tif");

            // Open output file in default image viewer
            System.Diagnostics.Process.Start("result.tif");
		}
	}
}
