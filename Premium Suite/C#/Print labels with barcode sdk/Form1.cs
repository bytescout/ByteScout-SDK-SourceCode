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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;
using Bytescout.BarCode;

namespace PrintLabels
{
	/// <summary>
	/// This example demonstrates drawing and printing of mutiple cards (e.g. stickers) on a single page.
	/// Cards contain variable labels and barcodes.
	/// </summary>
	public partial class Form1 : Form
	{
		SizeF PaperSize = new SizeF(5.5f, 8.75f); // 5.5 x 8.75 inches
		const int PrintingResolution = 300; // 300 dots per inch
		
		public Form1()
		{
			InitializeComponent();

			// Make the print preview dialog larger by default
			printPreviewDialog1.MinimumSize = new Size(800, 600);
		}

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			// Show print setup dialog, then print preview
			if (printDialog1.ShowDialog() == DialogResult.OK)
				printPreviewDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			// Draw page on the printer device context
			Bitmap pageBitmap = DrawPage();
			e.Graphics.DrawImage(pageBitmap, 0, 0);
		}

		// Draw cards on a bitmap of custom size
		private Bitmap DrawPage()
		{
			SizeF cardSize = new SizeF(PaperSize.Width / 4, PaperSize.Height / 4); // 4 x 4 cards on a page

			// Prepare constant and variable labels
			string strBrand = "CJ SHOES";
			string strModel = "ARTHUR-1N";
			string strColor = "BLK";
			float shoeSizeStart = 5.5f;
			float shoeSizeStep = 0.5f;
			long barcodeStartValue = 4611030000;
			int barcodeValueStep = 1;

			// Prepare fonts
			Font font1 = new Font("Arial", 0.12f, GraphicsUnit.Inch);
			Font font2 = new Font("Arial", 0.10f, GraphicsUnit.Inch);
			Font font3 = new Font("Arial", 0.09f, GraphicsUnit.Inch);
			Font font4 = new Font("Arial", 0.15f, GraphicsUnit.Inch);

			// Prepare barcode generator
			Barcode barcode = new Barcode("demo", "demo");
			barcode.Symbology = SymbologyType.I2of5;
			barcode.NarrowBarWidth = 2;
			barcode.DrawCaption = false;

			int cardIndex = 0;

			// Create bitmap for the page
			Bitmap pageBitmap = new Bitmap((int) (PaperSize.Width * PrintingResolution), (int) (PaperSize.Height * PrintingResolution));
			pageBitmap.SetResolution(PrintingResolution, PrintingResolution);

			using (Graphics pageCanvas = Graphics.FromImage(pageBitmap))
			{
				pageCanvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
				pageCanvas.CompositingQuality = CompositingQuality.HighQuality;

				// Setup page units to inches
				pageCanvas.PageUnit = GraphicsUnit.Inch;
				// Fill background with white color
				pageCanvas.Clear(Color.White);

				// Draw cards
				for (int row = 0; row < 4; row++)
				{
					for (int column = 0; column < 4; column++)
					{
						// Create bitmap for card
						Bitmap cardBitmap = new Bitmap((int) (cardSize.Width * PrintingResolution), (int) cardSize.Height * PrintingResolution);
						cardBitmap.SetResolution(PrintingResolution, PrintingResolution);

						using (Graphics cardCanvas = Graphics.FromImage(cardBitmap))
						{
							// Setup page units to inches
							cardCanvas.PageUnit = GraphicsUnit.Inch;

							// Setup drawing quality
							cardCanvas.SmoothingMode = SmoothingMode.HighQuality;
							cardCanvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
							cardCanvas.CompositingQuality = CompositingQuality.HighQuality;

							StringFormat stringFormat = new StringFormat();
							stringFormat.Alignment = StringAlignment.Center;

							// Draw static labels
							cardCanvas.DrawString(strBrand, font1, Brushes.Black, cardSize.Width / 2, 0.1f, stringFormat);
							cardCanvas.DrawString(strModel, font2, Brushes.Black, cardSize.Width / 2, 0.4f, stringFormat);
							cardCanvas.DrawString(strColor, font1, Brushes.Black, cardSize.Width / 2, 0.7f, stringFormat);

							// Generate barcode image
							barcode.Value = (barcodeStartValue + cardIndex * barcodeValueStep).ToString();
							barcode.PreserveMinReadableSize = false;
							barcode.ResolutionX = barcode.ResolutionY = PrintingResolution;
							barcode.FitInto(cardSize.Width, 0.5f, UnitOfMeasure.Inch);
							Image barcodeImage = barcode.GetImage();
							// Draw barcode
							cardCanvas.DrawImage(barcodeImage, 0, 1.0f);
							// Draw barcode label
							cardCanvas.DrawString(barcode.Value, font3, Brushes.Black, cardSize.Width / 2, 1.4f, stringFormat);

							// Draw shoe size label
							cardCanvas.DrawString((shoeSizeStart + cardIndex * shoeSizeStep).ToString(), font4, Brushes.Black,
								cardSize.Width / 2, 1.7f, stringFormat);
						}

						// Draw card on the page
						pageCanvas.DrawImage(cardBitmap, column * cardSize.Width, row * cardSize.Height);

						cardIndex++;
					}
				}
			}

			return pageBitmap;
		}
	}
}
