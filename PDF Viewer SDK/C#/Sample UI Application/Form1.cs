//*******************************************************************
//       ByteScout PDF Viewer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Windows.Forms;

namespace Sample_UI_Application
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
	}
}
