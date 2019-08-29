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
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.IO; //For MemoryStream
using System.Web.Services; //For WebMethod attribute
using Bytescout.BarCodeReader;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Text;


public partial class Camera : System.Web.UI.Page
{
    /*
    IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    Temporary folder access is required for web application when you use ByteScout SDK in it.
    If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    SOLUTION:

    If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    In this case
    - check the User or User Group your web application is running under
    - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    - restart your web application and try again

    */

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Takes the base64 encoded image from the browser
    /// and tries to read barodes from it
    /// </summary>
    /// <param name="image"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    [WebMethod]
    public static string Upload(string image, string type)
    {
        try
        {
            StringBuilder send = new StringBuilder();

            // lock by send variable 
            lock (send)
            {            
                // Convert base64 string from the client side into byte array
                byte[] bitmapArrayOfBytes = Convert.FromBase64String(image);
                // Create Bytescout.BarCodeReader.Reader object
                Reader reader = new Reader();
                // Get the barcode type from user's selection in the combobox
                reader.BarcodeTypesToFind = GetBarcodeTypeToFindFromCombobox(type);
                // Read barcodes from image bytes
                reader.ReadFromMemory(bitmapArrayOfBytes);
                // Check whether the barcode is decoded
                if (reader.FoundBarcodes != null)
                {
                    // Add each decoded barcode into the string 
                    foreach (FoundBarcode barcode in reader.FoundBarcodes)
                    {
                        // Add barcodes as text into the output string
                        send.AppendLine(String.Format("{0} : {1}", barcode.Type, barcode.Value));
                    }
                }

                // Return the output string as JSON
				return send.ToString();
            }
        }
        catch (Exception ex)
        {
            // return the exception instead
            return (ex.Message + "\r\n" + ex.StackTrace);
        }
    }

    /// <summary>
    /// Get symbology filter for the SDK from the combobox selection text
    /// </summary>
    /// <param name="barType"></param>
    /// <returns></returns>
    private static BarcodeTypeSelector GetBarcodeTypeToFindFromCombobox(string barType)
    {
        string selectedItemText = barType.Trim().ToUpper();
        BarcodeTypeSelector barcodeTypeToScan = new BarcodeTypeSelector();

        if (selectedItemText.IndexOf("ALL BARCODES") > -1)
            barcodeTypeToScan.SetAll();
        else if (selectedItemText.IndexOf("ALL LINEAR BARCODES") > -1)
            barcodeTypeToScan.SetAll1D();
        else if (selectedItemText.IndexOf("ALL 2D BARCODES") > -1)
            barcodeTypeToScan.SetAll2D();
        else if (selectedItemText.IndexOf("AZTEC") > -1)
            barcodeTypeToScan.Aztec = true;
        else if (selectedItemText.IndexOf("CODABAR") > -1)
            barcodeTypeToScan.Codabar = true;
        else if (selectedItemText.IndexOf("CODE 39") > -1)
            barcodeTypeToScan.Code39 = true;
        else if (selectedItemText.IndexOf("CODE 128") > -1)
            barcodeTypeToScan.Code128 = true;
        else if (selectedItemText.IndexOf("DATAMATRIX") > -1)
            barcodeTypeToScan.DataMatrix = true;
        else if (selectedItemText.IndexOf("EAN 13") > -1)
            barcodeTypeToScan.EAN13 = true;
        else if (selectedItemText.IndexOf("GS1-128") > -1)
            barcodeTypeToScan.GS1 = true;
        else if (selectedItemText.IndexOf("GS1DATABAREXPANDED") > -1)
            barcodeTypeToScan.GS1DataBarExpanded = true;
        else if (selectedItemText.IndexOf("GS1DATABAREXPANDEDSTACKED") > -1)
            barcodeTypeToScan.GS1DataBarExpandedStacked = true;
        else if (selectedItemText.IndexOf("GS1DATABARLIMITED") > -1)
            barcodeTypeToScan.GS1DataBarLimited = true;
        else if (selectedItemText.IndexOf("GS1DATABAROMNIDIRECTIONAL") > -1)
            barcodeTypeToScan.GS1DataBarOmnidirectional = true;
        else if (selectedItemText.IndexOf("GS1DATABARSTACKED") > -1)
            barcodeTypeToScan.GS1DataBarStacked = true;
        else if (selectedItemText.IndexOf("I2OF5") > -1)
            barcodeTypeToScan.Interleaved2of5 = true;
        else if (selectedItemText.IndexOf("INTELLIGENT MAIL") > -1)
            barcodeTypeToScan.IntelligentMail = true;
        else if (selectedItemText.IndexOf("PATCH") > -1)
            barcodeTypeToScan.PatchCode = true;
        else if (selectedItemText.IndexOf("PDF 417") > -1)
            barcodeTypeToScan.PDF417 = true;
        else if (selectedItemText.IndexOf("QR CODE") > -1)
            barcodeTypeToScan.QRCode = true;
        else if (selectedItemText.IndexOf("UPCA") > -1)
            barcodeTypeToScan.UPCA = true;
        else if (selectedItemText.IndexOf("UPCE") > -1)
            barcodeTypeToScan.UPCE = true;
        else if (selectedItemText.IndexOf("MAXICODE") > -1)
            barcodeTypeToScan.MaxiCode = true;

        return barcodeTypeToScan;
    }


}
