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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bytescout.PDFExtractor;

namespace SampleApplication
{
	public partial class Form1 : Form
	{
		List<String> _dataLabels = new List<string>();

		public Form1()
		{
			InitializeComponent();

			pdfViewerControl1.RegistrationName = "demo";
			pdfViewerControl1.RegistrationKey = "demo";
		}

		protected override void OnLoad(EventArgs e)
		{
			OpenDocument(@"Invoice.pdf");

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
					OpenDocument(openFileDialog.FileName);
				}
			}
		}

		private void OpenDocument(string filePath)
		{
			Text = filePath;

			Cursor = Cursors.WaitCursor;

			try
			{
				pdfViewerControl1.InputFile = filePath;
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

		private void pdfViewerControl1_DocumentChanged(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		private void pdfViewerControl1_CurrentPageIndexChanged(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearSelections();
			UpdateControls();
		}

		void ClearSelections()
		{
			_dataLabels.Clear();
			pdfViewerControl1.ClearSelection();
			UpdateControls();
		}

		void UpdateControls()
		{
			rbSelectInvoiceNumber.Enabled = pdfViewerControl1.IsDocumentLoaded;
			rbSelectCustomerInfo.Enabled = pdfViewerControl1.IsDocumentLoaded;
			rbSelectTotal.Enabled = pdfViewerControl1.IsDocumentLoaded;
			btnGetData.Enabled = pdfViewerControl1.IsDocumentLoaded && pdfViewerControl1.Selection.Length > 0;
			btnClear.Enabled = pdfViewerControl1.IsDocumentLoaded && pdfViewerControl1.Selection.Length > 0;
		}

		private void pdfViewerControl1_SelectionChanged(object sender, EventArgs e)
		{
			UpdateControls();

			if (pdfViewerControl1.Selection.Length > _dataLabels.Count)
			{
				for (int i = _dataLabels.Count; i < pdfViewerControl1.Selection.Length; i++)
				{
					string dataLabel;

					if (rbSelectInvoiceNumber.Checked)
						dataLabel = "Invoice Number:";
					else if (rbSelectCustomerInfo.Checked)
						dataLabel = "Customer Info:";
					else
						dataLabel = "TOTAL:";

					_dataLabels.Add(dataLabel);
				}
			}
		}

		private void pdfViewerControl1_CustomPaint(object sender, PaintEventArgs e)
		{
			Rectangle[] selection = pdfViewerControl1.Selection;

			// Paint labels
			for (int i = 0; i < selection.Length; i++)
			{
				Rectangle r = Rectangle.Round(selection[i]);
				r = pdfViewerControl1.TranslateRectangleToViewport(r);

				Size textSize = TextRenderer.MeasureText(_dataLabels[i], Font);
				Rectangle textRectangle = new Rectangle(r.Left, r.Top - textSize.Height - 6, textSize.Width + 2, textSize.Height + 2);

				e.Graphics.FillRectangle(Brushes.DarkBlue, textRectangle);
				TextRenderer.DrawText(e.Graphics, _dataLabels[i], Font, textRectangle, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
			}

		}

		private void btnGetData_Click(object sender, EventArgs e)
		{
			StringBuilder result = new StringBuilder();
			RectangleF[] selection = pdfViewerControl1.SelectionInPoints;

			using (TextExtractor extractor = new TextExtractor())
			{
				extractor.RegistrationName = "demo";
				extractor.RegistrationKey = "demo";

				extractor.LoadDocumentFromFile(pdfViewerControl1.InputFile);
				extractor.OCRMode = OCRMode.Auto;
				extractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";
				extractor.OCRResolution = 300;

				for (int i = 0; i < selection.Length; i++)
				{
					extractor.SetExtractionArea(selection[i]);
					result.AppendLine(_dataLabels[i]);
					result.AppendLine(extractor.GetText(pdfViewerControl1.CurrentPageIndex, pdfViewerControl1.CurrentPageIndex));
					result.AppendLine();
				}		
			}

			MessageBox.Show(result.ToString());
		}
	}
}
