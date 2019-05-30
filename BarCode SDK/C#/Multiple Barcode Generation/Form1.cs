//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Windows.Forms;
using Bytescout.BarCode;

namespace MultipleBarcodeGeneration
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			foreach (SymbologyType st in Enum.GetValues(typeof(SymbologyType)))
			{
				cmbBarcodeType.Items.Add(st);
			}

			cmbBarcodeType.SelectedIndex = 0;
			cmbImageFormat.SelectedIndex = 0;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select output folder";

			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			string fileNameTemplate = tbFileNameTemplate.Text + "." + Convert.ToString(cmbImageFormat.SelectedItem).ToLower();
			uint counterStartAt = (uint) nudCounterStartAt.Value;
			uint counterStepBy = (uint) nudCounterStepBy.Value;
			uint counterDigits = Convert.ToUInt32(cmbCounterDigits.Text);

			if (!fileNameTemplate.Contains("[N]"))
			{
				MessageBox.Show("File name template does not contain the counter placeholder [N]");
				return;
			}

			string valueTemplate = tbValueTemplate.Text;
			uint valueStartAt = (uint) nudValueStartAt.Value;
			uint valueStepBy = (uint) nudValueStepBy.Value;
			uint valueEndAt = (uint) nudValueEndAt.Value;
			uint valueDigits = Convert.ToUInt32(cmbValueDigits.Text);

			if (!valueTemplate.Contains("[N]"))
			{
				MessageBox.Show("Barcode value template does not contain the counter placeholder [N]");
				return;
			}

			Cursor = Cursors.WaitCursor;
			progressBar.Visible = true;
			btnGenerate.Text = "Stop";

			try
			{
				progressBar.Value = (int) valueStartAt;
				progressBar.Minimum = (int) valueStartAt;
				progressBar.Maximum = (int) valueEndAt;
				progressBar.Step = (int) valueStepBy;

				GenerateBarcodes(valueTemplate, valueStartAt, valueEndAt, valueStepBy, valueDigits, fileNameTemplate, 
					counterStartAt, counterStepBy, counterDigits, folderBrowserDialog.SelectedPath);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
			finally
			{
				Cursor = Cursors.Default;
				progressBar.Visible = false;
				btnGenerate.Text = "Generate multiple barcodes";
			}
		}

		private void GenerateBarcodes(string valueTemplate, uint valueStartAt, uint valueEndAt, uint valueStepBy, uint valueDigits, 
			string fileNameTemplate, uint counterStartAt, uint counterStepBy, uint counterDigits, string outputFolder)
		{
			Barcode barcode = new Barcode();
			barcode.RegistrationKey = "demo";
			barcode.RegistrationName = "demo";

			barcode.Symbology = (SymbologyType) cmbBarcodeType.SelectedItem;
			// Set up additional barcode properties here.
			//barcode.AdditionalCaption = "...";

			uint c = counterStartAt;

			for (uint i = valueStartAt; i <= valueEndAt; i += valueStepBy)
			{
				string value = String.Format("{0:D" + valueDigits + "}", i);
				string counter = String.Format("{0:D" + counterDigits + "}", c);
				string fileName = fileNameTemplate.Replace("[N]", counter);

				progressBar.PerformStep();

				barcode.Value = valueTemplate.Replace("[N]", value);

				barcode.SaveImage(Path.Combine(outputFolder, fileName));

				c += counterStepBy;

				Application.DoEvents();
			}
		}
	}
}
