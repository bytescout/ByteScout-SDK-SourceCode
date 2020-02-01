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
        // Keep selected rectangles for all document pages
        Dictionary<int, RectangleF[]> _foundTextRectangles = new Dictionary<int, RectangleF[]>();

        public Form1()
        {
            InitializeComponent();

            // Tune PDF Viewer control
            pdfViewerControl1.MouseMode = MouseMode.Selection;
            pdfViewerControl1.MultiSelectMode = true;
            pdfViewerControl1.AllowResizeSelectionRectangles = true;
            pdfViewerControl1.ShowResizeHandlesForActiveSelectionOnly = true;
            pdfViewerControl1.ClearSelectionOnClick = false;

            // Load document into PDF viewer
            pdfViewerControl1.InputFile = "sample.pdf";
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
                        // Open file in PDF Viewer control
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

        private void PdfViewerControl1_SelectionChanged(object sender, SelectionChange selectionChange, int selectionIndex)
        {
            // Store selection changes 
            if (selectionChange != SelectionChange.Cleared)
            {
                _foundTextRectangles[pdfViewerControl1.CurrentPageIndex] = pdfViewerControl1.SelectionInPoints;
            }
        }

        private void PdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
        {
            // Show stored selection on page switching
            if (_foundTextRectangles.ContainsKey(pdfViewerControl1.CurrentPageIndex))
            {
                pdfViewerControl1.SelectionInPoints = _foundTextRectangles[pdfViewerControl1.CurrentPageIndex];
            }
        }

        private void PdfViewerControl1_ValidateContextMenu(object source, ContextMenuStrip menu)
        {
            // Add context menu item to delete active selection
            menu.Items.Insert(0, new ToolStripMenuItem("Delete active selection", null, (sender, args) =>
            {
                int activeSelectionIndex = pdfViewerControl1.ActiveSelectionIndex;
                if (activeSelectionIndex != -1)
                    pdfViewerControl1.RemoveSelectionAt(activeSelectionIndex);
            }) { Enabled = pdfViewerControl1.ActiveSelectionIndex != -1 });

            menu.Items.Insert(1, new ToolStripSeparator());
        }

        private void PdfViewerControl1_PreProcessKey(object source, Keys keyData, ref bool handled)
        {
            // `Delete` key will delete active selection
            if (keyData == Keys.Delete)
            {
                int activeSelectionIndex = pdfViewerControl1.ActiveSelectionIndex;
                if (activeSelectionIndex != -1)
                {
                    pdfViewerControl1.RemoveSelectionAt(activeSelectionIndex);
                    handled = true;
                }
            }
        }

        private void BtnFindAll_Click(object sender, EventArgs e)
        {
            if (tbSearchExpression.Text.Length > 1)
            {
                // Prepare TextExtractor
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Load document into TextExtractor
                    textExtractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                    // Set options from UI
                    textExtractor.RegexSearch = cbRegex.Checked;
                    textExtractor.WordMatchingMode = WordMatchingMode.None;
                
                    // Search for text in all pages and store rectangles of found pieces
                    for (int pageIndex = 0; pageIndex < textExtractor.GetPageCount(); pageIndex++)
                    {
                        ISearchResult[] searchResults = textExtractor.FindAll(pageIndex, tbSearchExpression.Text, caseSensitive: true);
                        if (searchResults.Length > 0)
                        {
                            _foundTextRectangles[pageIndex] = searchResults.Select(searchResult => searchResult.Bounds).ToArray();
                        }
                    }
                }

                // Select fount rectangles in PDF Viewer
                if (_foundTextRectangles.ContainsKey(pdfViewerControl1.CurrentPageIndex))
                    pdfViewerControl1.SelectionInPoints = _foundTextRectangles[pdfViewerControl1.CurrentPageIndex];
            }
            else
            {
                MessageBox.Show(@"Try larger search string");
            }
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            var outputFile = "output.pdf";
            MemoryStream tempStream = new MemoryStream();

            // Create `Bytescout.PDFExtractor.Remover2` instance
            using (Remover2 remover = new Remover2("demo", "demo"))
            {
                // Load document into remover
                remover.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                // Set options from UI
                remover.MaskRemovedText = cbMaskRemovedText.Checked;
                remover.MakePDFUnsearchable = cbMakeUnsearchable.Checked;

                // Add fragments to remove
                foreach (KeyValuePair<int, RectangleF[]> keyValuePair in _foundTextRectangles)
                    remover.AddTextToRemove(keyValuePair.Key, keyValuePair.Value);

                // Perform removal and save result document to file
                remover.PerformRemoval(outputFile);
            }
            
            // Open output PDF file in default associated application
            Process.Start(outputFile);
        }
    }
}
