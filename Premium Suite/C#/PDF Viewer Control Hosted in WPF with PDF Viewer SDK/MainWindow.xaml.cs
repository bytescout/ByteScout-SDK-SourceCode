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
using System.Drawing;
using System.Windows;

namespace PdfViewerInWpf
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// Load a sample document on startup
			pdfViewerControl1.InputFile = "sample.pdf";
		}

		private void menuItemOpen_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
			{
				Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
			};
			
			bool? result = dlg.ShowDialog();

			if (result == true)
				pdfViewerControl1.InputFile = dlg.FileName;
		}
	}
}
