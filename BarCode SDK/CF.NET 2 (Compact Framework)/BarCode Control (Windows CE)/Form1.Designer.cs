namespace GUITest.WinCE
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
            this.barcodeControlCompact1 = new Bytescout.BarCode.BarcodeControlWinCE();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.barcodeControlCompact1.CaptionFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.barcodeControlCompact1.CaptionPosition = Bytescout.BarCode.CaptionPosition.Below;
            this.barcodeControlCompact1.DrawCaption = true;
            this.barcodeControlCompact1.ForeColor = System.Drawing.Color.Black;
            this.barcodeControlCompact1.HorizontalAlignment = Bytescout.BarCode.BarcodeHorizontalAlignment.Center;
            this.barcodeControlCompact1.Location = new System.Drawing.Point(3, 80);
            this.barcodeControlCompact1.Margins = margins1;
            this.barcodeControlCompact1.Name = "barcodeControlCompact1";
            this.barcodeControlCompact1.NarrowBarWidth = 3;
            this.barcodeControlCompact1.Options = symbologyOptions1;
            this.barcodeControlCompact1.RegistrationKey = "";
            this.barcodeControlCompact1.RegistrationName = "";
            this.barcodeControlCompact1.Size = new System.Drawing.Size(226, 181);
            this.barcodeControlCompact1.SupplementValue = "";
            this.barcodeControlCompact1.Symbology = Bytescout.BarCode.SymbologyType.Code39;
            this.barcodeControlCompact1.TabIndex = 0;
            this.barcodeControlCompact1.Value = "";
            this.barcodeControlCompact1.VerticalAlignment = Bytescout.BarCode.BarcodeVerticalAlignment.Middle;
            this.barcodeControlCompact1.WideToNarrowRatio = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.Text = "Please enter text:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeControlCompact1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bytescout.BarCode.BarcodeControlWinCE barcodeControlCompact1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

