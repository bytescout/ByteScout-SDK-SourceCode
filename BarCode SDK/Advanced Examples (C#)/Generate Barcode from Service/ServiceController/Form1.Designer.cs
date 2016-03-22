namespace ServiceController
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
			this.btnInstallService = new System.Windows.Forms.Button();
			this.btnUninstallService = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnInstallService
			// 
			this.btnInstallService.Location = new System.Drawing.Point(12, 12);
			this.btnInstallService.Name = "btnInstallService";
			this.btnInstallService.Size = new System.Drawing.Size(125, 23);
			this.btnInstallService.TabIndex = 0;
			this.btnInstallService.Text = "Install Service";
			this.btnInstallService.UseVisualStyleBackColor = true;
			this.btnInstallService.Click += new System.EventHandler(this.btnInstallService_Click);
			// 
			// btnUninstallService
			// 
			this.btnUninstallService.Location = new System.Drawing.Point(143, 12);
			this.btnUninstallService.Name = "btnUninstallService";
			this.btnUninstallService.Size = new System.Drawing.Size(125, 23);
			this.btnUninstallService.TabIndex = 1;
			this.btnUninstallService.Text = "Uninstall Service";
			this.btnUninstallService.UseVisualStyleBackColor = true;
			this.btnUninstallService.Click += new System.EventHandler(this.btnUninstallService_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExit.Location = new System.Drawing.Point(193, 77);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnExit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 112);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnUninstallService);
			this.Controls.Add(this.btnInstallService);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Service Controller";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstallService;
        private System.Windows.Forms.Button btnUninstallService;
		private System.Windows.Forms.Button btnExit;
    }
}

