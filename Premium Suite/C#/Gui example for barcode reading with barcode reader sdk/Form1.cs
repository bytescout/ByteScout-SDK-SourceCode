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
using System.Windows.Forms;
using Bytescout.BarCodeReader;

namespace GuiExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String _fileName = "";

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _fileName = openFileDialog.FileName;
                textBoxFileName.Text = _fileName;

                try
                {
                    Bitmap bmp = new Bitmap(_fileName);
                    pictureBoxBarcode.Image = bmp;
                }
                catch (Exception)
                {
                    pictureBoxBarcode.Image = null;
                }
            }
        }

        private void buttonSearchBarcodes_Click(object sender, EventArgs e)
        {
            FindBarcodes();
        }

        private void FindBarcodes()
        {
            if (String.IsNullOrEmpty(_fileName))
                return;

            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";

            if (checkBoxAll1D.Checked)
                reader.BarcodeTypesToFind.All1D = true;
            if (checkBoxAll2D.Checked)
                reader.BarcodeTypesToFind.All2D = true;

            Cursor = Cursors.WaitCursor;

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

            FoundBarcode[] foundBarcodes = reader.ReadFrom(_fileName);
            ResetCursor();

            List<string> data = new List<string>();

            if (foundBarcodes.Length == 0)
            {
                data.Add("No barcodes found");
            }
            else
            {
                foreach (FoundBarcode barcode in foundBarcodes)
                    data.Add(String.Format("Type \"{0}\" and value \"{1}\"", barcode.Type, barcode.Value));
            }
			
			// Cleanup
			reader.Dispose();

            textBoxResults.Lines = data.ToArray();
        }
    }
}
