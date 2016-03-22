//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Drawing;
using System.Text;
using System.Windows;
using Bytescout.PDFExtractor;

namespace WpfApplication1
{
	public partial class MainWindow : Window
	{
		private string _pdfFile;
		private TextExtractor extractor;

		public MainWindow()
		{
			InitializeComponent();

			extractor = new TextExtractor();
		}

		private void Button_Load(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
			dlg.DefaultExt = ".pdf";
			dlg.Filter = "PDF documents (.pdf)|*.pdf";

			bool? result = dlg.ShowDialog();

			if (result == true)
			{
				try
				{
					extractor.LoadDocumentFromFile(dlg.FileName);
					_pdfFile = dlg.FileName;
					Title = _pdfFile;
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.ToString());
				}
			}
		}

		private void Button_Extract(object sender, RoutedEventArgs e)
		{
			if (_pdfFile != null)
			{
				string text = extractor.GetText(0, 0); // extract from the first page only (for demonstration purposes)

				textBox1.Text = text;
			}
		}

		private void Button_Find(object sender, RoutedEventArgs e)
		{
			if (textBoxFind.Text.Length > 0)
			{
				StringBuilder builder = new StringBuilder();

				builder.AppendLine("Searching for \"" + textBoxFind.Text + "\"");

				if (extractor.Find(0, textBoxFind.Text, false))
				{
					do
					{
						builder.AppendLine("Found on page 0 at location " + extractor.FoundText.Location.ToString());

					}
					while (extractor.FindNext());
				}

				builder.AppendLine("Finished.");

				textBox1.Text = builder.ToString();
			}
		}
	}
}
