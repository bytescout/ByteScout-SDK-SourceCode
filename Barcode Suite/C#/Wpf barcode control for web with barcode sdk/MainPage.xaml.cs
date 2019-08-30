//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bytescout.BarCode.WPF;
using Bytescout.BarCode;

namespace Bytescout.BarCode.WebDemo
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        #region Constants

        private const int BarHeight = 50;
        private const int PdfBarHeight = 6;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Controls event handlers
        /// <summary>
        /// Handles the SelectionChanged event of the cmbSymbologyType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void cmbSymbologyType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the Click event of the btnGenerate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the Click event of the btnSaveToFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        /// <summary>
        /// Handles the Checked event of the chkDrawCaptionFor2D control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkDrawCaptionFor2D_Checked(object sender, RoutedEventArgs e)
        {
            ctrlBarcodeControl.DrawCaptionFor2DBarcodes = chkDrawCaptionFor2D.IsChecked.Value;
        }

        /// <summary>
        /// Handles the Checked event of the chkAutoFitToContainer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkAutoFitToContainer_Checked(object sender, RoutedEventArgs e)
        {
            ctrlBarcodeControl.AutoFitToControlSize = chkAutoFitToContainer.IsChecked.Value;
        }

        /// <summary>
        /// Handles the Checked event of the chkCutUnusedSpace control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void chkCutUnusedSpace_Checked(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the txtValueToEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.TextChangedEventArgs"/> instance containing the event data.</param>
        private void txtValueToEncode_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateBarcode();
        }

        /// <summary>
        /// Handles the TextChanged event of the txtSupplementalValue control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.TextChangedEventArgs"/> instance containing the event data.</param>
        private void txtSupplementalValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateBarcode();
        }
        #endregion

        #region Private implementation

        public object[] GetObjectsFromEnum()
        {
            object[] objArray = new object[Enum.GetValues(typeof(SymbologyType)).Length];
            for (int i = 0; i < objArray.Length; i++)
            {
                objArray[i] = ((SymbologyType)Enum.GetValues(typeof(SymbologyType)).GetValue(i)).ToString();
            }
            return objArray;
        }

        private void UpdateBarcode()
        {
            SymbologyType symbology = (SymbologyType)Enum.GetValues(typeof(SymbologyType)).GetValue(this.cboSymbologyType.SelectedIndex);
            txtSymbologyDescription.Text = ctrlBarcodeControl.GetValueRestrictions(symbology);

            try
            {
                if (symbology == SymbologyType.EAN13 || symbology == SymbologyType.ISBN || symbology == SymbologyType.UPCA)
                {
                    txtSupplementalValue.IsEnabled = true;
                    lblSupplementalValue.IsEnabled = true;
                    txtSymbologyDescription.Text += " " + ctrlBarcodeControl.GetSupplementaryValueRestrictions();
                }
                else
                {
                    txtSupplementalValue.IsEnabled = false;
                    lblSupplementalValue.IsEnabled = false;
                }

                lblErrorMessage.Content = "";
                ctrlBarcodeControl.RegistrationKey = "XXXXXXXXXXXXXXXXXXx";
                ctrlBarcodeControl.RegistrationName = "YYYYYYYYYYYYYYYYYYYY";
                ctrlBarcodeControl.Symbology = symbology;
                ctrlBarcodeControl.SupplementValue = txtSupplementalValue.Text;
                ctrlBarcodeControl.Value = txtValueToEncode.Text;
                ctrlBarcodeControl.DrawCaptionFor2DBarcodes = chkDrawCaptionFor2D.IsChecked.Value;
                ctrlBarcodeControl.AutoFitToControlSize = chkAutoFitToContainer.IsChecked.Value;
                ctrlBarcodeControl.Caption = "";

                if (symbology == SymbologyType.PDF417 || symbology == SymbologyType.PDF417Truncated ||
                    symbology == SymbologyType.MacroPDF417 || symbology == SymbologyType.DataMatrix ||
                    symbology == SymbologyType.GS1_DataMatrix)
                {
                    ctrlBarcodeControl.BarHeight = PdfBarHeight;
                }
                else if (symbology == SymbologyType.MicroPDF417)
                {
                    ctrlBarcodeControl.BarHeight = PdfBarHeight / 2;
                }
                else
                {
                    ctrlBarcodeControl.BarHeight = BarHeight;
                }
            }
            catch (Exception)
            {
                lblErrorMessage.Content = "Value is invalid for current symbology. Please review value restrictions above.";
            }
        }

        private void SaveToFile()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "PNG Image|*.png|TIFF Image|*.tif;*.tiff|JPEG image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif";
            dlg.ValidateNames = true;
            dlg.FilterIndex = 1;
            dlg.OverwritePrompt = true;
            dlg.CheckPathExists = true;
            dlg.AddExtension = true;

            bool? result = dlg.ShowDialog(Application.Current.MainWindow);
            if (result.HasValue && result.Value)
            {
                try
                {
                    if (System.IO.Path.GetExtension(dlg.FileName).ToLowerInvariant() == ".emf")
                        throw new BarcodeException("Saving as EMF is disabled.\nYou should buy Barcode SDK for this.");

                    if (chkCutUnusedSpace.IsChecked.Value)
                    {
                        bool cut = ctrlBarcodeControl.CutUnusedSpace;
                        ctrlBarcodeControl.CutUnusedSpace = true;
                        ctrlBarcodeControl.SaveImage(dlg.FileName);
                        ctrlBarcodeControl.CutUnusedSpace = cut;
                    }
                    else
                    {
                        ctrlBarcodeControl.SaveImage(dlg.FileName);
                    }

                }
                catch (System.Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        #endregion

        #region Main window event handlers
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (object o in GetObjectsFromEnum())
            {
                this.cboSymbologyType.Items.Add(o);
            }
            this.cboSymbologyType.SelectedIndex = 0;
        }
        #endregion
    }
}
