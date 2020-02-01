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


using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;
using Bytescout.PDFRenderer;

namespace SearchAndHighlightExample
{
	class Program
	{
		static void Main(string[] args)
		{
			const string inputFile = @"sample.pdf";
			const int pageIndex = 0;
			const float renderingResolution = 300f;
			const string searchPattern = "\\d+\\.\\d+";

			// Prepare TextExtractor
			using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
			{
				textExtractor.RegexSearch = true;
				textExtractor.LoadDocumentFromFile(inputFile);

				// Preapre RasterRenderer
				using (RasterRenderer rasterRenderer = new RasterRenderer("demo", "demo"))
				{
					rasterRenderer.LoadDocumentFromFile(inputFile);

					// Render document page to image
					Image image = rasterRenderer.GetImage(pageIndex, renderingResolution);

					// Prepare highlight brush
					Brush highlightBrush = new SolidBrush(Color.FromArgb(128, Color.Yellow));

					using (Graphics graphics = Graphics.FromImage(image))
					{
						// Search for pattern and paint found piecese
						if (textExtractor.Find(pageIndex, searchPattern, caseSensitive: false))
						{
							do
							{
								foreach (var foundPiece in textExtractor.FoundText.Elements)
								{
									// Convert from document Points to pixels
									Rectangle pixelRect = new Rectangle(
										(int) (foundPiece.Bounds.Left / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Top / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Width / 72f * renderingResolution),
										(int) (foundPiece.Bounds.Height / 72f * renderingResolution)
									);

									// Paint rectangle
									graphics.FillRectangle(highlightBrush, pixelRect);
								}
							} while (textExtractor.FindNext());
						}
					}

					image.Save("result.png");
					Process.Start("result.png");
				}
			}
		}
	}
}
