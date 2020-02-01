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


using System;
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace SelectRegionAndPerformOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open Document";
                openFileDialog.Filter = @"All Supported Formats|*.pdf;*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.png;*.tif;*.tiff;*.bmp)|*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfViewerControl1.InputFile = openFileDialog.FileName;

                    btnRunOCR.Enabled = true;
                }
            }
        }

        private void btnRunOCR_Click(object sender, EventArgs e)
        {
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Load sample PDF document
            extractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

            // Enable Optical Character Recognition (OCR)
            // in .Auto mode (SDK automatically checks if needs to use OCR or not)
            extractor.OCRMode = OCRMode.Auto;

            // Set the location of "tessdata" folder containing language data files
            extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";

            // Set OCR language
            extractor.OCRLanguage = "eng"; // "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
            // Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

            // Set PDF document rendering resolution
            extractor.OCRResolution = 300;


            // Set the extraction area to the viewer's selection rectangle
            RectangleF[] selection = pdfViewerControl1.SelectionInPoints;
            if (selection.Length > 0)
                extractor.SetExtractionArea(selection[0]);

            // Show wait cursor
            Cursor = Cursors.WaitCursor;

            try
            {
                // Perform OCR and save result to file
                extractor.SavePageTextToFile(pdfViewerControl1.CurrentPageIndex, "result.txt");
            }
            finally
            {
                // Revert cursor to default
                Cursor = Cursors.Default;
            }
            
            // Cleanup
            extractor.Dispose();

            // Open output file in default associated application
            System.Diagnostics.Process.Start("result.txt");
        }
    }
}
