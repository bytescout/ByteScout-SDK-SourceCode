namespace MultipleBarcodeGeneration
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
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.tbValueTemplate = new System.Windows.Forms.TextBox();
			this.nudValueStartAt = new System.Windows.Forms.NumericUpDown();
			this.label24 = new System.Windows.Forms.Label();
			this.cmbValueDigits = new System.Windows.Forms.ComboBox();
			this.nudValueEndAt = new System.Windows.Forms.NumericUpDown();
			this.nudValueStepBy = new System.Windows.Forms.NumericUpDown();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.nudCounterStartAt = new System.Windows.Forms.NumericUpDown();
			this.label25 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.cmbCounterDigits = new System.Windows.Forms.ComboBox();
			this.tbFileNameTemplate = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.nudCounterStepBy = new System.Windows.Forms.NumericUpDown();
			this.label27 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label29 = new System.Windows.Forms.Label();
			this.cmbImageFormat = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbBarcodeType = new System.Windows.Forms.ComboBox();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudValueStartAt)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.nudValueEndAt)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.nudValueStepBy)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudCounterStartAt)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.nudCounterStepBy)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(175, 395);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(213, 10);
			this.progressBar.TabIndex = 22;
			this.progressBar.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label33);
			this.groupBox3.Controls.Add(this.label28);
			this.groupBox3.Controls.Add(this.tbValueTemplate);
			this.groupBox3.Controls.Add(this.nudValueStartAt);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.cmbValueDigits);
			this.groupBox3.Controls.Add(this.nudValueEndAt);
			this.groupBox3.Controls.Add(this.nudValueStepBy);
			this.groupBox3.Controls.Add(this.label30);
			this.groupBox3.Controls.Add(this.label31);
			this.groupBox3.Controls.Add(this.label32);
			this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.groupBox3.Location = new System.Drawing.Point(12, 43);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(376, 160);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Barcode Value";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label33.Location = new System.Drawing.Point(6, 52);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(47, 13);
			this.label33.TabIndex = 18;
			this.label33.Text = "Counter:";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label28.Location = new System.Drawing.Point(6, 23);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(51, 13);
			this.label28.TabIndex = 17;
			this.label28.Text = "Template";
			// 
			// tbValueTemplate
			// 
			this.tbValueTemplate.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbValueTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbValueTemplate.Location = new System.Drawing.Point(106, 20);
			this.tbValueTemplate.Name = "tbValueTemplate";
			this.tbValueTemplate.Size = new System.Drawing.Size(264, 20);
			this.tbValueTemplate.TabIndex = 16;
			this.tbValueTemplate.Text = "[N]";
			// 
			// nudValueStartAt
			// 
			this.nudValueStartAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudValueStartAt.Location = new System.Drawing.Point(106, 49);
			this.nudValueStartAt.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.nudValueStartAt.Name = "nudValueStartAt";
			this.nudValueStartAt.Size = new System.Drawing.Size(63, 20);
			this.nudValueStartAt.TabIndex = 0;
			this.nudValueStartAt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label24.Location = new System.Drawing.Point(59, 53);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(41, 13);
			this.label24.TabIndex = 5;
			this.label24.Text = "Start at";
			// 
			// cmbValueDigits
			// 
			this.cmbValueDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbValueDigits.FormattingEnabled = true;
			this.cmbValueDigits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cmbValueDigits.Location = new System.Drawing.Point(106, 127);
			this.cmbValueDigits.Name = "cmbValueDigits";
			this.cmbValueDigits.Size = new System.Drawing.Size(63, 21);
			this.cmbValueDigits.TabIndex = 3;
			this.cmbValueDigits.Text = "3";
			// 
			// nudValueEndAt
			// 
			this.nudValueEndAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudValueEndAt.Location = new System.Drawing.Point(106, 101);
			this.nudValueEndAt.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.nudValueEndAt.Name = "nudValueEndAt";
			this.nudValueEndAt.Size = new System.Drawing.Size(63, 20);
			this.nudValueEndAt.TabIndex = 2;
			this.nudValueEndAt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// nudValueStepBy
			// 
			this.nudValueStepBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudValueStepBy.Location = new System.Drawing.Point(106, 75);
			this.nudValueStepBy.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.nudValueStepBy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudValueStepBy.Name = "nudValueStepBy";
			this.nudValueStepBy.Size = new System.Drawing.Size(63, 20);
			this.nudValueStepBy.TabIndex = 1;
			this.nudValueStepBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label30.Location = new System.Drawing.Point(59, 130);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(33, 13);
			this.label30.TabIndex = 9;
			this.label30.Text = "Digits";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label31.Location = new System.Drawing.Point(59, 105);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(38, 13);
			this.label31.TabIndex = 12;
			this.label31.Text = "End at";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label32.Location = new System.Drawing.Point(59, 79);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(43, 13);
			this.label32.TabIndex = 8;
			this.label32.Text = "Step by";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.nudCounterStartAt);
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.label34);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.cmbCounterDigits);
			this.groupBox2.Controls.Add(this.tbFileNameTemplate);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Controls.Add(this.nudCounterStepBy);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.groupBox2.Location = new System.Drawing.Point(12, 210);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(376, 131);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "File Name";
			// 
			// nudCounterStartAt
			// 
			this.nudCounterStartAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudCounterStartAt.Location = new System.Drawing.Point(106, 47);
			this.nudCounterStartAt.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.nudCounterStartAt.Name = "nudCounterStartAt";
			this.nudCounterStartAt.Size = new System.Drawing.Size(63, 20);
			this.nudCounterStartAt.TabIndex = 0;
			this.nudCounterStartAt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label25.Location = new System.Drawing.Point(59, 51);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(41, 13);
			this.label25.TabIndex = 5;
			this.label25.Text = "Start at";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label34.Location = new System.Drawing.Point(6, 50);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(47, 13);
			this.label34.TabIndex = 19;
			this.label34.Text = "Counter:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label22.Location = new System.Drawing.Point(6, 23);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(51, 13);
			this.label22.TabIndex = 19;
			this.label22.Text = "Template";
			// 
			// cmbCounterDigits
			// 
			this.cmbCounterDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbCounterDigits.FormattingEnabled = true;
			this.cmbCounterDigits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
			this.cmbCounterDigits.Location = new System.Drawing.Point(106, 99);
			this.cmbCounterDigits.Name = "cmbCounterDigits";
			this.cmbCounterDigits.Size = new System.Drawing.Size(63, 21);
			this.cmbCounterDigits.TabIndex = 3;
			this.cmbCounterDigits.Text = "3";
			// 
			// tbFileNameTemplate
			// 
			this.tbFileNameTemplate.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbFileNameTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbFileNameTemplate.Location = new System.Drawing.Point(106, 20);
			this.tbFileNameTemplate.Name = "tbFileNameTemplate";
			this.tbFileNameTemplate.Size = new System.Drawing.Size(264, 20);
			this.tbFileNameTemplate.TabIndex = 0;
			this.tbFileNameTemplate.Text = "barcode[N]";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label26.Location = new System.Drawing.Point(59, 77);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(43, 13);
			this.label26.TabIndex = 8;
			this.label26.Text = "Step by";
			// 
			// nudCounterStepBy
			// 
			this.nudCounterStepBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.nudCounterStepBy.Location = new System.Drawing.Point(106, 73);
			this.nudCounterStepBy.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.nudCounterStepBy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCounterStepBy.Name = "nudCounterStepBy";
			this.nudCounterStepBy.Size = new System.Drawing.Size(63, 20);
			this.nudCounterStepBy.TabIndex = 1;
			this.nudCounterStepBy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label27.Location = new System.Drawing.Point(59, 102);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(33, 13);
			this.label27.TabIndex = 9;
			this.label27.Text = "Digits";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.btnGenerate.Image = global::MultipleBarcodeGeneration.Properties.Resources.disk_multiple;
			this.btnGenerate.Location = new System.Drawing.Point(174, 353);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.btnGenerate.Size = new System.Drawing.Size(214, 41);
			this.btnGenerate.TabIndex = 20;
			this.btnGenerate.Text = "Generate multiple barcodes";
			this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label29.Location = new System.Drawing.Point(7, 367);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(86, 13);
			this.label29.TabIndex = 21;
			this.label29.Text = "Image format";
			// 
			// cmbImageFormat
			// 
			this.cmbImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbImageFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbImageFormat.FormattingEnabled = true;
			this.cmbImageFormat.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP",
            "TIFF",
            "GIF"});
			this.cmbImageFormat.Location = new System.Drawing.Point(99, 364);
			this.cmbImageFormat.Name = "cmbImageFormat";
			this.cmbImageFormat.Size = new System.Drawing.Size(67, 21);
			this.cmbImageFormat.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label1.Location = new System.Drawing.Point(7, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Barcode type";
			// 
			// cmbBarcodeType
			// 
			this.cmbBarcodeType.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBarcodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cmbBarcodeType.FormattingEnabled = true;
			this.cmbBarcodeType.Location = new System.Drawing.Point(118, 16);
			this.cmbBarcodeType.Name = "cmbBarcodeType";
			this.cmbBarcodeType.Size = new System.Drawing.Size(269, 21);
			this.cmbBarcodeType.TabIndex = 23;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 414);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbBarcodeType);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.cmbImageFormat);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Multiple Barcode Generation";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudValueStartAt)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.nudValueEndAt)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.nudValueStepBy)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudCounterStartAt)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.nudCounterStepBy)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox tbValueTemplate;
		private System.Windows.Forms.NumericUpDown nudValueStartAt;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox cmbValueDigits;
		private System.Windows.Forms.NumericUpDown nudValueEndAt;
		private System.Windows.Forms.NumericUpDown nudValueStepBy;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown nudCounterStartAt;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox cmbCounterDigits;
		private System.Windows.Forms.TextBox tbFileNameTemplate;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.NumericUpDown nudCounterStepBy;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.ComboBox cmbImageFormat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbBarcodeType;
	}
}

