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


/*
 IMPORTANT:
 Copy input.doc to your my documents folder
 and change the path to "input.doc" below 
 Word requires to provide absolute path to input files
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Bytescout.BarCode;

namespace InsertIntoMicrosoftWordDocument
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Create new barcode
            Barcode barcode = new Barcode();

            // Set symbology
            barcode.Symbology = SymbologyType.Codabar;
            // Set value
            barcode.Value = "123456";

            // Add checksum to barcode
            barcode.AddChecksum = true;

            // Create word instance
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();

            // Hide word
            appWord.Visible = false;

            // Create missing object
            object mis = System.Reflection.Missing.Value;
            // Template file - change to the appropraite path where you copied input.doc
            object fileInput = @"C:\input.doc";
            // Template file - change to the appropraite path where you copied input.doc
            object fileOutput = @"C:\output.doc";

            // Open document
            Microsoft.Office.Interop.Word.Document docWord = appWord.Documents.Open(ref fileInput, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis);

            // Set bookmark name
            object bookmarkName = "MyBookmark";

            // Get bookmark location
            Microsoft.Office.Interop.Word.Range bookmarkLocation = docWord.Bookmarks.get_Item(ref bookmarkName).Range;

            // Get barcode image
            Bitmap image = (Bitmap)barcode.GetImage();

            // Copy image to the clipboard
            Clipboard.SetDataObject(image);

            // Paste barcode image to the document
            bookmarkLocation.Paste();

            // Save to the new document
            docWord.SaveAs(ref fileOutput, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis, ref mis); 

            // We needn't save changes
            object saveChanges = false;

            // Close word application
            appWord.Quit(ref saveChanges, ref mis, ref mis);

            // Release COM object
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appWord);
        }
    }
}
