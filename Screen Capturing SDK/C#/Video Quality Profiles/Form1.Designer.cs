namespace ScreenCapture
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
            this._txtOutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._numWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._numHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._numFramerate = new System.Windows.Forms.NumericUpDown();
            this._cmbQuality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._lblBitrate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._numEncodingThreads = new System.Windows.Forms.NumericUpDown();
            this._btnScreenCapture = new System.Windows.Forms.Button();
            this._btnPauseScreenCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFramerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numEncodingThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtOutputFile
            // 
            this._txtOutputFile.Location = new System.Drawing.Point(16, 31);
            this._txtOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this._txtOutputFile.Name = "_txtOutputFile";
            this._txtOutputFile.Size = new System.Drawing.Size(300, 22);
            this._txtOutputFile.TabIndex = 0;
            this._txtOutputFile.Text = "output.wmv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output file";
            // 
            // _numWidth
            // 
            this._numWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numWidth.Location = new System.Drawing.Point(16, 96);
            this._numWidth.Margin = new System.Windows.Forms.Padding(4);
            this._numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numWidth.Name = "_numWidth";
            this._numWidth.Size = new System.Drawing.Size(160, 22);
            this._numWidth.TabIndex = 2;
            this._numWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // _numHeight
            // 
            this._numHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numHeight.Location = new System.Drawing.Point(184, 96);
            this._numHeight.Margin = new System.Windows.Forms.Padding(4);
            this._numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numHeight.Name = "_numHeight";
            this._numHeight.Size = new System.Drawing.Size(160, 22);
            this._numHeight.TabIndex = 4;
            this._numHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Framerate";
            // 
            // _numFramerate
            // 
            this._numFramerate.DecimalPlaces = 2;
            this._numFramerate.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numFramerate.Location = new System.Drawing.Point(352, 96);
            this._numFramerate.Margin = new System.Windows.Forms.Padding(4);
            this._numFramerate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._numFramerate.Name = "_numFramerate";
            this._numFramerate.Size = new System.Drawing.Size(160, 22);
            this._numFramerate.TabIndex = 6;
            this._numFramerate.ThousandsSeparator = true;
            this._numFramerate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // _cmbQuality
            // 
            this._cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbQuality.FormattingEnabled = true;
            this._cmbQuality.Location = new System.Drawing.Point(520, 96);
            this._cmbQuality.Margin = new System.Windows.Forms.Padding(4);
            this._cmbQuality.Name = "_cmbQuality";
            this._cmbQuality.Size = new System.Drawing.Size(240, 24);
            this._cmbQuality.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quality";
            // 
            // _lblBitrate
            // 
            this._lblBitrate.Location = new System.Drawing.Point(352, 145);
            this._lblBitrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblBitrate.Name = "_lblBitrate";
            this._lblBitrate.Size = new System.Drawing.Size(408, 51);
            this._lblBitrate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of encoding threads:";
            // 
            // _numEncodingThreads
            // 
            this._numEncodingThreads.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._numEncodingThreads.Location = new System.Drawing.Point(217, 142);
            this._numEncodingThreads.Margin = new System.Windows.Forms.Padding(4);
            this._numEncodingThreads.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._numEncodingThreads.Name = "_numEncodingThreads";
            this._numEncodingThreads.Size = new System.Drawing.Size(127, 22);
            this._numEncodingThreads.TabIndex = 14;
            this._numEncodingThreads.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _btnScreenCapture
            // 
            this._btnScreenCapture.Location = new System.Drawing.Point(19, 200);
            this._btnScreenCapture.Margin = new System.Windows.Forms.Padding(4);
            this._btnScreenCapture.Name = "_btnScreenCapture";
            this._btnScreenCapture.Size = new System.Drawing.Size(163, 28);
            this._btnScreenCapture.TabIndex = 16;
            this._btnScreenCapture.Text = "Screen capture video";
            this._btnScreenCapture.UseVisualStyleBackColor = true;
            this._btnScreenCapture.Click += new System.EventHandler(this._btnScreenCapture_Click);
            // 
            // _btnPauseScreenCapture
            // 
            this._btnPauseScreenCapture.Location = new System.Drawing.Point(205, 200);
            this._btnPauseScreenCapture.Margin = new System.Windows.Forms.Padding(4);
            this._btnPauseScreenCapture.Name = "_btnPauseScreenCapture";
            this._btnPauseScreenCapture.Size = new System.Drawing.Size(163, 28);
            this._btnPauseScreenCapture.TabIndex = 19;
            this._btnPauseScreenCapture.Text = "Pause Screen Capture";
            this._btnPauseScreenCapture.UseVisualStyleBackColor = true;
            this._btnPauseScreenCapture.Visible = false;
            this._btnPauseScreenCapture.Click += new System.EventHandler(this._btnPauseScreenCapture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 241);
            this.Controls.Add(this._btnPauseScreenCapture);
            this.Controls.Add(this._btnScreenCapture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._numEncodingThreads);
            this.Controls.Add(this._lblBitrate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cmbQuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._numFramerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._numHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._numWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtOutputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Screen Capture Video";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFramerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numEncodingThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _numFramerate;
        private System.Windows.Forms.ComboBox _cmbQuality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lblBitrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _numEncodingThreads;
        private System.Windows.Forms.Button _btnScreenCapture;
        private System.Windows.Forms.Button _btnPauseScreenCapture;
    }
}

