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

namespace WebTestSharp
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void UploadButton_Click(object sender, EventArgs e)
		{
			String savePath = @"\uploads\";

			if (FileUpload1.HasFile)
			{
				String fileName = FileUpload1.FileName;
				savePath += fileName;
				FileUpload1.SaveAs(Server.MapPath(savePath));

				Reader barcodeReader = new Reader();

				// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
				// Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
				// or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
				barcodeReader.BarcodeTypesToFind.SetAll1D();

				// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)
				UploadStatusLabel.Visible = false;

				ListBox1.Items.Clear();
				ListBox1.Visible = true;
				ListBox1.Items.Add("Reading barcode(s) from PDF file \"" + fileName + "\"");

				FoundBarcode[] barcodes = barcodeReader.ReadFrom(Server.MapPath(savePath));

				if (barcodes.Length == 0)
				{
					ListBox1.Items.Add("No barcodes found");
				}
				else
				{
					foreach (FoundBarcode barcode in barcodes)
					{
                        ListBox1.Items.Add(String.Format("Found barcode with type '{0}' and value '{1}' on page {2} at {3} ", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString()));
					}
				}
			}
			else
			{
				// Notify the user that a file was not uploaded.
				UploadStatusLabel.Text = "You did not specify a file to upload.";
			}
		}
	}
}
