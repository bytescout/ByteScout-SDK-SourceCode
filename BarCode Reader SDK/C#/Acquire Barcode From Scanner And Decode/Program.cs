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


using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Bytescout.BarCodeReader;

// This example demonstrates camera image acquiring using Windows Image Acquisition (WIA) interface.
// BarCode Reader SDK has builtin WIAImageScanner class for WIA.
// If you experienced issues with this example, please try another example located in /Visual Basic.NET/Read From Live Video Cam/ 


namespace BarcodeFromWebCam
{
	static class Program
	{
		static void Main()
		{
            // Use WIAImageScanner image acquisition module
            WIAImageScanner wiaScanner = new WIAImageScanner();

            wiaScanner.OutputFileNameTemplate = "BarCodeReader-scanned";
            wiaScanner.OutputImageFormat = WiaImageFormatType.PNG;
            wiaScanner.ImageQuality = WiaImageBias.MaximizeQuality;
            wiaScanner.ImageIntent = WiaImageIntent.UnspecifiedIntent;
            wiaScanner.ShowDeviceSelectionDialog = true;

            try
            {
                // Run Acquire and exit if canceled or zero images
                if (!wiaScanner.Acquire())
                    return;
            }
            catch (Exception e)
            {
                string message = e.Message;
                if (e.InnerException != null)
                    message = message + "\r\n\r\n" + e.InnerException.Message;
                MessageBox.Show("Failed acquiring images:\r\n\r\n" + message);
                return;
            }

            // Create barcode reader
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Enable decoding of ALL known barcode types.
            reader.BarcodeTypesToFind.All = true;
            // To speed up the processing and avoid false positives select specific barcodes type, 
            // e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True

	        FoundBarcode[] barcodes = reader.ReadFrom(wiaScanner.OutputFiles[0]);

            if (barcodes.Length > 0)
            {
                StringBuilder builder = new StringBuilder();
                foreach (FoundBarcode barcode in barcodes)
                    builder.AppendLine(String.Format("Found barcode with type '{0}' and value '{1}'", barcode.Type, barcode.Value));
                MessageBox.Show(builder.ToString());
            }
            else
            {
                MessageBox.Show(wiaScanner.OutputFiles[0] + "\r\n\r\nCould not find any barcode.");
            }

            // cleanup
            reader.Dispose();
 		}
	}
}
