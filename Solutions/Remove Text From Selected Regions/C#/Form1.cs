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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bytescout.PDFExtractor;
using Bytescout.PDFViewer;

namespace Sample_UI_Application
{
    public partial class Form1 : Form
    {
        Dictionary<int, RectangleF[]> dictPageWiseRectangels;

        public Form1()
        {
            InitializeComponent();

            // Assign default document
            pdfViewerControl1.InputFile = "sample.pdf";

            pdfViewerControl1.MultiSelectMode = true;
            pdfViewerControl1.AllowResizeSelectionRectangles = true;

            dictPageWiseRectangels = new Dictionary<int, RectangleF[]>();
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

        private void BtnRemoveTextInSelectedRegions_Click(object sender, EventArgs e)
        {
            if (dictPageWiseRectangels == null)
            {
                dictPageWiseRectangels = new Dictionary<int, RectangleF[]>();
            }

            var oldInputFileName = pdfViewerControl1.InputFile;

            var tempFileName = "tempFile.pdf";
            var tempFileName_1 = "tempFile_1.pdf";

            // Copy input source to temp location
            File.Copy(oldInputFileName, tempFileName, true);

            // Loop through all values
            foreach (var key in dictPageWiseRectangels.Keys)
            {
                // Get all rectangles
                var allRectangles = dictPageWiseRectangels[key];

                if (allRectangles != null && allRectangles.Length > 0)
                {
                    using (Remover remover = new Remover())
                    {
                        remover.LoadDocumentFromFile(tempFileName);

                        // Remove text from all selected rectangles
                        remover.RemoveText(key, allRectangles, tempFileName_1);
                    }

                    // Overwrite tempfile
                    File.Copy(tempFileName_1, tempFileName, true);
                }
            }

            // Save output file 
            File.Copy(tempFileName, "output.pdf", true);

            // Clean up
            File.Delete(tempFileName);
            File.Delete(tempFileName_1);

            pdfViewerControl1.CurrentPageIndex = 0;

            MessageBox.Show("Output file created successfully!", "Success");

            // Open output file
            Process.Start("output.pdf");
        }

        private void PdfViewerControl1_SelectionChanged(object sender, SelectionChange selectionChange, int selectionIndex)
        {
            if (selectionChange != SelectionChange.Cleared)
            {
                if (dictPageWiseRectangels == null)
                {
                    dictPageWiseRectangels = new Dictionary<int, RectangleF[]>();
                }

                dictPageWiseRectangels[pdfViewerControl1.CurrentPageIndex] = pdfViewerControl1.SelectionInPoints;
            }
        }

        private void PdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
        {
            if (dictPageWiseRectangels.ContainsKey(pdfViewerControl1.CurrentPageIndex))
            {
                // Preserve selected rectangles if existed
                RectangleF[] exitsingSelections = (RectangleF[])dictPageWiseRectangels[pdfViewerControl1.CurrentPageIndex].Clone();
                pdfViewerControl1.SelectionInPoints = exitsingSelections;
            }
        }
    }
}
