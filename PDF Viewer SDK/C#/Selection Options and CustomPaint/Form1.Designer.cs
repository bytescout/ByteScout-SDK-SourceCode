namespace Example
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
			this.pdfViewerControl1 = new Bytescout.PDFViewer.PDFViewerControl();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.cbLockSelection = new System.Windows.Forms.CheckBox();
			this.cbAllowResizeSelection = new System.Windows.Forms.CheckBox();
			this.cbMultiSelectMode = new System.Windows.Forms.CheckBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pdfViewerControl1
			// 
			this.pdfViewerControl1.AllowResizeSelectionRectangles = true;
			this.pdfViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pdfViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pdfViewerControl1.Location = new System.Drawing.Point(12, 97);
			this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
			this.pdfViewerControl1.MultiSelectMode = true;
			this.pdfViewerControl1.Name = "pdfViewerControl1";
			this.pdfViewerControl1.RegistrationKey = null;
			this.pdfViewerControl1.RegistrationName = null;
			this.pdfViewerControl1.Size = new System.Drawing.Size(1153, 568);
			this.pdfViewerControl1.TabIndex = 0;
			this.pdfViewerControl1.SelectionChanged += new System.EventHandler(this.pdfViewerControl1_SelectionChanged);
			this.pdfViewerControl1.CustomPaint += new System.Windows.Forms.PaintEventHandler(this.pdfViewerControl1_CustomPaint);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1177, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Image = global::Example.Properties.Resources.folder_page;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(80, 22);
			this.tsbOpen.Text = "&Open PDF";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// cbLockSelection
			// 
			this.cbLockSelection.AutoSize = true;
			this.cbLockSelection.Location = new System.Drawing.Point(12, 74);
			this.cbLockSelection.Name = "cbLockSelection";
			this.cbLockSelection.Size = new System.Drawing.Size(95, 17);
			this.cbLockSelection.TabIndex = 2;
			this.cbLockSelection.Text = "Lock selection";
			this.cbLockSelection.UseVisualStyleBackColor = true;
			this.cbLockSelection.CheckedChanged += new System.EventHandler(this.cbLockSelection_CheckedChanged);
			// 
			// cbAllowResizeSelection
			// 
			this.cbAllowResizeSelection.AutoSize = true;
			this.cbAllowResizeSelection.Checked = true;
			this.cbAllowResizeSelection.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAllowResizeSelection.Location = new System.Drawing.Point(12, 51);
			this.cbAllowResizeSelection.Name = "cbAllowResizeSelection";
			this.cbAllowResizeSelection.Size = new System.Drawing.Size(178, 17);
			this.cbAllowResizeSelection.TabIndex = 3;
			this.cbAllowResizeSelection.Text = "Allow resize selection rectangles";
			this.cbAllowResizeSelection.UseVisualStyleBackColor = true;
			this.cbAllowResizeSelection.CheckedChanged += new System.EventHandler(this.cbAllowResizeSelection_CheckedChanged);
			// 
			// cbMultiSelectMode
			// 
			this.cbMultiSelectMode.AutoSize = true;
			this.cbMultiSelectMode.Checked = true;
			this.cbMultiSelectMode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbMultiSelectMode.Location = new System.Drawing.Point(12, 28);
			this.cbMultiSelectMode.Name = "cbMultiSelectMode";
			this.cbMultiSelectMode.Size = new System.Drawing.Size(108, 17);
			this.cbMultiSelectMode.TabIndex = 4;
			this.cbMultiSelectMode.Text = "Multi-select mode";
			this.cbMultiSelectMode.UseVisualStyleBackColor = true;
			this.cbMultiSelectMode.CheckedChanged += new System.EventHandler(this.cbMultiSelectMode_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1177, 677);
			this.Controls.Add(this.cbMultiSelectMode);
			this.Controls.Add(this.cbAllowResizeSelection);
			this.Controls.Add(this.cbLockSelection);
			this.Controls.Add(this.pdfViewerControl1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.CheckBox cbLockSelection;
		private System.Windows.Forms.CheckBox cbAllowResizeSelection;
		private System.Windows.Forms.CheckBox cbMultiSelectMode;
	}
}

