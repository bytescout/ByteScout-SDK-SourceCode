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
using System.Windows.Forms;

namespace MultikeyPressEventHandling
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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

        private void PdfViewerControl1_PreProcessKey(object source, Keys keyData, ref bool handled)
        {
            if (keyData == (Keys.A | Keys.Shift))
            {
                MessageBox.Show("Shift-A");
                handled = true;
            }

            if (keyData == (Keys.A | Keys.Control | Keys.Alt | Keys.Shift))
            {
                MessageBox.Show("Ctrl-Alt-Shift-A");
                handled = true;
            }
        }
    }
}
