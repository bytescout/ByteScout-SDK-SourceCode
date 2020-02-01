//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


namespace BarcodeReader
{
    using Bytescout.BarCodeReader;

    public class Barcode
    {
        public static FoundBarcode[] FindBarcodes(string fileName)
        {
            Reader reader = new Reader();

            // Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
            // Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
            // or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
            reader.BarcodeTypesToFind.SetAll();

            // reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)
            reader.ReadFromFile(fileName);
            return reader.FoundBarcodes;
        }

        public static BarcodeTypeSelector GetBarcodeTypeToFindFromCombobox(string barType)
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
}
