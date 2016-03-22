namespace ScreenCapturingClient
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
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.cmbWebCam = new System.Windows.Forms.ComboBox();
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAudioDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEnableAudio = new System.Windows.Forms.CheckBox();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVideoCodec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAudioCodecs = new System.Windows.Forms.ComboBox();
            this.nmCaptureWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCaptureHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmOutputHeight = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmOutputWidth = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCaptureAreaType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nmCaptureTop = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nmCaptureLeft = new System.Windows.Forms.NumericUpDown();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstOverlays = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnAddTextOverlay = new System.Windows.Forms.Button();
            this.btnAddImageOverlay = new System.Windows.Forms.Button();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.pnlCurrentOverlay = new System.Windows.Forms.Panel();
            this.chkEnableWebcam = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nmWebCamTop = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nmWebCamLeft = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nmWebCamHeight = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.nmWebCamWidth = new System.Windows.Forms.NumericUpDown();
            this.grpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPreview.Location = new System.Drawing.Point(12, 12);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(350, 303);
            this.pnlPreview.TabIndex = 0;
            // 
            // cmbWebCam
            // 
            this.cmbWebCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWebCam.Enabled = false;
            this.cmbWebCam.FormattingEnabled = true;
            this.cmbWebCam.Location = new System.Drawing.Point(26, 57);
            this.cmbWebCam.Name = "cmbWebCam";
            this.cmbWebCam.Size = new System.Drawing.Size(250, 21);
            this.cmbWebCam.TabIndex = 1;
            // 
            // grpProperties
            // 
            this.grpProperties.Controls.Add(this.label16);
            this.grpProperties.Controls.Add(this.nmWebCamTop);
            this.grpProperties.Controls.Add(this.label17);
            this.grpProperties.Controls.Add(this.nmWebCamLeft);
            this.grpProperties.Controls.Add(this.label18);
            this.grpProperties.Controls.Add(this.nmWebCamHeight);
            this.grpProperties.Controls.Add(this.label19);
            this.grpProperties.Controls.Add(this.nmWebCamWidth);
            this.grpProperties.Controls.Add(this.chkEnableWebcam);
            this.grpProperties.Controls.Add(this.label13);
            this.grpProperties.Controls.Add(this.nmCaptureTop);
            this.grpProperties.Controls.Add(this.label14);
            this.grpProperties.Controls.Add(this.nmCaptureLeft);
            this.grpProperties.Controls.Add(this.btnLogFile);
            this.grpProperties.Controls.Add(this.btnOutputFile);
            this.grpProperties.Controls.Add(this.label12);
            this.grpProperties.Controls.Add(this.txtOutputFile);
            this.grpProperties.Controls.Add(this.label11);
            this.grpProperties.Controls.Add(this.cmbCaptureAreaType);
            this.grpProperties.Controls.Add(this.label10);
            this.grpProperties.Controls.Add(this.numericUpDown1);
            this.grpProperties.Controls.Add(this.label8);
            this.grpProperties.Controls.Add(this.nmOutputHeight);
            this.grpProperties.Controls.Add(this.label9);
            this.grpProperties.Controls.Add(this.nmOutputWidth);
            this.grpProperties.Controls.Add(this.label7);
            this.grpProperties.Controls.Add(this.nmCaptureHeight);
            this.grpProperties.Controls.Add(this.label6);
            this.grpProperties.Controls.Add(this.nmCaptureWidth);
            this.grpProperties.Controls.Add(this.label5);
            this.grpProperties.Controls.Add(this.cmbAudioCodecs);
            this.grpProperties.Controls.Add(this.label4);
            this.grpProperties.Controls.Add(this.cmbVideoCodec);
            this.grpProperties.Controls.Add(this.label3);
            this.grpProperties.Controls.Add(this.txtLogFile);
            this.grpProperties.Controls.Add(this.chkEnableAudio);
            this.grpProperties.Controls.Add(this.label2);
            this.grpProperties.Controls.Add(this.cmbAudioDevices);
            this.grpProperties.Controls.Add(this.label1);
            this.grpProperties.Controls.Add(this.cmbWebCam);
            this.grpProperties.Location = new System.Drawing.Point(368, 12);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(309, 511);
            this.grpProperties.TabIndex = 2;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Capturer Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select audio device";
            // 
            // cmbAudioDevices
            // 
            this.cmbAudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioDevices.Enabled = false;
            this.cmbAudioDevices.FormattingEnabled = true;
            this.cmbAudioDevices.Location = new System.Drawing.Point(26, 282);
            this.cmbAudioDevices.Name = "cmbAudioDevices";
            this.cmbAudioDevices.Size = new System.Drawing.Size(250, 21);
            this.cmbAudioDevices.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select webcam";
            // 
            // chkEnableAudio
            // 
            this.chkEnableAudio.AutoSize = true;
            this.chkEnableAudio.Location = new System.Drawing.Point(6, 246);
            this.chkEnableAudio.Name = "chkEnableAudio";
            this.chkEnableAudio.Size = new System.Drawing.Size(88, 17);
            this.chkEnableAudio.TabIndex = 5;
            this.chkEnableAudio.Text = "Enable audio";
            this.chkEnableAudio.UseVisualStyleBackColor = true;
            this.chkEnableAudio.CheckedChanged += new System.EventHandler(this.chkEnableAudio_CheckedChanged);
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(6, 481);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(259, 20);
            this.txtLogFile.TabIndex = 6;
            this.txtLogFile.Text = "C:\\bytescout_log.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select video codec";
            // 
            // cmbVideoCodec
            // 
            this.cmbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCodec.FormattingEnabled = true;
            this.cmbVideoCodec.Location = new System.Drawing.Point(6, 138);
            this.cmbVideoCodec.Name = "cmbVideoCodec";
            this.cmbVideoCodec.Size = new System.Drawing.Size(219, 21);
            this.cmbVideoCodec.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select audio codec";
            // 
            // cmbAudioCodecs
            // 
            this.cmbAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioCodecs.Enabled = false;
            this.cmbAudioCodecs.FormattingEnabled = true;
            this.cmbAudioCodecs.Location = new System.Drawing.Point(26, 326);
            this.cmbAudioCodecs.Name = "cmbAudioCodecs";
            this.cmbAudioCodecs.Size = new System.Drawing.Size(250, 21);
            this.cmbAudioCodecs.TabIndex = 10;
            // 
            // nmCaptureWidth
            // 
            this.nmCaptureWidth.Location = new System.Drawing.Point(158, 182);
            this.nmCaptureWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmCaptureWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmCaptureWidth.Name = "nmCaptureWidth";
            this.nmCaptureWidth.Size = new System.Drawing.Size(68, 20);
            this.nmCaptureWidth.TabIndex = 12;
            this.nmCaptureWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capture width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Capture height";
            // 
            // nmCaptureHeight
            // 
            this.nmCaptureHeight.Location = new System.Drawing.Point(232, 183);
            this.nmCaptureHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmCaptureHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmCaptureHeight.Name = "nmCaptureHeight";
            this.nmCaptureHeight.Size = new System.Drawing.Size(68, 20);
            this.nmCaptureHeight.TabIndex = 14;
            this.nmCaptureHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Output height";
            // 
            // nmOutputHeight
            // 
            this.nmOutputHeight.Location = new System.Drawing.Point(83, 220);
            this.nmOutputHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmOutputHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmOutputHeight.Name = "nmOutputHeight";
            this.nmOutputHeight.Size = new System.Drawing.Size(68, 20);
            this.nmOutputHeight.TabIndex = 18;
            this.nmOutputHeight.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Output width";
            // 
            // nmOutputWidth
            // 
            this.nmOutputWidth.Location = new System.Drawing.Point(6, 220);
            this.nmOutputWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmOutputWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmOutputWidth.Name = "nmOutputWidth";
            this.nmOutputWidth.Size = new System.Drawing.Size(68, 20);
            this.nmOutputWidth.TabIndex = 16;
            this.nmOutputWidth.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Framerate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(157, 220);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Capture area type";
            // 
            // cmbCaptureAreaType
            // 
            this.cmbCaptureAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaptureAreaType.FormattingEnabled = true;
            this.cmbCaptureAreaType.Location = new System.Drawing.Point(6, 375);
            this.cmbCaptureAreaType.Name = "cmbCaptureAreaType";
            this.cmbCaptureAreaType.Size = new System.Drawing.Size(219, 21);
            this.cmbCaptureAreaType.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Captured file";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(6, 423);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(259, 20);
            this.txtOutputFile.TabIndex = 24;
            this.txtOutputFile.Text = "C:\\bytescout_capture.avi";
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Location = new System.Drawing.Point(271, 413);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(29, 23);
            this.btnOutputFile.TabIndex = 26;
            this.btnOutputFile.Text = "...";
            this.btnOutputFile.UseVisualStyleBackColor = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // btnLogFile
            // 
            this.btnLogFile.Location = new System.Drawing.Point(271, 478);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(29, 23);
            this.btnLogFile.TabIndex = 27;
            this.btnLogFile.Text = "...";
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Capture top";
            // 
            // nmCaptureTop
            // 
            this.nmCaptureTop.Location = new System.Drawing.Point(81, 181);
            this.nmCaptureTop.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmCaptureTop.Name = "nmCaptureTop";
            this.nmCaptureTop.Size = new System.Drawing.Size(68, 20);
            this.nmCaptureTop.TabIndex = 30;
            this.nmCaptureTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Capture left";
            // 
            // nmCaptureLeft
            // 
            this.nmCaptureLeft.Location = new System.Drawing.Point(7, 181);
            this.nmCaptureLeft.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmCaptureLeft.Name = "nmCaptureLeft";
            this.nmCaptureLeft.Size = new System.Drawing.Size(68, 20);
            this.nmCaptureLeft.TabIndex = 28;
            this.nmCaptureLeft.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(12, 327);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(94, 334);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Stopped";
            // 
            // lstOverlays
            // 
            this.lstOverlays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstOverlays.GridLines = true;
            this.lstOverlays.Location = new System.Drawing.Point(12, 372);
            this.lstOverlays.Name = "lstOverlays";
            this.lstOverlays.Size = new System.Drawing.Size(350, 122);
            this.lstOverlays.TabIndex = 5;
            this.lstOverlays.UseCompatibleStateImageBehavior = false;
            this.lstOverlays.View = System.Windows.Forms.View.Details;
            this.lstOverlays.SelectedIndexChanged += new System.EventHandler(this.lstOverlays_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Overlays";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Overlay";
            this.columnHeader1.Width = 341;
            // 
            // btnAddTextOverlay
            // 
            this.btnAddTextOverlay.Location = new System.Drawing.Point(15, 500);
            this.btnAddTextOverlay.Name = "btnAddTextOverlay";
            this.btnAddTextOverlay.Size = new System.Drawing.Size(106, 23);
            this.btnAddTextOverlay.TabIndex = 25;
            this.btnAddTextOverlay.Text = "Add Text Overlay";
            this.btnAddTextOverlay.UseVisualStyleBackColor = true;
            this.btnAddTextOverlay.Click += new System.EventHandler(this.btnAddTextOverlay_Click);
            // 
            // btnAddImageOverlay
            // 
            this.btnAddImageOverlay.Location = new System.Drawing.Point(127, 500);
            this.btnAddImageOverlay.Name = "btnAddImageOverlay";
            this.btnAddImageOverlay.Size = new System.Drawing.Size(106, 23);
            this.btnAddImageOverlay.TabIndex = 26;
            this.btnAddImageOverlay.Text = "Add Image Overlay";
            this.btnAddImageOverlay.UseVisualStyleBackColor = true;
            this.btnAddImageOverlay.Click += new System.EventHandler(this.btnAddImageOverlay_Click);
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Location = new System.Drawing.Point(287, 500);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOverlay.TabIndex = 27;
            this.btnRemoveOverlay.Text = "Remove";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click);
            // 
            // pnlCurrentOverlay
            // 
            this.pnlCurrentOverlay.BackColor = System.Drawing.Color.LightGray;
            this.pnlCurrentOverlay.Location = new System.Drawing.Point(12, 538);
            this.pnlCurrentOverlay.Name = "pnlCurrentOverlay";
            this.pnlCurrentOverlay.Size = new System.Drawing.Size(664, 168);
            this.pnlCurrentOverlay.TabIndex = 28;
            // 
            // chkEnableWebcam
            // 
            this.chkEnableWebcam.AutoSize = true;
            this.chkEnableWebcam.Location = new System.Drawing.Point(7, 19);
            this.chkEnableWebcam.Name = "chkEnableWebcam";
            this.chkEnableWebcam.Size = new System.Drawing.Size(88, 17);
            this.chkEnableWebcam.TabIndex = 32;
            this.chkEnableWebcam.Text = "Add webcam";
            this.chkEnableWebcam.UseVisualStyleBackColor = true;
            this.chkEnableWebcam.CheckedChanged += new System.EventHandler(this.chkEnableWebcam_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(71, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Top";
            // 
            // nmWebCamTop
            // 
            this.nmWebCamTop.Enabled = false;
            this.nmWebCamTop.Location = new System.Drawing.Point(75, 99);
            this.nmWebCamTop.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmWebCamTop.Name = "nmWebCamTop";
            this.nmWebCamTop.Size = new System.Drawing.Size(45, 20);
            this.nmWebCamTop.TabIndex = 39;
            this.nmWebCamTop.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Left";
            // 
            // nmWebCamLeft
            // 
            this.nmWebCamLeft.Enabled = false;
            this.nmWebCamLeft.Location = new System.Drawing.Point(26, 99);
            this.nmWebCamLeft.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmWebCamLeft.Name = "nmWebCamLeft";
            this.nmWebCamLeft.Size = new System.Drawing.Size(45, 20);
            this.nmWebCamLeft.TabIndex = 37;
            this.nmWebCamLeft.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(174, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Height";
            // 
            // nmWebCamHeight
            // 
            this.nmWebCamHeight.Enabled = false;
            this.nmWebCamHeight.Location = new System.Drawing.Point(177, 99);
            this.nmWebCamHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmWebCamHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmWebCamHeight.Name = "nmWebCamHeight";
            this.nmWebCamHeight.Size = new System.Drawing.Size(45, 20);
            this.nmWebCamHeight.TabIndex = 35;
            this.nmWebCamHeight.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(123, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Width";
            // 
            // nmWebCamWidth
            // 
            this.nmWebCamWidth.Enabled = false;
            this.nmWebCamWidth.Location = new System.Drawing.Point(126, 99);
            this.nmWebCamWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmWebCamWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmWebCamWidth.Name = "nmWebCamWidth";
            this.nmWebCamWidth.Size = new System.Drawing.Size(45, 20);
            this.nmWebCamWidth.TabIndex = 33;
            this.nmWebCamWidth.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 711);
            this.Controls.Add(this.pnlCurrentOverlay);
            this.Controls.Add(this.btnRemoveOverlay);
            this.Controls.Add(this.btnAddImageOverlay);
            this.Controls.Add(this.btnAddTextOverlay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lstOverlays);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.grpProperties);
            this.Controls.Add(this.pnlPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bytescout Screen Capturing Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.ComboBox cmbWebCam;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAudioDevices;
        private System.Windows.Forms.CheckBox chkEnableAudio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVideoCodec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAudioCodecs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCaptureHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmCaptureWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmOutputHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmOutputWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCaptureAreaType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnOutputFile;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmCaptureTop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nmCaptureLeft;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lstOverlays;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddTextOverlay;
        private System.Windows.Forms.Button btnAddImageOverlay;
        private System.Windows.Forms.Button btnRemoveOverlay;
        private System.Windows.Forms.Panel pnlCurrentOverlay;
        private System.Windows.Forms.CheckBox chkEnableWebcam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nmWebCamTop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nmWebCamLeft;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nmWebCamHeight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nmWebCamWidth;
    }
}

