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


using System.Drawing;
using System.Windows.Forms;
using Bytescout.BarCode;

// This application demonstrates two ways how you can show the barcode on a form: 
// 1. using PictureBox control;
// 2. painting it on a Panel control.
namespace DisplayBarcodeOnForm
{
    public partial class Form1 : Form
    {
        private Barcode _barcode = null;

        public Form1()
        {
            InitializeComponent();

            // Create Barcode Generator instance
            _barcode = new Barcode();
            _barcode.RegistrationName = "demo";
            _barcode.RegistrationKey = "demo";

            // Setup barcode
            _barcode.Symbology = SymbologyType.QRCode;
            _barcode.Value = "Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing";

            // Put the barcode image to PictureBox
            pictureBox1.Image = _barcode.GetImage();
        }

        // Paint the barcode image on a Panel control
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image barcodeImage = _barcode.GetImage();
            
            e.Graphics.DrawImage(barcodeImage, 0, 0);
        }
    }
}
