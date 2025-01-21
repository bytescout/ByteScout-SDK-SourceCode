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

namespace ScreenCapturing
{
	public partial class CustomMessageBox : Form
	{
		public bool DoNotShow = false;

		public CustomMessageBox(string title, string text)
		{
			InitializeComponent();

			base.Text = title;
			label1.Text = text;
		}

		private void cbDoNotAsk_CheckedChanged(object sender, EventArgs e)
		{
			DoNotShow = cbDoNotShow.Checked;
		}
	}
}
