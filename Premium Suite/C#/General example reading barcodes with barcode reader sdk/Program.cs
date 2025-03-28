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
using System.IO;
using Bytescout.BarCodeReader;

namespace CommonExample
{
	class Program
	{
		const string ImageFile = "Barcode.jpg";

		static void Main()
		{
			Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(ImageFile));

			Reader reader = new Reader();
			reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

			// Set barcode type to find
			reader.BarcodeTypesToFind.All = true;
			// We recommend to use specific barcode types to avoid false positives, e.g.:
			// reader.BarcodeTypesToFind.QRCode = true;
			// reader.BarcodeTypesToFind.Code39 = true;

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

			// Read barcodes
			FoundBarcode[] barcodes = reader.ReadFrom(ImageFile);

			foreach (FoundBarcode barcode in barcodes)
			{
				Console.WriteLine("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value);
			}

			// Cleanup
			reader.Dispose();
			
			Console.WriteLine("Press any key to exit..");
			Console.ReadKey();
		}
	}
}
