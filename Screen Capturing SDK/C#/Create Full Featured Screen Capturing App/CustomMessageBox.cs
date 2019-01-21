//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
