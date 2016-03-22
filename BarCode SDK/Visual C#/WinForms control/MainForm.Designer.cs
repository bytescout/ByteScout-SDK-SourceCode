namespace BarcodeControlTester
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.barcodeControl = new Bytescout.BarCode.BarcodeControl();
            this.SuspendLayout();
            // 
            // barcodeControl
            // 
            this.barcodeControl.AddChecksum = true;
            this.barcodeControl.AddChecksumToCaption = true;
            this.barcodeControl.AdditionalCaption = "Codabar";
            this.barcodeControl.AdditionalCaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeControl.AdditionalCaptionPosition = Bytescout.BarCode.CaptionPosition.Above;
            this.barcodeControl.Angle = Bytescout.BarCode.RotationAngle.Degrees0;
            this.barcodeControl.BarHeight = 50;
            this.barcodeControl.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeControl.CaptionPosition = Bytescout.BarCode.CaptionPosition.Below;
            this.barcodeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeControl.DrawCaption = true;
            this.barcodeControl.HorizontalAlignment = Bytescout.BarCode.BarcodeHorizontalAlignment.Center;
            this.barcodeControl.Location = new System.Drawing.Point(0, 0);
            margins1.Bottom = 5;
            margins1.Left = 5;
            margins1.Right = 5;
            margins1.Top = 5;
            this.barcodeControl.Margins = margins1;
            this.barcodeControl.Name = "barcodeControl";
            this.barcodeControl.NarrowBarWidth = 3;
            symbologyOptions1.CodabarChecksumAlgorithm = Bytescout.BarCode.CodabarChecksumAlgorithm.AiimCheckDigit;
            symbologyOptions1.CodabarStartSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A;
            symbologyOptions1.CodabarStopSymbol = Bytescout.BarCode.CodabarSpecialSymbol.B;
            symbologyOptions1.Code128Alphabet = Bytescout.BarCode.Code128Alphabet.A;
            symbologyOptions1.DrawIntercharacterGap = true;
            symbologyOptions1.ShowStartStop = true;
            this.barcodeControl.Options = symbologyOptions1;
            this.barcodeControl.RenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.barcodeControl.Size = new System.Drawing.Size(450, 287);
            this.barcodeControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.barcodeControl.Symbology = Bytescout.BarCode.SymbologyType.Codabar;
            this.barcodeControl.TabIndex = 0;
            this.barcodeControl.Value = "012345";
            this.barcodeControl.VerticalAlignment = Bytescout.BarCode.BarcodeVerticalAlignment.Middle;
            this.barcodeControl.WideToNarrowRatio = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 287);
            this.Controls.Add(this.barcodeControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bytescout.BarCode.BarcodeControl barcodeControl;
    }
}

