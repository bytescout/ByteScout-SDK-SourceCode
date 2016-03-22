namespace GUITest.PPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bytescout.BarCode.Margins margins1 = new Bytescout.BarCode.Margins();
            Bytescout.BarCode.SymbologyOptions symbologyOptions1 = new Bytescout.BarCode.SymbologyOptions();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.barcodeControlCompact1 = new Bytescout.BarCode.BarcodeControlPPC();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.Text = "Enter text";
            // 
            // barcodeControlCompact1
            // 
            this.barcodeControlCompact1.AddChecksum = false;
            this.barcodeControlCompact1.AddChecksumToCaption = false;
            this.barcodeControlCompact1.AdditionalCaption = "";
            this.barcodeControlCompact1.AdditionalCaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.barcodeControlCompact1.AdditionalCaptionPosition = Bytescout.BarCode.CaptionPosition.Above;
            this.barcodeControlCompact1.BackColor = System.Drawing.Color.White;
            this.barcodeControlCompact1.BarHeight = 50;
            this.barcodeControlCompact1.CaptionPosition = Bytescout.BarCode.CaptionPosition.Below;
            this.barcodeControlCompact1.DrawCaption = true;
            this.barcodeControlCompact1.ForeColor = System.Drawing.Color.Black;
            this.barcodeControlCompact1.HorizontalAlignment = Bytescout.BarCode.BarcodeHorizontalAlignment.Center;
            this.barcodeControlCompact1.Location = new System.Drawing.Point(43, 80);
            margins1.Bottom = 0;
            margins1.Left = 0;
            margins1.Right = 0;
            margins1.Top = 0;
            this.barcodeControlCompact1.Margins = margins1;
            this.barcodeControlCompact1.Name = "barcodeControlCompact1";
            this.barcodeControlCompact1.NarrowBarWidth = 3;
            symbologyOptions1.AztecErrorCorrectionLevel = Bytescout.BarCode.AztecErrorCorrectionLevel.Auto;
            symbologyOptions1.AztecSymbolSize = 0;
            symbologyOptions1.CodabarChecksumAlgorithm = Bytescout.BarCode.CodabarChecksumAlgorithm.Modulo9;
            symbologyOptions1.CodabarStartSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A;
            symbologyOptions1.CodabarStopSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A;
            symbologyOptions1.Code128Alphabet = Bytescout.BarCode.Code128Alphabet.Auto;
            symbologyOptions1.DataMatrixCompactionMode = Bytescout.BarCode.DataMatrixCompactionMode.Auto;
            symbologyOptions1.DataMatrixSize = Bytescout.BarCode.DataMatrixSize.AutoSquareSize;
            symbologyOptions1.DrawIntercharacterGap = true;
            symbologyOptions1.ISBNAutoCaption = true;
            symbologyOptions1.PDF417ErrorCorrectionLevel = Bytescout.BarCode.PDF417ErrorCorrectionLevel.Auto;
            symbologyOptions1.PDF417MinimumColumnCount = 0;
            symbologyOptions1.QREncodeHint = Bytescout.BarCode.QREncodeHint.Mode8;
            symbologyOptions1.QRErrorCorrectionLevel = Bytescout.BarCode.QRErrorCorrectionLevel.Low;
            symbologyOptions1.QRVersion = 0;
            symbologyOptions1.ShowStartStop = false;
            symbologyOptions1.SupplementSpace = 5;
            this.barcodeControlCompact1.Options = symbologyOptions1;
            this.barcodeControlCompact1.RegistrationKey = "";
            this.barcodeControlCompact1.RegistrationName = "";
            this.barcodeControlCompact1.Size = new System.Drawing.Size(150, 150);
            this.barcodeControlCompact1.SupplementValue = "";
            this.barcodeControlCompact1.Symbology = Bytescout.BarCode.SymbologyType.Code39;
            this.barcodeControlCompact1.TabIndex = 1;
            this.barcodeControlCompact1.Value = "";
            this.barcodeControlCompact1.VerticalAlignment = Bytescout.BarCode.BarcodeVerticalAlignment.Middle;
            this.barcodeControlCompact1.WideToNarrowRatio = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.barcodeControlCompact1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bytescout.BarCode.BarcodeControlPPC barcodeControlCompact1;
    }
}

