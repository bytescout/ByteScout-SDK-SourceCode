//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.Text;
using Bytescout.BarCode;

namespace QRCodeWithBinaryData
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create and activate QRCode component instance
			using (QRCode barcode = new QRCode())
			{
				barcode.RegistrationName = "demo";
				barcode.RegistrationKey = "demo";

				// Sample byte array to use as value 
				byte[] byteArray = new byte[] { 0, 10, 11, 12, 13, 14, 15, 0xFF };

				// Set value by converting byte array to string 
				barcode.Value = Encoding.ASCII.GetString(byteArray);

				// Save barcode image
				barcode.SaveImage("result.png");

				// Open the image in default associated application (for the demo purpose)
				Process.Start("result.png");
			}
		}
	}
}
