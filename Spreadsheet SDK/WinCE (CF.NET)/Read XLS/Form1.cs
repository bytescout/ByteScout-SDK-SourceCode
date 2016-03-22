//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using System.Windows.Forms;
using Bytescout.Spreadsheet;

namespace ReadXLS
{
	public partial class Form1 : Form
	{
		private ListView _listview;

		public Form1()
		{
			InitializeComponent();

			// Create ListView control
			_listview = new ListView();
			_listview.Dock = DockStyle.Fill;
			_listview.View = View.Details;
			_listview.FullRowSelect = true;

			// Create two columns
			_listview.Columns.Add("Column 1", 100, HorizontalAlignment.Left);
			_listview.Columns.Add("Column 2", 140, HorizontalAlignment.Left);

			// Add created control to the form
			Controls.Add(_listview);

			// Read XLS file

			Spreadsheet document = null;

			try
			{
				// Get current directory
				String currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

				// Load XLS document from the current directory
                document = new Spreadsheet();
                document.LoadFromFile(currentDirectory + "\\SimpleReport.xls");

				Worksheet worksheet = document.Workbook.Worksheets[0];

				// Read cell values and put them to the list view
				for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
				{
					ListViewItem item = new ListViewItem((string) worksheet.Cell(row, 0).Value);
					item.SubItems.Add((string) worksheet.Cell(row, 1).Value);
					_listview.Items.Add(item);
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (document != null) document.Dispose();
			}
		}
	}
}
