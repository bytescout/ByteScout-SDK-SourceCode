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
using Thought.vCards;

namespace ReadVCardFromQRCode
{
	/// <summary>
	/// This example demonstrates reading of QR Code encoded vCard.
	/// It uses vCard library by David Pinch:
	/// 
	/// vCard Class Library for .NET (Version 0.4; LGPL license)
	/// Copyright (c) 2007-2009 David Pinch 
	/// http://www.thoughtproject.com/Libraries/vCard/
	/// 
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.BarCodeReader.Reader instance
			using (Reader reader = new Reader())
			{
				// Enable QR Code decoding
				reader.BarcodeTypesToFind.QRCode = true;

				// Decode QR Code from image
				FoundBarcode[] barcodes = reader.ReadFrom("sample_vcard.gif");

				if (barcodes.Length > 0)
				{
					FoundBarcode vcardBarcode = barcodes[0];
					
					// Decode vCard information from barcode value
					StringReader stringReader = new StringReader(vcardBarcode.Value);
					vCard vCard = new vCard(stringReader);

					// Display some decoded info:
					Console.WriteLine("GivenName: " + vCard.GivenName);
					Console.WriteLine("FamilyName: " + vCard.FamilyName);
					Console.WriteLine("Organization: " + vCard.Organization);
					Console.WriteLine("Title: " + vCard.Title);
					Console.WriteLine("Phone: " + vCard.Phones[0].FullNumber);
					Console.WriteLine("EmailAddresses: " + vCard.EmailAddresses[0]);
					Console.WriteLine("DeliveryAddress: " + vCard.DeliveryAddresses[0].Street + " " + vCard.DeliveryAddresses[0].City + " " +
						vCard.DeliveryAddresses[0].Region + " " + vCard.DeliveryAddresses[0].PostalCode + " " + vCard.DeliveryAddresses[0].Country);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Press any key...");
			Console.ReadKey();
		}
	}
}
