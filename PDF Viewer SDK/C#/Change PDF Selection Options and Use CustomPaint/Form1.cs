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
using System.Drawing;
using System.Windows.Forms;
using Bytescout.PDFViewer;

namespace Example
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			pdfViewerControl1.InputFile = "sample.pdf";

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

		private void cbMultiSelectMode_CheckedChanged(object sender, EventArgs e)
		{
			pdfViewerControl1.MultiSelectMode = cbMultiSelectMode.Checked;
		}

		private void cbAllowResizeSelection_CheckedChanged(object sender, EventArgs e)
		{
			pdfViewerControl1.AllowResizeSelectionRectangles = cbAllowResizeSelection.Checked;
		}

		private void cbLockSelection_CheckedChanged(object sender, EventArgs e)
		{
			pdfViewerControl1.LockSelection = cbLockSelection.Checked;
		}

		List<String> _labels = new List<string>();

		private void pdfViewerControl1_SelectionChanged(object sender, SelectionChange selectionChange, int selectionIndex)
		{
			if (pdfViewerControl1.Selection.Length > _labels.Count)
			{
				for (int i = _labels.Count; i < pdfViewerControl1.Selection.Length; i++)
				{
					_labels.Add(new Random().Next().ToString());
				}
			}
		}

		private void pdfViewerControl1_CustomPaint(object sender, PaintEventArgs e)
		{
			// Paint labels
			for (int i = 0; i < pdfViewerControl1.Selection.Length; i++)
			{
				Rectangle r = Rectangle.Round(pdfViewerControl1.Selection[i]);
				r = pdfViewerControl1.TranslateRectangleToViewport(r);
				
				Size textSize = TextRenderer.MeasureText(_labels[i], Font);
				Rectangle textRectangle = new Rectangle(r.Left, r.Top - textSize.Height - 6, textSize.Width + 2, textSize.Height + 2);

				e.Graphics.FillRectangle(Brushes.DarkBlue, textRectangle);
				TextRenderer.DrawText(e.Graphics, _labels[i], Font, textRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}
		}
	}
}
