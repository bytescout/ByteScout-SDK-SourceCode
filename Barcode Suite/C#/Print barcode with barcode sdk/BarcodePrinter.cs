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
using System.Text;

using Bytescout.BarCode;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace printBarcodeCSharp2008
{
    class BarcodePrinter
    {
        private Barcode m_barcode = new Barcode();
        private float m_widthInches;
        private float m_heightInches;

        public void Print(SymbologyType type, string value, string caption, float widthInches, float heightInches)
        {
            m_barcode.Symbology = type;
            m_barcode.Value = value;
            m_barcode.Caption = caption;

            m_widthInches = widthInches;
            m_heightInches = heightInches;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = printDoc;

            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Point position = new Point(100, 100);

            m_barcode.FitInto(new SizeF(m_widthInches, m_heightInches), UnitOfMeasure.Inch);
            m_barcode.Draw(e.Graphics, position);
        }
    }
}
