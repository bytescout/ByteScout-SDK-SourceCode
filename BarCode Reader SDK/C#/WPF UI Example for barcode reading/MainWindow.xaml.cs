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
            
            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

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
			
			// Cleanup
			reader.Dispose();
        }
    }
}
