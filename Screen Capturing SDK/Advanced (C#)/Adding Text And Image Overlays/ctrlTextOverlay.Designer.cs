namespace ScreenCapturingClient
{
    partial class ctrlTextOverlay
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
            this.nmLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTop = new System.Windows.Forms.NumericUpDown();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.pnlBackColor = new System.Windows.Forms.Panel();
            this.chkBackColor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).BeginInit();
            this.SuspendLayout();
            // 
            // nmLeft
            // 
            this.nmLeft.Location = new System.Drawing.Point(3, 23);
            this.nmLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmLeft.Name = "nmLeft";
            this.nmLeft.Size = new System.Drawing.Size(57, 20);
            this.nmLeft.TabIndex = 0;
            this.nmLeft.ValueChanged += new System.EventHandler(this.nmLeft_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top";
            // 
            // nmTop
            // 
            this.nmTop.Location = new System.Drawing.Point(66, 23);
            this.nmTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTop.Name = "nmTop";
            this.nmTop.Size = new System.Drawing.Size(57, 20);
            this.nmTop.TabIndex = 2;
            this.nmTop.ValueChanged += new System.EventHandler(this.nmTop_ValueChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(129, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(309, 20);
            this.txtText.TabIndex = 4;
            this.txtText.Text = "Some overlay text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Font";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(3, 65);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(86, 20);
            this.txtFont.TabIndex = 6;
            this.txtFont.Text = "Arial";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(95, 63);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(28, 23);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.IndianRed;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Location = new System.Drawing.Point(129, 65);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(28, 20);
            this.pnlColor.TabIndex = 11;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(163, 63);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(28, 23);
            this.btnColor.TabIndex = 12;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(4, 111);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(56, 17);
            this.chkVisible.TabIndex = 13;
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(444, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Enabled = false;
            this.btnBackColor.Location = new System.Drawing.Point(249, 63);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(28, 23);
            this.btnBackColor.TabIndex = 17;
            this.btnBackColor.Text = "...";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.BackColor = System.Drawing.Color.IndianRed;
            this.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackColor.Enabled = false;
            this.pnlBackColor.Location = new System.Drawing.Point(218, 65);
            this.pnlBackColor.Name = "pnlBackColor";
            this.pnlBackColor.Size = new System.Drawing.Size(28, 20);
            this.pnlBackColor.TabIndex = 16;
            // 
            // chkBackColor
            // 
            this.chkBackColor.AutoSize = true;
            this.chkBackColor.Location = new System.Drawing.Point(197, 48);
            this.chkBackColor.Name = "chkBackColor";
            this.chkBackColor.Size = new System.Drawing.Size(77, 17);
            this.chkBackColor.TabIndex = 18;
            this.chkBackColor.Text = "Back color";
            this.chkBackColor.UseVisualStyleBackColor = true;
            this.chkBackColor.CheckedChanged += new System.EventHandler(this.chkBackColor_CheckedChanged);
            // 
            // ctrlTextOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBackColor);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.pnlBackColor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmLeft);
            this.Name = "ctrlTextOverlay";
            this.Size = new System.Drawing.Size(525, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTop;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Panel pnlBackColor;
        private System.Windows.Forms.CheckBox chkBackColor;
    }
}
