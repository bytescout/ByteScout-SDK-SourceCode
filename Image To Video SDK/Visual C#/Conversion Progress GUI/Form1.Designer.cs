namespace ConversionProgressGUI
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
			this.buttonConvert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// buttonConvert
			// 
			this.buttonConvert.Location = new System.Drawing.Point(18, 57);
			this.buttonConvert.Name = "buttonConvert";
			this.buttonConvert.Size = new System.Drawing.Size(254, 33);
			this.buttonConvert.TabIndex = 0;
			this.buttonConvert.Text = "Convert slides with conversion preview";
			this.buttonConvert.UseVisualStyleBackColor = true;
			this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.label1.Location = new System.Drawing.Point(15, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Conversion progress:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(18, 28);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(254, 23);
			this.progressBar1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 102);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonConvert);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
    }
}

