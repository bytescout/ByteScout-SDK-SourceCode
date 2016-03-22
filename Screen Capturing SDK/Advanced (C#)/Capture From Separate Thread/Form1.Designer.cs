namespace CaptureFromSeparateThread
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
			this.cmbCapturingType = new System.Windows.Forms.ComboBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbCapturingType
			// 
			this.cmbCapturingType.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbCapturingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCapturingType.FormattingEnabled = true;
			this.cmbCapturingType.Items.AddRange(new object[] {
            "Area around the mouse pointer",
            "Full screen"});
			this.cmbCapturingType.Location = new System.Drawing.Point(97, 12);
			this.cmbCapturingType.Name = "cmbCapturingType";
			this.cmbCapturingType.Size = new System.Drawing.Size(213, 21);
			this.cmbCapturingType.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(3, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(143, 44);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Capturing Type";
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(152, 3);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(143, 44);
			this.btnStop.TabIndex = 4;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 52);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 57);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 121);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCapturingType);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Capture From Separate Thread";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCapturingType;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

