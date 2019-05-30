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


using System;
using Bytescout.BarCodeReader;

namespace SimpleWebTestSharp
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Image1.ImageUrl = "BarcodePhoto.jpg";

			Reader reader = new Reader();

			// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
			// Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
			// or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
			reader.BarcodeTypesToFind.SetAll1D();

			// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

			reader.ReadFromFile(Server.MapPath("BarcodePhoto.jpg"));

			foreach (FoundBarcode barcode in reader.FoundBarcodes)
			{
				ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value));
			}
		}
	}
}
