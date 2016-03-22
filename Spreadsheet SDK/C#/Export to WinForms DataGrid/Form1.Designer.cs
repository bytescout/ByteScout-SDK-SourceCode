namespace ImportExportFromWinFormsDataGrid.CSharp
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize) (this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(12, 12);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(438, 308);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImport.Location = new System.Drawing.Point(238, 326);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(212, 23);
			this.btnImport.TabIndex = 1;
			this.btnImport.Text = "Import from DataGrid to spreadsheet";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.Location = new System.Drawing.Point(238, 355);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(212, 23);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Export from spreadsheet to DataGrid";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 390);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Form1";
			this.Text = "ImportFromWinFormsDataGrid";
			((System.ComponentModel.ISupportInitialize) (this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;

	}
}
