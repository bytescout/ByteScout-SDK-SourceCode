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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace Sample_UI_Application
{
    // This example requires 'PDF Viewer SDK' and 'PDF Extractor SDK' installed.
    // Download link: http://cdn.bytescout.com/ByteScoutInstaller.exe

    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

	    protected override void OnLoad(EventArgs e)
	    {
            // Preload document into viewer
	        pdfViewerControl1.InputFile = @".\sample_ocr.pdf";

            base.OnLoad(e);
	    }

	    private void tsbOpen_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = @"Open PDF Document";
				openFileDialog.Filter = @"PDF Files (*.pdf)|*.pdf|All Files|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.Text = openFileDialog.FileName;

					Cursor = Cursors.WaitCursor;

					try
					{
						pdfViewerControl1.InputFile = openFileDialog.FileName;
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message);
					}
					finally
					{
						Cursor = Cursors.Default;
					}
				}
			}
		}

        private void tsbExportToCSV_Click(object sender, EventArgs e)
        {
            // Get selections from viewer
            RectangleF[] selections = pdfViewerControl1.SelectionInPoints;
            
            string outputFile = @".\result.csv";

            using (CSVExtractor csvExtractor = new CSVExtractor("demo", "demo"))
            {
                // Load document into extractor
                csvExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                // Enable OCR to recongize text from images
                csvExtractor.OCRMode = OCRMode.Auto;
                csvExtractor.OCRResolution = 300;
                csvExtractor.OCRLanguage = "eng";
                csvExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                // There are double spaces between some words in your document.
                // To avoid such words break column structure increase the space ratio to 2.
                csvExtractor.DetectNewColumnBySpacesRatio = 2;

                // FYI, removing horizontal lines may increase the text recognition quality in some cases
                csvExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();
                // Another filter able to improve the recognition 
                //csvExtractor.OCRImagePreprocessingFilters.AddGammaCorrection();

                // If selection exists set the extraction area.
                // Overwise it will extract the whole page.
                if (selections.Length > 0)
                    csvExtractor.SetExtractionArea(selections[0]);

                // Save extraction results to CSV files
                csvExtractor.SavePageCSVToFile(pdfViewerControl1.CurrentPageIndex, outputFile);
            }

            Process.Start(outputFile);
        }

        private void tsbExportToXLSX_Click(object sender, EventArgs e)
        {
            // Get selections from viewer
            RectangleF[] selections = pdfViewerControl1.SelectionInPoints;

            string outputFile = @".\result.xlsx";

            using (XLSExtractor xlsExtractor = new XLSExtractor("demo", "demo"))
            {
                // Load document into extractor
                xlsExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                xlsExtractor.OCRMode = OCRMode.Auto;
                xlsExtractor.OCRResolution = 300;
                xlsExtractor.OCRLanguage = "eng";
                xlsExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";

                xlsExtractor.OutputFormat = SpreadseetOutputFormat.XLSX;
                xlsExtractor.RichTextFormatting = false;

                // There are double spaces between some words in your document.
                // To avoid such words break column structure increase the space ratio to 2.
                xlsExtractor.DetectNewColumnBySpacesRatio = 2;

                // FYI, removing horizontal lines may increase the text recognition quality in some cases
                //xlsExtractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();
                // Another filter able to improve the recognition 
                //xlsExtractor.OCRImagePreprocessingFilters.AddGammaCorrection();

                // If selection exists set the extraction area.
                // Overwise it will extract the whole page.
                if (selections.Length > 0)
                    xlsExtractor.SetExtractionArea(selections[0]);

                // Save extraction results to XLSX files
                xlsExtractor.SavePageToXLSFile(pdfViewerControl1.CurrentPageIndex, outputFile);
            }

            Process.Start(outputFile);
        }
    }
}
