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
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Bytescout.BarCode;

namespace BarcodeInCrystalReports
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			try
			{
				OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=products.mdb");
				OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products", connection);

				// fill dataset
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);

				connection.Close();

				// add virtual column into the result table
				dataSet.Tables[0].Columns.Add(new DataColumn("BarcodeImage", typeof(byte[])));

				// create barcode object
				Barcode barcode = new Barcode(SymbologyType.Code128);
				barcode.DrawCaption = false;

				// Fill BarcodeImage column with generated barcode image bytes
				foreach (DataRow row in dataSet.Tables[0].Rows)
				{
					// set barcode value
					barcode.Value = Convert.ToString(row["ID"]);

					// retrieve generated image bytes
					byte[] barcodeBytes = barcode.GetImageBytesWMF();

					// fill virtual column with generated image bytes
					row["BarcodeImage"] = barcodeBytes;
				}

				// set filled DataSet as report's data source
				CrystalReport11.SetDataSource(dataSet.Tables[0]);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
