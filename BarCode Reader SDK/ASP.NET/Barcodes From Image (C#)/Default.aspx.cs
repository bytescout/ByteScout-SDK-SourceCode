//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Drawing;
using System.IO;
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
			    string virtualFilePath = Path.Combine(savePath, FileUpload1.FileName);

                string serverFilePath = Server.MapPath(virtualFilePath);
                if (!Directory.Exists(Path.GetDirectoryName(serverFilePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(serverFilePath));

                FileUpload1.SaveAs(serverFilePath);

				Image image = null;

				try
				{
                    using (Stream fileStream = File.OpenRead(serverFilePath))
				    {
				        image = Image.FromStream(fileStream);
				    }
				}
				catch (Exception)
				{
				}

				if (image == null)
				{
					UploadStatusLabel.Visible = true;
					UploadStatusLabel.Text = "Your file is not an image.";
					Image1.Visible = false;
					ListBox1.Visible = false;
				}
				else
				{
					UploadStatusLabel.Visible = false;
                    Image1.ImageUrl = virtualFilePath;
					Image1.Visible = true;
				    Image1.Width = image.Width;
				    Image1.Height = image.Height;
					ListBox1.Items.Clear();
					ListBox1.Visible = true;

                    FindBarcodes(serverFilePath);
					
					if (ListBox1.Items.Count == 0)
						ListBox1.Items.Add("No barcodes found");
				}
			}
			else
			{
				// Notify the user that a file was not uploaded.
				UploadStatusLabel.Text = "You did not specify a file to upload.";
			}
		}

		private void FindBarcodes(string fileName)
		{
			Reader reader = new Reader();

			// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
			// Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
			// or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
			reader.BarcodeTypesToFind.SetAll1D();

			// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

			reader.ReadFromFile(fileName);

			foreach (FoundBarcode barcode in reader.FoundBarcodes)
			{
				ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value));
			}
		}
	}
}
