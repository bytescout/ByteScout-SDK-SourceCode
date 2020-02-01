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
using System.IO;
using System.Text;
using System.Windows.Forms;
using Bytescout.Spreadsheet;

namespace ViewSpreadsheet
{
	public partial class Form1 : Form
	{
		private SpreadsheetControl _spreadsheetControl = null;

		private string _fileName = null;

		public Form1(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				_fileName = args[0];
			}

			if (_fileName != null)
			{
				OpenFile(_fileName);
			}

			InitializeComponent();

			Icon = Properties.Resources.xlsview;
		}

		private void OpenFile(string fileName)
		{
			Text = "Spreadsheet Viewer - " + fileName;
			
			Spreadsheet xls = new Spreadsheet();
			xls.RegistrationName = "demo";
			xls.RegistrationKey = "demo";

			try
			{
				xls.LoadFromFile(fileName);
			}
			catch (SpreadsheetProtectionPasswordRequired)
			{
				PasswordDialog passwordDialog = new PasswordDialog();

				if (passwordDialog.ShowDialog(this) == DialogResult.OK)
				{
					xls.LoadFromFile(fileName, CacheType.Memory, ",", Encoding.Default, passwordDialog.Password);
				}
				else
				{
					return;
				}
			}

			lblStub.Visible = false;

			if (_spreadsheetControl == null)
			{
				_spreadsheetControl = new SpreadsheetControl();
				_spreadsheetControl.Dock = DockStyle.Fill;

				Controls.Add(_spreadsheetControl);
				
				_spreadsheetControl.BringToFront();
				_spreadsheetControl.Focus();
			}

			Cursor = Cursors.WaitCursor;

			try
			{
				_spreadsheetControl.Spreadsheet = xls;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void tsmiOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				OpenFile(openFileDialog.FileName);
			}
		}

		private void tsmiAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spreadsheet Viewer\n\nwww.bytescout.com\n\nCopyright (c) Bytescout Software 2012", "About...");
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void tsmiVisitWebsite_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://www.bytescout.com");
		}

		private void tsbPromo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://bytescout.com/products/developer/spreadsheetsdk/bytescoutspreadsheetsdk.html");
		}
	}
}
