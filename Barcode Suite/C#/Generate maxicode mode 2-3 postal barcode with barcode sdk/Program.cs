//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright Â© 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.BarCode;

namespace PostalMaxiCode
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create and activate Barcode object instance
			Barcode barcode = new Barcode();
			barcode.RegistrationName = "demo";
			barcode.RegistrationKey = "demo";

			// Set barcode symbology (type) 
			barcode.Symbology = SymbologyType.MaxiCode;
			// Set MaxiCode mode
			barcode.Options.MaxiCodeMode = 2; // 2 or 3 depending on the postal code

			// Make barcode dots larger (5 pixels)
			barcode.NarrowBarWidth = 5;

			
			// Prepare barcode value:

			// Special data signatures
			string mode23Signature = "[)>" + '\x1E' + "01" + '\x1D' + "96";
			char separator = '\x1D';
			string endingSignature = "\x1E" + '\x04';

			// Mandatory data part.
			string postalCode = "123456789"; // 5 or 9 digits in the USA (Mode 2); 1-6 alphanumeric characters in other countries (Mode 3)
			string countryCode = "840"; // 3 digits (840 for USA) 
			string classOfService = "001"; // 3 digits 
			string trackingNumber = "S1Z12345678G"; // 10-character alphanumeric
			string upsStandardCarrierAlphaCode = "UPSN";

			// Optional data part.
			// Note, you can use empty strings for unneeded field values like `packageInShipment` or `weightInPounds` 
			// but they should delimited with the separator anyway.
			string upsShipperNumber = "S06X610"; // 6-character alphanumeric 
			string julianDayOfPickup = "159"; // 3 digits 
			string shipmentIdNumber = "1234567"; // 1-30 character alphanumeric 
			string packageInShipment = "1/2"; // 1-4 digits “/” 1-4 digits 
			string weightInPounds = "3.1"; // 1-5 digits
			string addressValidation = "Y"; // “Y” or “N”
			string shipToAddress = "S123 MAIN ST"; // 1-35 alphanumeric
			string shipToCity = "YORK"; // 1 - 35 alphanumeric
			string shipToState = "PA"; // 2-character alpha


			// Generate minimal postal code:

			string minimalValue = mode23Signature +
			                      postalCode + separator +
			                      countryCode + separator +
			                      classOfService + separator +
			                      trackingNumber + separator +
			                      upsStandardCarrierAlphaCode +
			                      endingSignature;

			barcode.Value = minimalValue;
			barcode.SaveImage("postal-maxicode-min.png");


			// Generate full postal code:

			string fullValue = mode23Signature +
			                   postalCode + separator +
			                   countryCode + separator +
			                   classOfService + separator +
			                   trackingNumber + separator +
			                   upsStandardCarrierAlphaCode + separator +
			                   upsShipperNumber + separator +
			                   julianDayOfPickup + separator +
			                   shipmentIdNumber + separator +
			                   packageInShipment + separator +
			                   weightInPounds + separator +
			                   addressValidation + separator +
			                   shipToAddress + separator +
			                   shipToCity + separator +
			                   shipToState +
			                   endingSignature;

			barcode.Value = fullValue;
			barcode.SaveImage("postal-maxicode-full.png");

			// Cleanup
			barcode.Dispose();
		}
	}
}
