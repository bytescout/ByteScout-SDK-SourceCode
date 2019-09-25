## How to make full screen recording demo 2 with text and images overlay in C# using ByteScout Screen Capturing SDK

### Tutorial on how to make full screen recording demo 2 with text and images overlay in C#

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images and you can use it to make full screen recording demo 2 with text and images overlay with C#.

Fast application programming interfaces of ByteScout Screen Capturing SDK for C# plus the instruction and the code below will help you quickly learn how to make full screen recording demo 2 with text and images overlay. Just copy and paste the code into your C# application’s code and follow the instruction. Code testing will allow the function to be tested and work properly with your data.

Download free trial version of ByteScout Screen Capturing SDK from our website with this and other source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****Form1.Designer.cs:**
    
```
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
            this.components = new System.ComponentModel.Container();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.cmbWebCam = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.nmMotionSensitivity = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.nmMotionInterval = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbMotionDetection = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nmWebCamTop = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nmWebCamLeft = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nmWebCamHeight = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.nmWebCamWidth = new System.Windows.Forms.NumericUpDown();
            this.chkEnableWebcam = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nmCaptureTop = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nmCaptureLeft = new System.Windows.Forms.NumericUpDown();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCaptureAreaType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nmOutputHeight = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmOutputWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmCaptureHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmCaptureWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAudioCodecs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVideoCodec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.chkEnableAudio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAudioDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstOverlays = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddTextOverlay = new System.Windows.Forms.Button();
            this.btnAddImageOverlay = new System.Windows.Forms.Button();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.pnlCurrentOverlay = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtMonitorHeight = new System.Windows.Forms.TextBox();
            this.txtMonitorWidth = new System.Windows.Forms.TextBox();
            this.txtMonitorTop = new System.Windows.Forms.TextBox();
            this.txtMonitorLeft = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbCurrentMonitor = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMonitorCount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbWriteLog = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmMotionSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMotionInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureWidth)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPreview.Location = new System.Drawing.Point(29, 34);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(458, 365);
            this.pnlPreview.TabIndex = 0;
            // 
            // cmbWebCam
            // 
            this.cmbWebCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWebCam.Enabled = false;
            this.cmbWebCam.FormattingEnabled = true;
            this.cmbWebCam.Location = new System.Drawing.Point(36, 103);
            this.cmbWebCam.Name = "cmbWebCam";
            this.cmbWebCam.Size = new System.Drawing.Size(250, 21);
            this.cmbWebCam.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(110, 399);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Sensitivity";
            // 
            // nmMotionSensitivity
            // 
            this.nmMotionSensitivity.DecimalPlaces = 3;
            this.nmMotionSensitivity.Enabled = false;
            this.nmMotionSensitivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nmMotionSensitivity.Location = new System.Drawing.Point(113, 415);
            this.nmMotionSensitivity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMotionSensitivity.Name = "nmMotionSensitivity";
            this.nmMotionSensitivity.Size = new System.Drawing.Size(68, 20);
            this.nmMotionSensitivity.TabIndex = 45;
            this.nmMotionSensitivity.Value = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 399);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "Interval";
            // 
            // nmMotionInterval
            // 
            this.nmMotionInterval.Enabled = false;
            this.nmMotionInterval.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmMotionInterval.Location = new System.Drawing.Point(36, 415);
            this.nmMotionInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmMotionInterval.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmMotionInterval.Name = "nmMotionInterval";
            this.nmMotionInterval.Size = new System.Drawing.Size(68, 20);
            this.nmMotionInterval.TabIndex = 43;
            this.nmMotionInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 358);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Recording mode";
            // 
            // cmbMotionDetection
            // 
            this.cmbMotionDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotionDetection.FormattingEnabled = true;
            this.cmbMotionDetection.Location = new System.Drawing.Point(17, 374);
            this.cmbMotionDetection.Name = "cmbMotionDetection";
            this.cmbMotionDetection.Size = new System.Drawing.Size(221, 21);
            this.cmbMotionDetection.TabIndex = 41;
            this.cmbMotionDetection.SelectedIndexChanged += new System.EventHandler(this.cmbMotionDetection_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Top";
            // 
            // nmWebCamTop
            // 
            this.nmWebCamTop.Enabled = false;
            this.nmWebCamTop.Location = new System.Drawing.Point(85, 143);
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
            this.label17.Location = new System.Drawing.Point(33, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Left";
            // 
            // nmWebCamLeft
            // 
            this.nmWebCamLeft.Enabled = false;
            this.nmWebCamLeft.Location = new System.Drawing.Point(36, 143);
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
            this.label18.Location = new System.Drawing.Point(184, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Height";
            // 
            // nmWebCamHeight
            // 
            this.nmWebCamHeight.Enabled = false;
            this.nmWebCamHeight.Location = new System.Drawing.Point(187, 143);
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
            this.label19.Location = new System.Drawing.Point(133, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Width";
            // 
            // nmWebCamWidth
            // 
            this.nmWebCamWidth.Enabled = false;
            this.nmWebCamWidth.Location = new System.Drawing.Point(136, 143);
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
            // chkEnableWebcam
            // 
            this.chkEnableWebcam.AutoSize = true;
            this.chkEnableWebcam.Location = new System.Drawing.Point(17, 67);
            this.chkEnableWebcam.Name = "chkEnableWebcam";
            this.chkEnableWebcam.Size = new System.Drawing.Size(88, 17);
            this.chkEnableWebcam.TabIndex = 32;
            this.chkEnableWebcam.Text = "Add webcam";
            this.chkEnableWebcam.UseVisualStyleBackColor = true;
            this.chkEnableWebcam.CheckedChanged += new System.EventHandler(this.chkEnableWebcam_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Capture top";
            // 
            // nmCaptureTop
            // 
            this.nmCaptureTop.Location = new System.Drawing.Point(91, 244);
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
            this.label14.Location = new System.Drawing.Point(14, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Capture left";
            // 
            // nmCaptureLeft
            // 
            this.nmCaptureLeft.Location = new System.Drawing.Point(17, 244);
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
            // btnLogFile
            // 
            this.btnLogFile.Location = new System.Drawing.Point(284, 45);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(29, 23);
            this.btnLogFile.TabIndex = 27;
            this.btnLogFile.Text = "...";
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Location = new System.Drawing.Point(272, 34);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(29, 23);
            this.btnOutputFile.TabIndex = 26;
            this.btnOutputFile.Text = "...";
            this.btnOutputFile.UseVisualStyleBackColor = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Captured file";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(16, 34);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(259, 20);
            this.txtOutputFile.TabIndex = 24;
            this.txtOutputFile.Text = "C:\\bytescout_capture.avi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Capture area type";
            // 
            // cmbCaptureAreaType
            // 
            this.cmbCaptureAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaptureAreaType.FormattingEnabled = true;
            this.cmbCaptureAreaType.Location = new System.Drawing.Point(17, 330);
            this.cmbCaptureAreaType.Name = "cmbCaptureAreaType";
            this.cmbCaptureAreaType.Size = new System.Drawing.Size(219, 21);
            this.cmbCaptureAreaType.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Framerate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(167, 283);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Output height";
            // 
            // nmOutputHeight
            // 
            this.nmOutputHeight.Location = new System.Drawing.Point(93, 283);
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
            this.label9.Location = new System.Drawing.Point(13, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Output width";
            // 
            // nmOutputWidth
            // 
            this.nmOutputWidth.Location = new System.Drawing.Point(16, 283);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Capture height";
            // 
            // nmCaptureHeight
            // 
            this.nmCaptureHeight.Location = new System.Drawing.Point(242, 246);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Capture width";
            // 
            // nmCaptureWidth
            // 
            this.nmCaptureWidth.Location = new System.Drawing.Point(168, 245);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 77);
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
            this.cmbAudioCodecs.Location = new System.Drawing.Point(29, 93);
            this.cmbAudioCodecs.Name = "cmbAudioCodecs";
            this.cmbAudioCodecs.Size = new System.Drawing.Size(250, 21);
            this.cmbAudioCodecs.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select video codec";
            // 
            // cmbVideoCodec
            // 
            this.cmbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoCodec.FormattingEnabled = true;
            this.cmbVideoCodec.Location = new System.Drawing.Point(17, 197);
            this.cmbVideoCodec.Name = "cmbVideoCodec";
            this.cmbVideoCodec.Size = new System.Drawing.Size(219, 21);
            this.cmbVideoCodec.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log file";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(20, 48);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(259, 20);
            this.txtLogFile.TabIndex = 6;
            this.txtLogFile.Text = "C:\\bytescout_log.txt";
            // 
            // chkEnableAudio
            // 
            this.chkEnableAudio.AutoSize = true;
            this.chkEnableAudio.Location = new System.Drawing.Point(9, 13);
            this.chkEnableAudio.Name = "chkEnableAudio";
            this.chkEnableAudio.Size = new System.Drawing.Size(88, 17);
            this.chkEnableAudio.TabIndex = 5;
            this.chkEnableAudio.Text = "Enable audio";
            this.chkEnableAudio.UseVisualStyleBackColor = true;
            this.chkEnableAudio.CheckedChanged += new System.EventHandler(this.chkEnableAudio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
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
            this.cmbAudioDevices.Location = new System.Drawing.Point(29, 49);
            this.cmbAudioDevices.Name = "cmbAudioDevices";
            this.cmbAudioDevices.Size = new System.Drawing.Size(250, 21);
            this.cmbAudioDevices.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select webcam";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(29, 408);
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
            this.lblStatus.Location = new System.Drawing.Point(191, 413);
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
            this.lstOverlays.Location = new System.Drawing.Point(6, 27);
            this.lstOverlays.Name = "lstOverlays";
            this.lstOverlays.Size = new System.Drawing.Size(309, 168);
            this.lstOverlays.TabIndex = 5;
            this.lstOverlays.UseCompatibleStateImageBehavior = false;
            this.lstOverlays.View = System.Windows.Forms.View.Details;
            this.lstOverlays.SelectedIndexChanged += new System.EventHandler(this.lstOverlays_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Overlay";
            this.columnHeader1.Width = 301;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Overlays";
            // 
            // btnAddTextOverlay
            // 
            this.btnAddTextOverlay.Location = new System.Drawing.Point(6, 201);
            this.btnAddTextOverlay.Name = "btnAddTextOverlay";
            this.btnAddTextOverlay.Size = new System.Drawing.Size(106, 23);
            this.btnAddTextOverlay.TabIndex = 25;
            this.btnAddTextOverlay.Text = "Add Text Overlay";
            this.btnAddTextOverlay.UseVisualStyleBackColor = true;
            this.btnAddTextOverlay.Click += new System.EventHandler(this.btnAddTextOverlay_Click);
            // 
            // btnAddImageOverlay
            // 
            this.btnAddImageOverlay.Location = new System.Drawing.Point(118, 201);
            this.btnAddImageOverlay.Name = "btnAddImageOverlay";
            this.btnAddImageOverlay.Size = new System.Drawing.Size(106, 23);
            this.btnAddImageOverlay.TabIndex = 26;
            this.btnAddImageOverlay.Text = "Add Image Overlay";
            this.btnAddImageOverlay.UseVisualStyleBackColor = true;
            this.btnAddImageOverlay.Click += new System.EventHandler(this.btnAddImageOverlay_Click);
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Location = new System.Drawing.Point(240, 201);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOverlay.TabIndex = 27;
            this.btnRemoveOverlay.Text = "Remove";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click);
            // 
            // pnlCurrentOverlay
            // 
            this.pnlCurrentOverlay.AutoScroll = true;
            this.pnlCurrentOverlay.BackColor = System.Drawing.Color.LightGray;
            this.pnlCurrentOverlay.Location = new System.Drawing.Point(6, 230);
            this.pnlCurrentOverlay.Name = "pnlCurrentOverlay";
            this.pnlCurrentOverlay.Size = new System.Drawing.Size(312, 168);
            this.pnlCurrentOverlay.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(110, 408);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(515, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 471);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOutputFile);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.btnOutputFile);
            this.tabPage1.Controls.Add(this.cmbWebCam);
            this.tabPage1.Controls.Add(this.nmMotionSensitivity);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nmMotionInterval);
            this.tabPage1.Controls.Add(this.chkEnableWebcam);
            this.tabPage1.Controls.Add(this.nmWebCamWidth);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.cmbMotionDetection);
            this.tabPage1.Controls.Add(this.nmWebCamHeight);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.nmCaptureTop);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cmbCaptureAreaType);
            this.tabPage1.Controls.Add(this.nmWebCamTop);
            this.tabPage1.Controls.Add(this.nmCaptureLeft);
            this.tabPage1.Controls.Add(this.nmWebCamLeft);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cmbVideoCodec);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nmOutputHeight);
            this.tabPage1.Controls.Add(this.nmCaptureWidth);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.nmCaptureHeight);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nmOutputWidth);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbAudioCodecs);
            this.tabPage2.Controls.Add(this.cmbAudioDevices);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chkEnableAudio);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Audio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstOverlays);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.pnlCurrentOverlay);
            this.tabPage4.Controls.Add(this.btnAddTextOverlay);
            this.tabPage4.Controls.Add(this.btnRemoveOverlay);
            this.tabPage4.Controls.Add(this.btnAddImageOverlay);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(321, 445);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Overlays";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtMonitorHeight);
            this.tabPage5.Controls.Add(this.txtMonitorWidth);
            this.tabPage5.Controls.Add(this.txtMonitorTop);
            this.tabPage5.Controls.Add(this.txtMonitorLeft);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.cmbCurrentMonitor);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.txtMonitorCount);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(321, 445);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Monitors";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtMonitorHeight
            // 
            this.txtMonitorHeight.Location = new System.Drawing.Point(163, 90);
            this.txtMonitorHeight.Name = "txtMonitorHeight";
            this.txtMonitorHeight.ReadOnly = true;
            this.txtMonitorHeight.Size = new System.Drawing.Size(45, 20);
            this.txtMonitorHeight.TabIndex = 8;
            // 
            // txtMonitorWidth
            // 
            this.txtMonitorWidth.Location = new System.Drawing.Point(112, 90);
            this.txtMonitorWidth.Name = "txtMonitorWidth";
            this.txtMonitorWidth.ReadOnly = true;
            this.txtMonitorWidth.Size = new System.Drawing.Size(45, 20);
            this.txtMonitorWidth.TabIndex = 7;
            // 
            // txtMonitorTop
            // 
            this.txtMonitorTop.Location = new System.Drawing.Point(163, 64);
            this.txtMonitorTop.Name = "txtMonitorTop";
            this.txtMonitorTop.ReadOnly = true;
            this.txtMonitorTop.Size = new System.Drawing.Size(45, 20);
            this.txtMonitorTop.TabIndex = 6;
            // 
            // txtMonitorLeft
            // 
            this.txtMonitorLeft.Location = new System.Drawing.Point(112, 64);
            this.txtMonitorLeft.Name = "txtMonitorLeft";
            this.txtMonitorLeft.ReadOnly = true;
            this.txtMonitorLeft.Size = new System.Drawing.Size(45, 20);
            this.txtMonitorLeft.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 68);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Monitor dimensions:";
            // 
            // cmbCurrentMonitor
            // 
            this.cmbCurrentMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentMonitor.FormattingEnabled = true;
            this.cmbCurrentMonitor.Location = new System.Drawing.Point(112, 37);
            this.cmbCurrentMonitor.Name = "cmbCurrentMonitor";
            this.cmbCurrentMonitor.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrentMonitor.TabIndex = 3;
            this.cmbCurrentMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentMonitor_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Current monitor:";
            // 
            // txtMonitorCount
            // 
            this.txtMonitorCount.Location = new System.Drawing.Point(112, 11);
            this.txtMonitorCount.Name = "txtMonitorCount";
            this.txtMonitorCount.ReadOnly = true;
            this.txtMonitorCount.Size = new System.Drawing.Size(42, 20);
            this.txtMonitorCount.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(56, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Monitors:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbWriteLog);
            this.tabPage3.Controls.Add(this.btnLogFile);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtLogFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(321, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbWriteLog
            // 
            this.cbWriteLog.AutoSize = true;
            this.cbWriteLog.Location = new System.Drawing.Point(6, 12);
            this.cbWriteLog.Name = "cbWriteLog";
            this.cbWriteLog.Size = new System.Drawing.Size(84, 17);
            this.cbWriteLog.TabIndex = 33;
            this.cbWriteLog.Text = "Write log file";
            this.cbWriteLog.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(340, 408);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(147, 23);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.Text = "Play Last Recorded File";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(26, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "Recording Live Preview:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 486);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.pnlPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bytescout Screen Capturing Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMotionSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMotionInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmWebCamWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOutputWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCaptureWidth)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.ComboBox cmbWebCam;
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbMotionDetection;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nmMotionInterval;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nmMotionSensitivity;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtMonitorHeight;
        private System.Windows.Forms.TextBox txtMonitorWidth;
        private System.Windows.Forms.TextBox txtMonitorTop;
        private System.Windows.Forms.TextBox txtMonitorLeft;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbCurrentMonitor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMonitorCount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cbWriteLog;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label26;
    }
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

namespace ScreenCapturingClient
{
    public partial class Form1 : Form
    {
        ICapturer _capturer;
        int _previewHdc;
        Graphics _previewGraphics;
        private bool _isPaused = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitCapturer()
        {
            _capturer = new CapturerClass();
            _capturer.RegistrationName = "demo";
            _capturer.RegistrationKey = "demo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitCapturer();

                cmbWebCam.Items.Clear();
                for (int i = 0; i < _capturer.WebCamCount; i++)
                {
                    cmbWebCam.Items.Add(_capturer.GetWebCamName(i));
                }
                if (cmbWebCam.Items.Count > 0)
                    cmbWebCam.SelectedIndex = 0;

                cmbVideoCodec.Items.Clear();
                for (int i = 0; i < _capturer.VideoCodecsCount; i++)
                {
                    cmbVideoCodec.Items.Add(_capturer.GetVideoCodecName(i));
                }
                if (cmbVideoCodec.Items.Count > 0)
                    cmbVideoCodec.SelectedIndex = 0;

                cmbAudioDevices.Items.Clear();
                for (int i = 0; i < _capturer.AudioDeviceCount; i++)
                {
                    cmbAudioDevices.Items.Add(_capturer.GetAudioDeviceName(i));
                }
                if (cmbAudioDevices.Items.Count > 0)
                    cmbAudioDevices.SelectedIndex = 0;

                cmbAudioCodecs.Items.Clear();
                for (int i = 0; i < _capturer.AudioCodecsCount; i++)
                {
                    cmbAudioCodecs.Items.Add(_capturer.GetAudioCodecName(i));
                }
                if (cmbAudioCodecs.Items.Count > 0)
                    cmbAudioCodecs.SelectedIndex = 0;

                cmbCaptureAreaType.Items.Clear();
                cmbCaptureAreaType.DataSource = Enum.GetValues(typeof(CaptureAreaType));
                cmbCaptureAreaType.SelectedIndex = 0;

                cmbMotionDetection.Items.Clear();
                cmbMotionDetection.DataSource = Enum.GetValues(typeof(RecordingModeType));
                cmbMotionDetection.SelectedIndex = 0;

                cmbCurrentMonitor.Items.Add(-1);
                cmbCurrentMonitor.Enabled = false;
                if (_capturer.MonitorCount > 1)
                {
                    cmbCurrentMonitor.Enabled = true;
                    for (int i = 0; i < _capturer.MonitorCount; i++)
                    {
                        cmbCurrentMonitor.Items.Add(i);
                    }
                }
                cmbCurrentMonitor.SelectedIndex = 0;

                HandleMonitors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkEnableAudio_CheckedChanged(object sender, EventArgs e)
        {
            cmbAudioDevices.Enabled = chkEnableAudio.Checked;
            cmbAudioCodecs.Enabled = chkEnableAudio.Checked;
        }

        private void chkEnableWebcam_CheckedChanged(object sender, EventArgs e)
        {
            _capturer.AddWebCamVideo = chkEnableWebcam.Checked;

            cmbWebCam.Enabled = chkEnableWebcam.Checked;
            nmWebCamLeft.Enabled = chkEnableWebcam.Checked;
            nmWebCamTop.Enabled = chkEnableWebcam.Checked;
            nmWebCamWidth.Enabled = chkEnableWebcam.Checked;
            nmWebCamHeight.Enabled = chkEnableWebcam.Checked;
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Windows Media Video (*.wmv)|*.wmv| AVI video (*.avi)|*.avi";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = dlg.FileName;
            }
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLogFile.Text = dlg.FileName;
            }
        }

        bool _captureStarted = false;
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capturer.IsRunning)
                {
                    _capturer.Stop();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
                    _capturer = null;
                    InitCapturer();

                    // lstOverlays.Items.Clear();
                    btnRecord.Text = "Record";
                    tabControl1.Enabled = true;
                    lblStatus.Text = "Stopped";
                    timer1.Stop();
                    _captureStarted = false;

                    btnPause.Enabled = false;
                    _isPaused = false;
                }
                else
                {
                    if (!_isPaused)
                    {
                        _capturer.AudioEnabled = chkEnableAudio.Checked;
                        if (chkEnableAudio.Checked)
                        {
                            _capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();
                            //_capturer.CurrentAudioCodecName = cmbAudioCodecs.SelectedItem.ToString();
                        }

                        _capturer.AddWebCamVideo = chkEnableWebcam.Checked;
                        if (chkEnableWebcam.Checked)
                        {
                            _capturer.SetWebCamVideoRectangle((int)nmWebCamLeft.Value, (int)nmWebCamTop.Value, (int)nmWebCamWidth.Value, (int)nmWebCamHeight.Value);
                            _capturer.CurrentWebCamName = cmbWebCam.SelectedItem.ToString();
                        }

                        //_capturer.CurrentVideoCodecName = cmbVideoCodec.SelectedItem.ToString();

                        if (!string.IsNullOrEmpty(txtLogFile.Text) && cbWriteLog.Checked)
                        {
                            _capturer.SetLogFile(txtLogFile.Text);
                        }

                        _capturer.OutputFileName = txtOutputFile.Text;

                        _capturer.CapturingType = (CaptureAreaType)cmbCaptureAreaType.SelectedItem;

                        _previewGraphics = pnlPreview.CreateGraphics();
                        _previewHdc = _previewGraphics.GetHdc().ToInt32();
                        _capturer.SetFullPreviewContext(_previewHdc, 0, 0, pnlPreview.Width, pnlPreview.Height, 5);

                        _capturer.CaptureRectLeft = (int)nmCaptureLeft.Value;
                        _capturer.CaptureRectTop = (int)nmCaptureTop.Value;
                        _capturer.CaptureRectWidth = (int)nmCaptureWidth.Value;
                        _capturer.CaptureRectHeight = (int)nmCaptureHeight.Value;

                        _capturer.OutputWidth = (int)nmOutputWidth.Value;
                        _capturer.OutputHeight = (int)nmOutputHeight.Value;


                        foreach (ListViewItem item in lstOverlays.Items)
                        {
                            Overlay overlay = item.Tag as Overlay;
                            if (overlay is TextOverlay)
                            {
                                TextOverlay textOverlay = overlay as TextOverlay;

                                int a = (int)textOverlay.BackColor.A;
                                //_capturer.AddTextOverlay(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                //                        (int)textOverlay.Font.Size,textOverlay.Font.Bold, textOverlay.Font.Italic,
                                //                        textOverlay.Font.Underline, (uint)ColorTranslator.ToOle(textOverlay.Color));
                                _capturer.AddTextOverlayWithBackground2(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                                        (int)textOverlay.Font.Size, textOverlay.Font.Bold, textOverlay.Font.Italic,
                                                        textOverlay.Font.Underline,
                                                        textOverlay.Color.R, textOverlay.Color.G, textOverlay.Color.B, textOverlay.Color.A,
                                                        textOverlay.BackColor.R, textOverlay.BackColor.G, textOverlay.BackColor.B, textOverlay.BackColor.A);
                            }
                            else if (overlay is ImageOverlay)
                            {
                                ImageOverlay imageOverlay = overlay as ImageOverlay;
                                _capturer.AddImageOverlay(imageOverlay.Left, imageOverlay.Top, imageOverlay.FileName);
                            }
                        }

                        _capturer.RecordingMode = (RecordingModeType)cmbMotionDetection.SelectedItem;
                        _capturer.NoMotionDetectedActionInterval = (int)nmMotionInterval.Value;
                        _capturer.NoMotionDetectedActionSensitivity = (double)nmMotionSensitivity.Value;

                        _capturer.MonitorIndex = (int)cmbCurrentMonitor.SelectedItem;
                    }

                    _capturer.Run();
                    

                    btnRecord.Text = "Stop";
                    tabControl1.Enabled = false;
                    lblStatus.Text = "Running";
                    _captureStarted = true;
                    timer1.Start();

                    _isPaused = false;
                    btnPause.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTextOverlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewOverlay frm = new frmNewOverlay(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    TextOverlay textOverlay = frm.GetOverlay() as TextOverlay;
                    if (_capturer.IsRunning)
                    {
                        //_capturer.AddTextOverlay(overlay.Left, overlay.Top, overlay.Text, overlay.Font.Name, (int)overlay.Font.Size,
                        //                        overlay.Font.Bold, overlay.Font.Italic, overlay.Font.Underline, (uint)ColorTranslator.ToOle(overlay.Color));
                        _capturer.AddTextOverlayWithBackground2(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                                   (int)textOverlay.Font.Size, textOverlay.Font.Bold, textOverlay.Font.Italic,
                                                   textOverlay.Font.Underline,
                                                   textOverlay.Color.R, textOverlay.Color.G, textOverlay.Color.B, textOverlay.Color.A,
                                                   textOverlay.BackColor.R, textOverlay.BackColor.G, textOverlay.BackColor.B, textOverlay.BackColor.A);
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = textOverlay.ToString();
                    item.Tag = textOverlay;
                    lstOverlays.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddImageOverlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewOverlay frm = new frmNewOverlay(false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ImageOverlay overlay = frm.GetOverlay() as ImageOverlay;

                    if (_capturer.IsRunning)
                    {
                        _capturer.AddImageOverlay(overlay.Left, overlay.Top, overlay.FileName);
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = overlay.ToString();
                    item.Tag = overlay;
                    lstOverlays.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            pnlCurrentOverlay.Controls.Clear();
            if (lstOverlays.SelectedItems.Count > 0)
            {
                if (_capturer.IsRunning)
                {
                    _capturer.RemoveOverlay(lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]));
                }
                lstOverlays.Items.Remove(lstOverlays.SelectedItems[0]);

            }
        }

        private void lstOverlays_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCurrentOverlay.Controls.Clear();
            if(lstOverlays.SelectedItems.Count > 0)
            {
                Overlay overlay = lstOverlays.SelectedItems[0].Tag as Overlay;
                if (overlay is TextOverlay)
                {
                    ctrlTextOverlay ctrl = new ctrlTextOverlay(overlay as TextOverlay, lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]), _capturer);
                    ctrl.Dock = DockStyle.Fill;

                    pnlCurrentOverlay.Controls.Add(ctrl);
                }
                else if (overlay is ImageOverlay)
                {
                    ctrlImageOverlay ctrl = new ctrlImageOverlay(overlay as ImageOverlay, lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]), _capturer);
                    ctrl.Dock = DockStyle.Fill;

                    pnlCurrentOverlay.Controls.Add(ctrl);
                }
            }
        }

        private void cmbMotionDetection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordingModeType rmt = (RecordingModeType)cmbMotionDetection.SelectedItem;
            bool enabled = rmt != RecordingModeType.rmtMonitor && rmt != RecordingModeType.rmtRecord;
            nmMotionInterval.Enabled = enabled;
            nmMotionSensitivity.Enabled = enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_isPaused)
            {
                lblStatus.Text = _capturer.IsRunning ? "Running" : "Stopped";
            }
            else
            {
                lblStatus.Text = "Paused";
            }

            if (_captureStarted && !_capturer.IsRunning && !_isPaused)
            {
                lblStatus.Text = "Restarting capturer...";

                System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
                _capturer = null;
                InitCapturer();

                lstOverlays.Items.Clear();
                btnRecord.Text = "Record";
                tabControl1.Enabled = true;
                lblStatus.Text = "Stopped";
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capturer.IsRunning)
            {
                _capturer.Stop();
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
            _capturer = null;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_capturer.IsRunning)
            {
                _capturer.Pause();
                btnPause.Enabled = false;
                btnRecord.Text = "Run";
                _isPaused = true;
            }
        }

        private void HandleMonitors()
        {
            txtMonitorCount.Text = _capturer.MonitorCount.ToString();
            txtMonitorLeft.Text = _capturer.MonitorLeft.ToString();
            txtMonitorTop.Text = _capturer.MonitorTop.ToString();
            txtMonitorWidth.Text = _capturer.MonitorWidth.ToString();
            txtMonitorHeight.Text = _capturer.MonitorHeight.ToString();
        }

        private void cmbCurrentMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_capturer != null)
            {
                _capturer.MonitorIndex = cmbCurrentMonitor.SelectedIndex - 1;
                HandleMonitors();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtOutputFile.Text.Trim()))
            { 
                System.Diagnostics.Process.Start(txtOutputFile.Text.Trim());
            }
        }

        
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Overlay.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ScreenCapturingClient
{
    public class Overlay
    {
        int _left = 0;
        int _top = 0;
        bool _visible = true;

        public int Left { get{return _left;}set{_left = value;}}
        public int Top { get { return _top; } set { _top = value; } }
        public bool Visible { get { return _visible; } set { _visible = value; } }
    }

    public class TextOverlay : Overlay
    {
        string _text = string.Empty;
        Font _font = new Font("Arial", 10f);
        Color _color = Color.Red;
        Color _backColor = Color.Transparent;

        public string Text { get { return _text; } set { _text = value; } }
        public Font Font { get { return _font; } set { _font = value; } }
        public Color Color { get { return _color; } set { _color = value; } }
        public Color BackColor { get { return _backColor; } set { _backColor = value; } }

        public override string ToString()
        {
            return string.Format("Text Overlay. Location: {0}, Text: {1}, Font: {2}", new Point(Left, Top), Text, Font);
        }
    }

    public class ImageOverlay : Overlay
    {
        string _fileName = string.Empty;

        public string FileName { get { return _fileName; } set { _fileName = value; } }

        public override string ToString()
        {
            return string.Format("Image Overlay. Location: {0}, File Name: {1}", new Point(Left, Top), FileName);
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenCapturingClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ScreenCapturingClient.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{09BE0651-AC98-40E1-863C-25C694D57BBD}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ScreenCapturingClient</RootNamespace>
    <AssemblyName>ScreenCapturingClient</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <PlatformTarget>x86</PlatformTarget>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="ctrlImageOverlay.cs">
      <SubType>UserControl</SubType>
    </Compile>
    <Compile Include="ctrlImageOverlay.Designer.cs">
      <DependentUpon>ctrlImageOverlay.cs</DependentUpon>
    </Compile>
    <Compile Include="ctrlTextOverlay.cs">
      <SubType>UserControl</SubType>
    </Compile>
    <Compile Include="ctrlTextOverlay.Designer.cs">
      <DependentUpon>ctrlTextOverlay.cs</DependentUpon>
    </Compile>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="frmNewOverlay.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frmNewOverlay.Designer.cs">
      <DependentUpon>frmNewOverlay.cs</DependentUpon>
    </Compile>
    <Compile Include="Overlay.cs" />
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="ctrlImageOverlay.resx">
      <SubType>Designer</SubType>
      <DependentUpon>ctrlImageOverlay.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="ctrlTextOverlay.resx">
      <SubType>Designer</SubType>
      <DependentUpon>ctrlTextOverlay.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="frmNewOverlay.resx">
      <SubType>Designer</SubType>
      <DependentUpon>frmNewOverlay.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ctrlImageOverlay.Designer.cs:**
    
```
namespace ScreenCapturingClient
{
    partial class ctrlImageOverlay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nmTop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmLeft = new System.Windows.Forms.NumericUpDown();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Top";
            // 
            // nmTop
            // 
            this.nmTop.Location = new System.Drawing.Point(66, 18);
            this.nmTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTop.Name = "nmTop";
            this.nmTop.Size = new System.Drawing.Size(57, 20);
            this.nmTop.TabIndex = 6;
            this.nmTop.ValueChanged += new System.EventHandler(this.nmTop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left";
            // 
            // nmLeft
            // 
            this.nmLeft.Location = new System.Drawing.Point(3, 18);
            this.nmLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmLeft.Name = "nmLeft";
            this.nmLeft.Size = new System.Drawing.Size(57, 20);
            this.nmLeft.TabIndex = 4;
            this.nmLeft.ValueChanged += new System.EventHandler(this.nmLeft_ValueChanged);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(7, 93);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(56, 17);
            this.chkVisible.TabIndex = 14;
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Image filename";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(4, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(445, 20);
            this.txtFileName.TabIndex = 15;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(455, 56);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(33, 23);
            this.btnBrowseFile.TabIndex = 17;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // ctrlImageOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmLeft);
            this.Name = "ctrlImageOverlay";
            this.Size = new System.Drawing.Size(525, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmLeft;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowseFile;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ctrlImageOverlay.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

namespace ScreenCapturingClient
{
    public partial class ctrlImageOverlay : UserControl
    {
        ImageOverlay _imageOverlay = null;
        ICapturer _capturer = null;
        int _index = -1;
        bool _isLoaded = false;

        public ctrlImageOverlay()
        {
            InitializeComponent();
        }

        public ctrlImageOverlay(ImageOverlay imageOverlay, int index, ICapturer capturer)
        {
            InitializeComponent();

            _imageOverlay = imageOverlay;
            _index = index;
            _capturer = capturer;

            nmLeft.Value = _imageOverlay.Left;
            nmTop.Value = _imageOverlay.Top;
            txtFileName.Text = _imageOverlay.FileName;
            chkVisible.Checked = _imageOverlay.Visible;

            txtFileName.Enabled = false;
            btnBrowseFile.Enabled = false;

            _isLoaded = true;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap Files (*.bmp)|*.bmp|Png Files (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlg.FileName;
            }
        }

        private void nmLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _imageOverlay.Left = (int)nmLeft.Value;
            }
        }

        private void nmTop_ValueChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _imageOverlay.Top = (int)nmTop.Value;
            }
        }

