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
using System.IO;
using Bytescout.BarCodeReader;

namespace WebTestSharp
{
	public partial class _Default : System.Web.UI.Page
	{
	    protected void Page_Load(object sender, EventArgs e)
	    {
            LabelInputFile.Text = MapPath("barcodes.pdf");
	    }

	    protected void UploadButton_Click(object sender, EventArgs e)
		{
			String savePath = @"\uploads\";

			if (FileUpload1.HasFile)
			{
				String fileName = FileUpload1.FileName;
                fileName = savePath + fileName;
                // remove if already exists
                if (File.Exists(fileName))
                    File.Delete(fileName);
                    
				FileUpload1.SaveAs(Server.MapPath(fileName));

				Reader barcodeReader = new Reader();

				// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
				// Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
				// or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
                barcodeReader.BarcodeTypesToFind.SetAll1D();

				// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)
				UploadStatusLabel.Visible = false;

				ListBox1.Items.Clear();
				ListBox1.Visible = true;
				ListBox1.Items.Add("Searching for barcode(s) from PDF file \"" + fileName + "\"");

                FoundBarcode[] barcodes = barcodeReader.ReadFrom(Server.MapPath(fileName));

				if (barcodes.Length == 0)
				{
					ListBox1.Items.Add("No barcodes found");
				}
				else
				{
                    // saving filename of the pdf file 
                    string lastFilename = fileName;
                    
                    int partIndex = 0;

					foreach (FoundBarcode barcode in barcodes)
					{
                        // Split PDF document in two parts by found barcode
                        partIndex++;
                        barcodeReader.SplitDocument(
                            Server.MapPath(lastFilename), 
                            Server.MapPath(savePath+@"part-" + partIndex + ".pdf"),
                            Server.MapPath(savePath + @"part-last.pdf"), 
                            barcode.Page + 1);

                        ListBox1.Items.Add(String.Format("Splitting " + fileName + " file into 2 by barcode with type '{0}' and value '{1}' on page {2} at {3} ", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString()));
                        ListBox1.Items.Add("Saved:" + savePath + @"part-" + partIndex + ".pdf");

                        lastFilename = savePath + @"part-last.pdf";

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
