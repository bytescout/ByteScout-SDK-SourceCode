//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System;
using Bytescout.BarCodeReader;

namespace Profiles
{
    /// <summary>
    /// This example demonstrates the use of profiles. Profiles are set of properties 
    /// allowing to apply them to Reader in any combination quickly. You can use 
    /// predefined profiles or create you own in JSON format like in this example.
    /// </summary>
	class Program
	{
		static void Main(string[] args)
		{
            // Create Bytescout.BarCodeReader.Reader instance
            using (Reader reader = new Reader())
            {
                reader.RegistrationName = "demo";
                reader.RegistrationKey = "demo";

                // Apply predefined profiles:
                // enable Code39;
                // enable EAN-13;
                // render PDF at 150 DPI resoultion.
                reader.Profiles = "code39, ean13, pdf150dpi";

                // Decode and show barcodes from sample1.pdf
                reader.ReadFrom("sample1.pdf");
                foreach (FoundBarcode foundBarcode in reader.FoundBarcodes)
                    Console.WriteLine("Found \"{0}\" barcode with value \"{1}\"", foundBarcode.Type, foundBarcode.Value);
            }

		    using (Reader reader = new Reader())
		    {
		        reader.RegistrationName = "demo";
		        reader.RegistrationKey = "demo";

		        // Load and apply custom profiles
		        reader.LoadProfiles("profiles.json");
		        reader.Profiles = "negative-distorted-datamatrix";

		        // Decode and show barcodes from sample2.png
		        reader.ReadFrom("sample2.png");
		        foreach (FoundBarcode foundBarcode in reader.FoundBarcodes)
		            Console.WriteLine("Found \"{0}\" barcode with value \"{1}\"", foundBarcode.Type, foundBarcode.Value);
		    }

		    Console.WriteLine("Press any key to exit...");
		    Console.ReadKey();
		}
	}
}
