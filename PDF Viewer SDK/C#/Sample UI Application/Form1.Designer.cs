namespace Sample_UI_Application
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
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pdfViewerControl1
			// 
			this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pdfViewerControl1.Location = new System.Drawing.Point(0, 25);
			this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Hand;
			this.pdfViewerControl1.Name = "pdfViewerControl1";
			this.pdfViewerControl1.ShowToolbar = true;
			this.pdfViewerControl1.Size = new System.Drawing.Size(842, 514);
			this.pdfViewerControl1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(842, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Image = global::Sample_UI_Application.Properties.Resources.folder_page;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(80, 22);
			this.tsbOpen.Text = "&Open PDF";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 539);
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
	}
}

