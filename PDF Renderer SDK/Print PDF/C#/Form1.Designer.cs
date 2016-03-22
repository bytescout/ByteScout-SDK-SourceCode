namespace PrintPDF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.buttonPageSetup = new System.Windows.Forms.Button();
			this.buttonPrintPreview = new System.Windows.Forms.Button();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon) (resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.UseAntiAlias = true;
			this.printPreviewDialog1.Visible = false;
			// 
			// pageSetupDialog1
			// 
			this.pageSetupDialog1.Document = this.printDocument1;
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// buttonPageSetup
			// 
			this.buttonPageSetup.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPageSetup.Location = new System.Drawing.Point(12, 12);
			this.buttonPageSetup.Name = "buttonPageSetup";
			this.buttonPageSetup.Size = new System.Drawing.Size(253, 41);
			this.buttonPageSetup.TabIndex = 0;
			this.buttonPageSetup.Text = "Page Setup";
			this.buttonPageSetup.UseVisualStyleBackColor = true;
			this.buttonPageSetup.Click += new System.EventHandler(this.buttonPageSetup_Click);
			// 
			// buttonPrintPreview
			// 
			this.buttonPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPrintPreview.Location = new System.Drawing.Point(12, 59);
			this.buttonPrintPreview.Name = "buttonPrintPreview";
			this.buttonPrintPreview.Size = new System.Drawing.Size(253, 41);
			this.buttonPrintPreview.TabIndex = 1;
			this.buttonPrintPreview.Text = "Print Preview";
			this.buttonPrintPreview.UseVisualStyleBackColor = true;
			this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
			// 
			// buttonPrint
			// 
			this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPrint.Location = new System.Drawing.Point(12, 106);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(253, 41);
			this.buttonPrint.TabIndex = 2;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 161);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.buttonPrintPreview);
			this.Controls.Add(this.buttonPageSetup);
			this.Name = "Form1";
			this.Text = "Print PDF";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Button buttonPageSetup;
		private System.Windows.Forms.Button buttonPrintPreview;
		private System.Windows.Forms.Button buttonPrint;
	}
}

