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

namespace Sample_UI_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Assign default document
            pdfViewerControl1.InputFile = "sample.pdf";

            // Initially set selection
            pdfViewerControl1.Selection = new Rectangle[] { new Rectangle(20, 20, 100, 100) };

            // Get Selection Information
            GetSelectionInformation();

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

        private void btnGetSelectionPoints_Click(object sender, EventArgs e)
        {
            GetSelectionInformation();
        }


        private void GetSelectionInformation()
        {
            if (pdfViewerControl1.SelectionInPoints.Length > 0)
            {

                // If need to get selection in PDF format then use .SelectionInPoints that returns coordinates in PDF points. 
                // PDF points can be used with other SDK to extract text, draw on pdf, add text, images etc. 
                // These PDF points coordinates are staying the same with any rendering resolution for PDF because resolution affects only how pdf is converted into displaying image.
                RectangleF selectionInPoints = pdfViewerControl1.SelectionInPoints[0];
                txtSelectionPDFUnit.Text = string.Format("Top={0}, Left={1}, Bottom={2}, Right={3}, Width={4}, Height={5}",
                    selectionInPoints.Top,
                    selectionInPoints.Left,
                    selectionInPoints.Bottom,
                    selectionInPoints.Right,
                    selectionInPoints.Width,
                    selectionInPoints.Height);

                // If you need to draw on screen on the control then please use .Selection property to get coordinates. 
                RectangleF selectionInPixels = pdfViewerControl1.Selection[0];
                txtSelectionPixel.Text = string.Format("Top={0}, Left={1}, Bottom={2}, Right={3}, Width={4}, Height={5}",
                    selectionInPixels.Top.ToString(),
                    selectionInPixels.Left.ToString(),
                    selectionInPixels.Bottom.ToString(),
                    selectionInPixels.Right.ToString(),
                    selectionInPixels.Width,
                    selectionInPixels.Height);
            }
            else
            {
                MessageBox.Show("Selection not available.");
            }
        }

        
    }
}
