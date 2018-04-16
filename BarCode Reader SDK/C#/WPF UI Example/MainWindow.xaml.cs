//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Bytescout.BarCodeReader;

namespace ReadBarcodeFromImage
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Select image file
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Supported formats (*.bmp;*.gif;*.tif;*.png;*.jpg;*.pdf)|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All Files|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                tbFileName.Text = dlg.FileName;
                tbFoundBarcodes.Text = "";
                imageContainer.Source = null;

                try
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(dlg.FileName, UriKind.Absolute);
                    bitmapImage.EndInit();

                    imageContainer.Source = bitmapImage;
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
        {
            // Create barcode reader instance
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
            reader.RegistrationKey = "demo";
        
            // Specify barcode types to find
            reader.BarcodeTypesToFind.All = true;
            // Select specific barcode types to speed up the decoding process and avoid false positives.

            // Show wait cursor
            Mouse.OverrideCursor = Cursors.Wait;
            
            try
            {
                // Search for barcodes
                reader.ReadFrom(tbFileName.Text);
            }
            finally
            {
                Mouse.OverrideCursor = null;
            }

            // Display found barcode inforamtion:

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < reader.FoundBarcodes.Length; i++)
            {
                FoundBarcode barcode = reader.FoundBarcodes[i];
                stringBuilder.AppendFormat("{0}) Type: {1}; Value: {2}.\r\n", i + 1, barcode.Type, barcode.Value);
            }

            tbFoundBarcodes.Text = stringBuilder.ToString();
        }
    }
}
