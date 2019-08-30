namespace SampleApplication
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnGetData = new System.Windows.Forms.Button();
			this.rbSelectTotal = new System.Windows.Forms.RadioButton();
			this.rbSelectCustomerInfo = new System.Windows.Forms.RadioButton();
			this.rbSelectInvoiceNumber = new System.Windows.Forms.RadioButton();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pdfViewerControl1
			// 
			this.pdfViewerControl1.AllowResizeSelectionRectangles = true;
			this.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pdfViewerControl1.ClearSelectionOnClick = false;
			this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pdfViewerControl1.Location = new System.Drawing.Point(179, 25);
			this.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection;
			this.pdfViewerControl1.MultiSelectMode = true;
			this.pdfViewerControl1.Name = "pdfViewerControl1";
			this.pdfViewerControl1.RegistrationKey = null;
			this.pdfViewerControl1.RegistrationName = null;
			this.pdfViewerControl1.SelectionColor = System.Drawing.Color.Red;
			this.pdfViewerControl1.SelectionModifierKey = Bytescout.PDFViewer.SelectionModifierKeys.None;
			this.pdfViewerControl1.Size = new System.Drawing.Size(829, 708);
			this.pdfViewerControl1.TabIndex = 0;
			this.pdfViewerControl1.CurrentPageIndexChanged += new System.EventHandler(this.pdfViewerControl1_CurrentPageIndexChanged);
			this.pdfViewerControl1.SelectionChanged += new System.EventHandler(this.pdfViewerControl1_SelectionChanged);
			this.pdfViewerControl1.CustomPaint += new System.Windows.Forms.PaintEventHandler(this.pdfViewerControl1_CustomPaint);
			this.pdfViewerControl1.DocumentChanged += new System.EventHandler(this.pdfViewerControl1_DocumentChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Image = global::SampleApplication.Properties.Resources.folder_page;
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(80, 22);
			this.tsbOpen.Text = "&Open PDF";
			this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnGetData);
			this.panel1.Controls.Add(this.rbSelectTotal);
			this.panel1.Controls.Add(this.rbSelectCustomerInfo);
			this.panel1.Controls.Add(this.rbSelectInvoiceNumber);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(179, 708);
			this.panel1.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.Enabled = false;
			this.btnClear.Location = new System.Drawing.Point(93, 126);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnGetData
			// 
			this.btnGetData.Enabled = false;
			this.btnGetData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGetData.Location = new System.Drawing.Point(12, 97);
			this.btnGetData.Name = "btnGetData";
			this.btnGetData.Size = new System.Drawing.Size(156, 23);
			this.btnGetData.TabIndex = 3;
			this.btnGetData.Text = "Get Data";
			this.btnGetData.UseVisualStyleBackColor = true;
			this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// rbSelectTotal
			// 
			this.rbSelectTotal.AutoSize = true;
			this.rbSelectTotal.Enabled = false;
			this.rbSelectTotal.Location = new System.Drawing.Point(12, 66);
			this.rbSelectTotal.Name = "rbSelectTotal";
			this.rbSelectTotal.Size = new System.Drawing.Size(93, 17);
			this.rbSelectTotal.TabIndex = 2;
			this.rbSelectTotal.Text = "Select TOTAL";
			this.rbSelectTotal.UseVisualStyleBackColor = true;
			// 
			// rbSelectCustomerInfo
			// 
			this.rbSelectCustomerInfo.AutoSize = true;
			this.rbSelectCustomerInfo.Enabled = false;
			this.rbSelectCustomerInfo.Location = new System.Drawing.Point(12, 43);
			this.rbSelectCustomerInfo.Name = "rbSelectCustomerInfo";
			this.rbSelectCustomerInfo.Size = new System.Drawing.Size(123, 17);
			this.rbSelectCustomerInfo.TabIndex = 1;
			this.rbSelectCustomerInfo.Text = "Select Customer Info";
			this.rbSelectCustomerInfo.UseVisualStyleBackColor = true;
			// 
			// rbSelectInvoiceNumber
			// 
			this.rbSelectInvoiceNumber.AutoSize = true;
			this.rbSelectInvoiceNumber.Checked = true;
			this.rbSelectInvoiceNumber.Enabled = false;
			this.rbSelectInvoiceNumber.Location = new System.Drawing.Point(12, 20);
			this.rbSelectInvoiceNumber.Name = "rbSelectInvoiceNumber";
			this.rbSelectInvoiceNumber.Size = new System.Drawing.Size(133, 17);
			this.rbSelectInvoiceNumber.TabIndex = 0;
			this.rbSelectInvoiceNumber.TabStop = true;
			this.rbSelectInvoiceNumber.Text = "Select Invoice Number";
			this.rbSelectInvoiceNumber.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 733);
			this.Controls.Add(this.pdfViewerControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bytescout.PDFViewer.PDFViewerControl pdfViewerControl1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.RadioButton rbSelectTotal;
		private System.Windows.Forms.RadioButton rbSelectCustomerInfo;
		private System.Windows.Forms.RadioButton rbSelectInvoiceNumber;
		private System.Windows.Forms.Button btnClear;
	}
}