        public ImageOverlay GetImageOverlay()
        {
            if (_imageOverlay == null)
            {
                _imageOverlay = new ImageOverlay();
                _imageOverlay.Left = (int)nmLeft.Value;
                _imageOverlay.Top = (int)nmTop.Value;
                _imageOverlay.Visible = chkVisible.Checked;
                _imageOverlay.FileName = txtFileName.Text;
            }

            return _imageOverlay;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayVisibility(_index, chkVisible.Checked);
                _imageOverlay.Visible = chkVisible.Checked;
            }
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ctrlTextOverlay.Designer.cs:**
    
```
namespace ScreenCapturingClient
{
    partial class ctrlTextOverlay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmLeft = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmTop = new System.Windows.Forms.NumericUpDown();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.pnlBackColor = new System.Windows.Forms.Panel();
            this.chkBackColor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).BeginInit();
            this.SuspendLayout();
            // 
            // nmLeft
            // 
            this.nmLeft.Location = new System.Drawing.Point(3, 23);
            this.nmLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmLeft.Name = "nmLeft";
            this.nmLeft.Size = new System.Drawing.Size(57, 20);
            this.nmLeft.TabIndex = 0;
            this.nmLeft.ValueChanged += new System.EventHandler(this.nmLeft_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top";
            // 
            // nmTop
            // 
            this.nmTop.Location = new System.Drawing.Point(66, 23);
            this.nmTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTop.Name = "nmTop";
            this.nmTop.Size = new System.Drawing.Size(57, 20);
            this.nmTop.TabIndex = 2;
            this.nmTop.ValueChanged += new System.EventHandler(this.nmTop_ValueChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(129, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(309, 20);
            this.txtText.TabIndex = 4;
            this.txtText.Text = "Some overlay text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Font";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(3, 65);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(86, 20);
            this.txtFont.TabIndex = 6;
            this.txtFont.Text = "Arial";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(95, 63);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(28, 23);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.IndianRed;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Location = new System.Drawing.Point(129, 65);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(28, 20);
            this.pnlColor.TabIndex = 11;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(163, 63);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(28, 23);
            this.btnColor.TabIndex = 12;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(4, 111);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(56, 17);
            this.chkVisible.TabIndex = 13;
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(444, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Enabled = false;
            this.btnBackColor.Location = new System.Drawing.Point(249, 63);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(28, 23);
            this.btnBackColor.TabIndex = 17;
            this.btnBackColor.Text = "...";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.BackColor = System.Drawing.Color.IndianRed;
            this.pnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackColor.Enabled = false;
            this.pnlBackColor.Location = new System.Drawing.Point(218, 65);
            this.pnlBackColor.Name = "pnlBackColor";
            this.pnlBackColor.Size = new System.Drawing.Size(28, 20);
            this.pnlBackColor.TabIndex = 16;
            // 
            // chkBackColor
            // 
            this.chkBackColor.AutoSize = true;
            this.chkBackColor.Location = new System.Drawing.Point(197, 48);
            this.chkBackColor.Name = "chkBackColor";
            this.chkBackColor.Size = new System.Drawing.Size(77, 17);
            this.chkBackColor.TabIndex = 18;
            this.chkBackColor.Text = "Back color";
            this.chkBackColor.UseVisualStyleBackColor = true;
            this.chkBackColor.CheckedChanged += new System.EventHandler(this.chkBackColor_CheckedChanged);
            // 
            // ctrlTextOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.chkBackColor);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.pnlBackColor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkVisible);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmLeft);
            this.Name = "ctrlTextOverlay";
            this.Size = new System.Drawing.Size(525, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nmLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmTop;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Panel pnlBackColor;
        private System.Windows.Forms.CheckBox chkBackColor;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ctrlTextOverlay.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

namespace ScreenCapturingClient
{
    public partial class ctrlTextOverlay : UserControl
    {
        TextOverlay _textOverlay = null;
        ICapturer _capturer = null;
        int _index = -1;
        bool _isLoaded = false;

        public ctrlTextOverlay()
        {
            InitializeComponent();
            pnlBackColor.BackColor = Color.Transparent;

        }
        public ctrlTextOverlay(TextOverlay textOverlay, int index, ICapturer capturer)
        {
            InitializeComponent();

            _textOverlay = textOverlay;
            _index = index;
            _capturer = capturer;

            nmLeft.Value = _textOverlay.Left;
            nmTop.Value = _textOverlay.Top;
            txtText.Text = _textOverlay.Text;
            txtFont.Text = _textOverlay.Font.Name;
            txtFont.Font = _textOverlay.Font;
            pnlColor.BackColor = _textOverlay.Color;
            chkVisible.Checked = _textOverlay.Visible;
            btnUpdate.Visible = true;

            chkBackColor.Checked = _textOverlay.BackColor != Color.Transparent;
            btnBackColor.Enabled = _textOverlay.BackColor != Color.Transparent;
            pnlBackColor.BackColor = _textOverlay.BackColor;

            txtFont.Enabled = false;
            btnFont.Enabled = false;
            pnlColor.Enabled = false;
            btnColor.Enabled = false;
            chkBackColor.Enabled = false;
            btnBackColor.Enabled = false;
            pnlBackColor.Enabled = false;

            _isLoaded = true;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = txtFont.Font;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFont.Font = dlg.Font;
                txtFont.Text = dlg.Font.Name;

                if (_textOverlay != null)
                {
                    _textOverlay.Font = dlg.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.AnyColor = true;
            dlg.FullOpen = true;
            dlg.CustomColors = new int[] { Color.Transparent.ToArgb() };
           
            dlg.Color = pnlColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = dlg.Color;

                if (_textOverlay != null)
                {
                    _textOverlay.Color = dlg.Color;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1)
            {
                _capturer.UpdateTextOverlay(_index, txtText.Text);
                _textOverlay.Text = txtText.Text;
            }
        }

        private void nmLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _textOverlay.Left = (int)nmLeft.Value; ;
            }
        }

        private void nmTop_ValueChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _textOverlay.Top = (int)nmTop.Value;
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayVisibility(_index, chkVisible.Checked);
                _textOverlay.Visible = chkVisible.Checked;
            }
        }

        public TextOverlay GetTextOverlay()
        {
            if (_textOverlay == null)
            {
                _textOverlay = new TextOverlay();

                _textOverlay.Left = (int)nmLeft.Value;
                _textOverlay.Top = (int)nmTop.Value;
                _textOverlay.Text = txtText.Text;
                _textOverlay.Font = txtFont.Font;
                _textOverlay.Color = pnlColor.BackColor;
                _textOverlay.Visible = chkVisible.Checked;
                _textOverlay.BackColor = pnlBackColor.BackColor;
            }

            return _textOverlay;
        }

        private void chkBackColor_CheckedChanged(object sender, EventArgs e)
        {
            btnBackColor.Enabled = chkBackColor.Checked;
            pnlBackColor.Enabled = chkBackColor.Checked;
            if (!chkBackColor.Checked)
            {
                pnlBackColor.BackColor = Color.Transparent;
            }
            if (_textOverlay != null)
            {
                _textOverlay.BackColor = pnlBackColor.BackColor;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.AnyColor = true;
            dlg.FullOpen = true;

            dlg.Color = pnlBackColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pnlBackColor.BackColor = dlg.Color;

                if (_textOverlay != null)
                {
                    _textOverlay.BackColor = dlg.Color;
                }
            }
        }
       
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****frmNewOverlay.Designer.cs:**
    
```
namespace ScreenCapturingClient
{
    partial class frmNewOverlay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 167);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(351, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(432, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmNewOverlay
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(519, 224);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmNewOverlay";
            this.Text = "Add new overlay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****frmNewOverlay.cs:**
    
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenCapturingClient
{
    public partial class frmNewOverlay : Form
    {
        public frmNewOverlay(bool textOverlay)
        {
            InitializeComponent();

            UserControl ctrl = null;

            if (textOverlay)
            {
                ctrl = new ctrlTextOverlay();
            }
            else
            {
                ctrl = new ctrlImageOverlay();
            }

            ctrl.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctrl);
        }

        public Overlay GetOverlay()
        {
            if (panel1.Controls.Count > 0)
            {
                if (panel1.Controls[0] is ctrlTextOverlay)
                {
                    return ((ctrlTextOverlay)panel1.Controls[0]).GetTextOverlay();
                }
                else if (panel1.Controls[0] is ctrlImageOverlay)
                {
                    return ((ctrlImageOverlay)panel1.Controls[0]).GetImageOverlay();
                }
            }

            return null;
        }
    }
}

```

<!-- code block end -->