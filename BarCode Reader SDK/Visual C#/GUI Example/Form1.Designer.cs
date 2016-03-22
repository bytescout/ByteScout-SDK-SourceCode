namespace GuiExample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxAll1D = new System.Windows.Forms.CheckBox();
            this.checkBoxAll2D = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image or PDF file name:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(792, 23);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(78, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBarcode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(138, 113);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBarcode.TabIndex = 2;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(12, 25);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(774, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // textBoxResults
            // 
            this.textBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResults.Location = new System.Drawing.Point(12, 486);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResults.Size = new System.Drawing.Size(858, 102);
            this.textBoxResults.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Found barcodes:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image and PDF files|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All files|*" +
                ".*";
            // 
            // checkBoxAll1D
            // 
            this.checkBoxAll1D.AutoSize = true;
            this.checkBoxAll1D.Checked = true;
            this.checkBoxAll1D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll1D.Location = new System.Drawing.Point(12, 51);
            this.checkBoxAll1D.Name = "checkBoxAll1D";
            this.checkBoxAll1D.Size = new System.Drawing.Size(359, 17);
            this.checkBoxAll1D.TabIndex = 1;
            this.checkBoxAll1D.Text = "One-dimensional (linear) barcodes (Code39, Code128, GS1, EAN, etc.)";
            this.checkBoxAll1D.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll2D
            // 
            this.checkBoxAll2D.AutoSize = true;
            this.checkBoxAll2D.Checked = true;
            this.checkBoxAll2D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll2D.Location = new System.Drawing.Point(12, 74);
            this.checkBoxAll2D.Name = "checkBoxAll2D";
            this.checkBoxAll2D.Size = new System.Drawing.Size(363, 17);
            this.checkBoxAll2D.TabIndex = 2;
            this.checkBoxAll2D.Text = "Two-dimensional barcodes (Aztec, PDF417, QR Code, Datamatrix, etc.)";
            this.checkBoxAll2D.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(742, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 40);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search Barcodes";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchBarcodes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxBarcode);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 370);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxAll2D);
            this.Controls.Add(this.checkBoxAll1D);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBoxAll1D;
        private System.Windows.Forms.CheckBox checkBoxAll2D;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
    }
}

