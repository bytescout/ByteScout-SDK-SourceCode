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
