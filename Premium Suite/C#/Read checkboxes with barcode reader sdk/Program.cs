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
		const string ImageFile = "checkboxes-checked.png";

		static void Main()
		{
			Console.WriteLine("Reading checkboxes from image {0}", Path.GetFullPath(ImageFile));

			Reader reader = new Reader();
			reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

			// Enable check boxes recognition
			reader.BarcodeTypesToFind.Checkbox = true;

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

			// Find check boxes
			FoundBarcode[] barcodes = reader.ReadFrom(ImageFile);

			foreach (FoundBarcode barcode in barcodes)
			{
				Console.WriteLine("Found checkbox with type '{0}' and value '{1}'", barcode.Type, barcode.Value);
			}

            // Cleanup
            reader.Dispose();

			Console.WriteLine("Press any key to exit..");
			Console.ReadKey();
		}
	}
}
