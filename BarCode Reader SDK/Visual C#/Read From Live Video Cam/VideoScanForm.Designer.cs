namespace ReadFromVideoCamera
{
    partial class VideoScanForm
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
            this.lblFoundBarcodes = new System.Windows.Forms.Label();
            this.pictureVideoPreview = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textAreaBarcodes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBarCodeType = new System.Windows.Forms.ComboBox();
            this.lblScanning = new System.Windows.Forms.Label();
            this.btnTryPopup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCameraWidth = new System.Windows.Forms.TextBox();
            this.tbCameraHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVideoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoundBarcodes
            // 
            this.lblFoundBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFoundBarcodes.AutoSize = true;
            this.lblFoundBarcodes.Location = new System.Drawing.Point(12, 309);
            this.lblFoundBarcodes.Name = "lblFoundBarcodes";
            this.lblFoundBarcodes.Size = new System.Drawing.Size(129, 13);
            this.lblFoundBarcodes.TabIndex = 5;
            this.lblFoundBarcodes.Text = "Found barcodes (0 found)";
            // 
            // pictureVideoPreview
            // 
            this.pictureVideoPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureVideoPreview.BackColor = System.Drawing.Color.White;
            this.pictureVideoPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureVideoPreview.Location = new System.Drawing.Point(12, 96);
            this.pictureVideoPreview.Name = "pictureVideoPreview";
            this.pictureVideoPreview.Size = new System.Drawing.Size(434, 210);
            this.pictureVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureVideoPreview.TabIndex = 8;
            this.pictureVideoPreview.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(80, 399);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 26);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(12, 399);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(62, 26);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textAreaBarcodes
            // 
            this.textAreaBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textAreaBarcodes.Location = new System.Drawing.Point(12, 325);
            this.textAreaBarcodes.Name = "textAreaBarcodes";
            this.textAreaBarcodes.Size = new System.Drawing.Size(434, 68);
            this.textAreaBarcodes.TabIndex = 2;
            this.textAreaBarcodes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Camera Device";
            // 
            // cbCamera
            // 
            this.cbCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(163, 39);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(283, 21);
            this.cbCamera.TabIndex = 1;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(356, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "BarCode Type To Scan";
            // 
            // cbBarCodeType
            // 
            this.cbBarCodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBarCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarCodeType.FormattingEnabled = true;
            this.cbBarCodeType.Location = new System.Drawing.Point(163, 12);
            this.cbBarCodeType.Name = "cbBarCodeType";
            this.cbBarCodeType.Size = new System.Drawing.Size(283, 21);
            this.cbBarCodeType.TabIndex = 0;
            // 
            // lblScanning
            // 
            this.lblScanning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScanning.AutoSize = true;
            this.lblScanning.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScanning.Location = new System.Drawing.Point(374, 309);
            this.lblScanning.Name = "lblScanning";
            this.lblScanning.Size = new System.Drawing.Size(67, 13);
            this.lblScanning.TabIndex = 24;
            this.lblScanning.Text = "Scanning...";
            // 
            // btnTryPopup
            // 
            this.btnTryPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTryPopup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTryPopup.Location = new System.Drawing.Point(163, 399);
            this.btnTryPopup.Name = "btnTryPopup";
            this.btnTryPopup.Size = new System.Drawing.Size(187, 26);
            this.btnTryPopup.TabIndex = 25;
            this.btnTryPopup.Text = "Scan As One Time Popup...";
            this.btnTryPopup.UseVisualStyleBackColor = true;
            this.btnTryPopup.Click += new System.EventHandler(this.btnPopup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Camera Image Width (increase to read better)";
            // 
            // tbCameraWidth
            // 
            this.tbCameraWidth.Location = new System.Drawing.Point(324, 69);
            this.tbCameraWidth.Name = "tbCameraWidth";
            this.tbCameraWidth.Size = new System.Drawing.Size(52, 20);
            this.tbCameraWidth.TabIndex = 27;
            this.tbCameraWidth.Text = "640";
            // 
            // tbCameraHeight
            // 
            this.tbCameraHeight.Location = new System.Drawing.Point(402, 70);
            this.tbCameraHeight.Name = "tbCameraHeight";
            this.tbCameraHeight.Size = new System.Drawing.Size(44, 20);
            this.tbCameraHeight.TabIndex = 28;
            this.tbCameraHeight.Text = "480";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "X";
            // 
            // VideoScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(458, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCameraHeight);
            this.Controls.Add(this.tbCameraWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTryPopup);
            this.Controls.Add(this.lblScanning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBarCodeType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.textAreaBarcodes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureVideoPreview);
            this.Controls.Add(this.lblFoundBarcodes);
            this.MaximizeBox = false;
            this.Name = "VideoScanForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bytescout Video Bar Code Scanner";
            this.Load += new System.EventHandler(this.VideoScanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVideoPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoundBarcodes;
        private System.Windows.Forms.PictureBox pictureVideoPreview;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox textAreaBarcodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBarCodeType;
        private System.Windows.Forms.Label lblScanning;
        private System.Windows.Forms.Button btnTryPopup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCameraWidth;
        private System.Windows.Forms.TextBox tbCameraHeight;
        private System.Windows.Forms.Label label4;
    }
}

