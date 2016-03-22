//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

using Bytescout.PDFRenderer;


namespace PrintPDF
{
	public partial class Form1 : Form
	{
		private string _document = @"multipage.pdf";
		RasterRenderer _rasterRenderer = null;
		private int _page = 0;

		
		public Form1()
		{
			InitializeComponent();

			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			_rasterRenderer = new RasterRenderer();
			_rasterRenderer.RegistrationName = "demo";
			_rasterRenderer.RegistrationKey = "demo";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			try
			{
				// Load PDF document.
				_rasterRenderer.LoadDocumentFromFile(_document);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Failed to open PDF document.\r\n" + exception.Message);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void buttonPageSetup_Click(object sender, EventArgs e)
		{
			pageSetupDialog1.ShowDialog();
		}

		private void buttonPrintPreview_Click(object sender, EventArgs e)
		{
			_page = 0;
			printPreviewDialog1.Width = 800;
			printPreviewDialog1.Height = 600;
			printPreviewDialog1.ShowDialog();
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			try
			{
				using (VectorRenderer vectorRenderer = new VectorRenderer("demo", "demo"))
				{
					vectorRenderer.LoadDocumentFromFile(_document);

					Rectangle printRect = e.MarginBounds;

					using (Metafile image = vectorRenderer.RenderPageToMetafile(_page))
					{
						// calculate print rectangle
						float ratio = printRect.Width / (float) image.Width;
						int width = printRect.Width;
						int height = (int) (image.Height * ratio);

						if (height > printRect.Height)
						{
							ratio = printRect.Height / (float) image.Height;
							width = (int) (image.Width * ratio);
							height = printRect.Height;
						}

						// draw page on device
						e.Graphics.DrawImage(image, new Rectangle(printRect.X, printRect.Y, width, height),
							new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
					}

					if (_page < vectorRenderer.GetPageCount() - 1)
					{
						_page++;
						e.HasMorePages = true;
					}
				}
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}
	}
}
