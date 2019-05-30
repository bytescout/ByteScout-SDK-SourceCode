//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using Bytescout.BarCode;
using Thought.vCards;

namespace GenerateVCardQRCode
{
	/// <summary>
	/// This example demonstrates generation of QR Code encoded vCard.
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
			// Generate vCard
			vCard vCard = new vCard();
			vCard.GivenName = "Forrest";
			vCard.FamilyName = "Gump";
			vCard.Organization = "Bubba Gump Shrimp Co.";
			vCard.Title = "Shrimp Man";
			vCard.Phones.Add(new vCardPhone("(111) 555-1212", vCardPhoneTypes.Home));
			vCard.EmailAddresses.Add(new vCardEmailAddress("forrestgump@example.com", vCardEmailAddressType.Internet));
			
			vCardDeliveryAddress address = new vCardDeliveryAddress();
			address.AddressType = vCardDeliveryAddressTypes.Home;
			address.Street = "100 Waters Edge";
			address.City = "Baytown";
			address.Region = "LA";
			address.PostalCode = "30314";
			address.Country = "United States of America";
			vCard.DeliveryAddresses.Add(address);

			// Save vCard data to string
			vCardStandardWriter writer = new vCardStandardWriter();
			StringWriter stringWriter = new StringWriter();
			writer.Write(vCard, stringWriter);

			// Create Bytescout.Barcode instance
			using (Barcode barcode = new Barcode())
			{
				// Set barcode type
				barcode.Symbology = SymbologyType.QRCode;
				// Set barcode value
				barcode.Value = stringWriter.ToString();
				// Save barcode to image
				barcode.SaveImage("result.png", ImageFormat.Png);

				// Open generated barcode image in default associated application 
				Process.Start("result.png");
			}
		}
	}
}
