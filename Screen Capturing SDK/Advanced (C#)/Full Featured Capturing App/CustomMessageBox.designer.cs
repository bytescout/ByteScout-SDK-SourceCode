namespace ScreenCapturing
{
	partial class CustomMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cbDoNotShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinue.Location = new System.Drawing.Point(272, 82);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // cbDoNotShow
            // 
            this.cbDoNotShow.AutoSize = true;
            this.cbDoNotShow.Location = new System.Drawing.Point(12, 86);
            this.cbDoNotShow.Name = "cbDoNotShow";
            this.cbDoNotShow.Size = new System.Drawing.Size(129, 17);
            this.cbDoNotShow.TabIndex = 2;
            this.cbDoNotShow.Text = "Do not show anymore";
            this.cbDoNotShow.UseVisualStyleBackColor = true;
            this.cbDoNotShow.CheckedChanged += new System.EventHandler(this.cbDoNotAsk_CheckedChanged);
            // 
            // CustomMessageBox
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 117);
            this.Controls.Add(this.cbDoNotShow);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.CheckBox cbDoNotShow;
	}
}
