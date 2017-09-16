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

			// Find check boxes
			FoundBarcode[] barcodes = reader.ReadFrom(ImageFile);

			foreach (FoundBarcode barcode in barcodes)
			{
				Console.WriteLine("Found checkbox with type '{0}' and value '{1}'", barcode.Type, barcode.Value);
			}

			Console.WriteLine("Press any key to exit..");
			Console.ReadKey();
		}
	}
}
