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
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Bytescout.Spreadsheet;

namespace ImportExportFromWinFormsDataGrid.CSharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			dataGrid1.DataSource = GetDemoDataTable();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			try
			{
				const string fileName = "CSharpImportFromDataTable.xls";

				// retrieve DataTable from DataGrid
				DataTable dataTable = (DataTable) dataGrid1.DataSource;

				// Create spreadsheet
				Spreadsheet spreadsheet = new Spreadsheet();

				// Import data from DataTable into spreadheet
				spreadsheet.ImportFromDataTable(dataTable);

				// Insert row with column captions
				Worksheet worksheet = spreadsheet.Worksheets[0];
				worksheet.Rows.Insert(0);
				for (int colIndex = 0; colIndex < dataTable.Columns.Count; colIndex++)
				{
					worksheet.Cell(0, colIndex).Value = dataTable.Columns[colIndex].Caption;
				}

				// Save the spreadsheet
				if (File.Exists(fileName)) File.Delete(fileName);
				spreadsheet.SaveAs(fileName);

				// Close spreadsheet
				spreadsheet.Close();

				// Open the spreadsheet
				Process.Start(fileName);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Cursor = Cursors.WaitCursor;

				try
				{
					// Create spreadsheet
					Spreadsheet spreadsheet = new Spreadsheet();

					// Load spreadsheet from file
					spreadsheet.LoadFromFile(openFileDialog1.FileName);

					// Export to DataGrid
					DataTable dataTable = spreadsheet.ExportToDataTable();
					dataGrid1.DataSource = dataTable;
				}
				finally
				{
					Cursor = Cursors.Default;
				}
			}
		}

		/// <summary>
		/// Fills a data table of the periodic table of elements.
		/// </summary>
		private DataTable GetDemoDataTable()
		{
			DataTable periodicTable = new DataTable("PeriodicTable");

			periodicTable.Columns.Add("Name", typeof(string));
			periodicTable.Columns.Add("Symbol", typeof(string));
			periodicTable.Columns.Add("AtomicNumber", typeof(int));

			DataRow dr = periodicTable.Rows.Add();
			dr[0] = "Hydrogen";
			dr[1] = "H";
			dr[2] = "1";

			dr = periodicTable.Rows.Add();
			dr[0] = "Helium";
			dr[1] = "He";
			dr[2] = "2";

			dr = periodicTable.Rows.Add();
			dr[0] = "Lithium";
			dr[1] = "Li";
			dr[2] = "3";

			dr = periodicTable.Rows.Add();
			dr[0] = "Beryllium";
			dr[1] = "Be";
			dr[2] = "4";

			dr = periodicTable.Rows.Add();
			dr[0] = "Boron";
			dr[1] = "B";
			dr[2] = "5";

			dr = periodicTable.Rows.Add();
			dr[0] = "Carbon";
			dr[1] = "C";
			dr[2] = "6";

			return periodicTable;
		}
	}
}
