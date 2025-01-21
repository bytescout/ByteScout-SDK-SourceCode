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
using Bytescout.PDF;
using System.Drawing;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;

// This example demonstrates how to draw invisible text.

namespace DrawTransparentText
{
    class Program
    {
        static void Main()
        {
            // Sample input text chunks
            List<TextChunk> textChunks = new List<TextChunk>()
            {
                new TextChunk("Test Document for Optical Character Recognition (OCR)", new RectangleF(178.08f, 81.12f, 235.92f, 6.96f)),
                new TextChunk("Test Document for Optical Character Recognition (OCR)", new RectangleF(178.08f, 103.44f, 235.92f, 6.96f))
            };


            // Load document
            var pdfDocument = new Document(@".\sample_scanned.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            for (int i = 0; i < pdfDocument.Pages.Count; i++)
            {
                DrawTransparentText(pdfDocument.Pages[i], textChunks, "Times", 7f);
            }

            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();
        }

        static void DrawTransparentText(Page documentPage, List<TextChunk> textChunks, string fontName = "Arial", float maxFontSize = 4f)
        {
            var stringFormat = new StringFormat();
            var transparentBrush = new SolidBrush { Opacity = 0 };
            
            foreach (var textChunk in textChunks)
            {
                Font font = new Font(fontName, Math.Max(textChunk.Rect.Height, maxFontSize));

                // Fit drawn text into chunk rectangle
                float renderedWidth = font.GetTextWidth(textChunk.Text);
                stringFormat.Scaling = textChunk.Rect.Width / renderedWidth * 100;

                documentPage.Canvas.DrawString(textChunk.Text, font, transparentBrush, 
                    textChunk.Rect.Left, textChunk.Rect.Top, stringFormat);
            }
        }
    }

    class TextChunk
    {
        public string Text { get; set; }
        public RectangleF Rect { get; set; }

        public TextChunk(string text, RectangleF rect)
        {
            Text = text;
            Rect = rect;
        }
    }
}
