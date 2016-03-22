namespace ViewSpreadsheet
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
			this.lblStub = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVisitWebsite = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbPromo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbVisitWebsite = new System.Windows.Forms.ToolStripButton();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblStub
			// 
			this.lblStub.BackColor = System.Drawing.SystemColors.Window;
			this.lblStub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblStub.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Italic);
			this.lblStub.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblStub.Location = new System.Drawing.Point(0, 49);
			this.lblStub.Name = "lblStub";
			this.lblStub.Size = new System.Drawing.Size(837, 508);
			this.lblStub.TabIndex = 5;
			this.lblStub.Text = "Click here to open spreadsheet files: \r\n\r\nExcel 2003/2007 (*.xls, *.xlsx) \r\nOpen " +
				"Office Calc (*.ods)\r\nCSV Comma Separated Values (*.csv)\r\nTXT tab-delimited value" +
				"s (*.txt)";
			this.lblStub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStub.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(837, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// filesToolStripMenuItem
			// 
			this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiPrint,
            this.tsmiPrintPreview,
            this.tsmiExit});
			this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
			this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
			this.filesToolStripMenuItem.Text = "Files";
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.tsmiOpen.Size = new System.Drawing.Size(166, 22);
			this.tsmiOpen.Text = "Open";
			this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// tsmiPrint
			// 
			this.tsmiPrint.Enabled = false;
			this.tsmiPrint.Name = "tsmiPrint";
			this.tsmiPrint.Size = new System.Drawing.Size(166, 22);
			this.tsmiPrint.Text = "Print...";
			this.tsmiPrint.Visible = false;
			// 
			// tsmiPrintPreview
			// 
			this.tsmiPrintPreview.Enabled = false;
			this.tsmiPrintPreview.Name = "tsmiPrintPreview";
			this.tsmiPrintPreview.Size = new System.Drawing.Size(166, 22);
			this.tsmiPrintPreview.Text = "Print Preview...";
			this.tsmiPrintPreview.Visible = false;
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(166, 22);
			this.tsmiExit.Text = "Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisitWebsite,
            this.tsmiAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// tsmiVisitWebsite
			// 
			this.tsmiVisitWebsite.Name = "tsmiVisitWebsite";
			this.tsmiVisitWebsite.Size = new System.Drawing.Size(152, 22);
			this.tsmiVisitWebsite.Text = "Visit Website";
			this.tsmiVisitWebsite.Click += new System.EventHandler(this.tsmiVisitWebsite_Click);
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
			this.tsmiAbout.Text = "About";
			this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbPromo,
            this.toolStripSeparator2,
            this.tsbVisitWebsite});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(837, 25);
			this.toolStrip.TabIndex = 7;
			this.toolStrip.Text = "toolStrip1";
			// 
			// tsbOpen
			// 
			this.tsbOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Black;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(71, 22);
			this.tsbOpen.Text = "Open File...";
			this.tsbOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbPromo
			// 
			this.tsbPromo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbPromo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbPromo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPromo.Name = "tsbPromo";
			this.tsbPromo.Size = new System.Drawing.Size(320, 22);
			this.tsbPromo.Text = "Developers: Check Bytescout Spreadsheet SDK for .NET";
			this.tsbPromo.Click += new System.EventHandler(this.tsbPromo_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbVisitWebsite
			// 
			this.tsbVisitWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbVisitWebsite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.tsbVisitWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbVisitWebsite.Name = "tsbVisitWebsite";
			this.tsbVisitWebsite.Size = new System.Drawing.Size(84, 22);
			this.tsbVisitWebsite.Text = "Visit Website";
			this.tsbVisitWebsite.Click += new System.EventHandler(this.tsmiVisitWebsite_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
			this.openFileDialog.SupportMultiDottedExtensions = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 557);
			this.Controls.Add(this.lblStub);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Form1";
			this.Text = "Spreadsheet Viewer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStub;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
		private System.Windows.Forms.ToolStripMenuItem tsmiPrintPreview;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiVisitWebsite;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbPromo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbVisitWebsite;
		private System.Windows.Forms.OpenFileDialog openFileDialog;

	}
}
