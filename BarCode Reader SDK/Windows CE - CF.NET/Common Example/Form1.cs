//*******************************************************************
//       ByteScout BarCode Reader SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Bytescout.BarCodeReader;

namespace GUITest.WinCE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			textBoxResult.Text = "";

			DialogResult result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;

				Reader reader = new Reader();

				// limit to 1D barcodes search only (2d are not included to speed up search)
				// change to SymbologyFilter.FindAll to scan for all possible 1D and 2D barcodes
				reader.TypeToFind = SymbologyFilter.FindAll1D;

				reader.ReadFrom(fileName);

				if (reader.FoundBarcodes.Length != 0)
				{
					foreach (FoundBarcode barcode in reader.FoundBarcodes)
						textBoxResult.Text += String.Format("Type '{0}' and value '{1}' ", barcode.Type, barcode.Value);
				}
				else
					textBoxResult.Text = "No barcodes found";
			}
		}
	}
}
