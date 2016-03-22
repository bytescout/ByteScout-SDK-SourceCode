namespace ScreenCapturingClient
{
    partial class ctrlImageOverlay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nmTop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmLeft = new System.Windows.Forms.NumericUpDown();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top";
            // 
            // nmTop
            // 
            this.nmTop.Location = new System.Drawing.Point(66, 18);
            this.nmTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTop.Name = "nmTop";
            this.nmTop.Size = new System.Drawing.Size(57, 20);
            this.nmTop.TabIndex = 6;
            this.nmTop.ValueChanged += new System.EventHandler(this.nmTop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // nmLeft
            // 
            this.nmLeft.Location = new System.Drawing.Point(3, 18);
            this.nmLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmLeft.Name = "nmLeft";
            this.nmLeft.Size = new System.Drawing.Size(57, 20);
            this.nmLeft.TabIndex = 4;
            this.nmLeft.ValueChanged += new System.EventHandler(this.nmLeft_ValueChanged);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(7, 93);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(56, 17);
            this.chkVisible.TabIndex = 14;
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Image filename";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(4, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(445, 20);
            this.txtFileName.TabIndex = 15;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(455, 56);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(33, 23);
            this.btnBrowseFile.TabIndex = 17;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // ctrlImageOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmLeft);
            this.Name = "ctrlImageOverlay";
            this.Size = new System.Drawing.Size(525, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmLeft;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowseFile;
    }
}
