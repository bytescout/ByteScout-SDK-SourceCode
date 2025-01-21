//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFExtractor;
using Bytescout.PDFViewer;

namespace Sample_UI_Application
{
    public partial class Form1 : Form
    {
        // Dictionary to keep selected rectangles for all document pages
        private readonly Dictionary<int, RectangleF[]> _dictPageWiseRectangles = new Dictionary<int, RectangleF[]>();

        public Form1()
        {
            InitializeComponent();

            // Load sample document into PDF Viewer control
            pdfViewerControl1.InputFile = "sample.pdf";

            // Tune PDF Viewer control
            pdfViewerControl1.MouseMode = MouseMode.Selection;
            pdfViewerControl1.MultiSelectMode = true;
            pdfViewerControl1.AllowResizeSelectionRectangles = true;
            pdfViewerControl1.ShowResizeHandlesForActiveSelectionOnly = true;
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
            using (Remover2 remover = new Remover2("demo", "demo"))
            {
                remover.LoadDocumentFromFile(pdfViewerControl1.InputFile);

                foreach (KeyValuePair<int, RectangleF[]> keyValuePair in _dictPageWiseRectangles)
                    remover.AddTextToRemove(keyValuePair.Key, keyValuePair.Value);

                // Remove text from all selected rectangles
                remover.PerformRemoval("output.pdf");
            }

            pdfViewerControl1.CurrentPageIndex = 0;

            MessageBox.Show("Output file created successfully!", "Success");

            // Open output file
            Process.Start("output.pdf");
        }

        private void PdfViewerControl1_SelectionChanged(object sender, SelectionChange selectionChange, int selectionIndex)
        {
            // Store selection changes 
            if (selectionChange != SelectionChange.Cleared)
            {
                _dictPageWiseRectangles[pdfViewerControl1.CurrentPageIndex] = pdfViewerControl1.SelectionInPoints;
            }
        }

        private void PdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
        {
            // Show stored selection on page switching
            if (_dictPageWiseRectangles.ContainsKey(pdfViewerControl1.CurrentPageIndex))
            {
                pdfViewerControl1.SelectionInPoints = _dictPageWiseRectangles[pdfViewerControl1.CurrentPageIndex];
            }
        }
    }
}
