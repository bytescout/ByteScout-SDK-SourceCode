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
