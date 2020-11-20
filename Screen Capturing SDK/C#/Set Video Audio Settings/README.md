## How to set video audio settings in C# and ByteScout Screen Capturing SDK

### Tutorial on how to set video audio settings in C#

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. Want to set video audio settings in your C# app? ByteScout Screen Capturing SDK is designed for it. ByteScout Screen Capturing SDK is the tool for developers who want to add screen capturing in their application. Can record screen into video and into single screenshots. Output formats are WMV, AVI, WebM for video and PNG for screenshots. You can adjust output video size, quality, resolution, framerate, video and audio codecs. Includes special privacy features for blacking out sensitive information on screen. Can also capture video from web camera, can add overlays with text or images.

This rich sample source code in C# for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to set video audio settings. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Detailed tutorials and documentation are available along with installed ByteScout Screen Capturing SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of ByteScout Screen Capturing SDK from our website to see and try many others source code samples for C#.

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
namespace VideoAudioSettings
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAudioDevices = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAudioLines = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEnableAudio = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWmv = new System.Windows.Forms.TabPage();
            this.cmbWmvAudioFormats = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbWmvAudioCodecs = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbWmvVideoCodecs = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageAvi = new System.Windows.Forms.TabPage();
            this.cmbAviAudioCodecs = new System.Windows.Forms.ComboBox();
            this.btnVideoCodecProps = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAviVideoCodecs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.rbFullscreen = new System.Windows.Forms.RadioButton();
            this.rbRegionAroundMouse = new System.Windows.Forms.RadioButton();
            this.rbRectRegion = new System.Windows.Forms.RadioButton();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nudMouseHotSpot = new System.Windows.Forms.NumericUpDown();
            this.cbCaptureLayeredWindows = new System.Windows.Forms.CheckBox();
            this.linkViewLog = new System.Windows.Forms.LinkLabel();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.cmbFPS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbWebCameras = new System.Windows.Forms.ComboBox();
            this.tbWebCameraHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbShowWebCamOverlay = new System.Windows.Forms.CheckBox();
            this.tbWebCameraWidth = new System.Windows.Forms.TextBox();
            this.tbWebCameraY = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbWebCameraX = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPauseRecording = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWmv.SuspendLayout();
            this.tabPageAvi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseHotSpot)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbAudioDevices);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbAudioLines);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbEnableAudio);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio Input";
            // 
            // cmbAudioDevices
            // 
            this.cmbAudioDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioDevices.FormattingEnabled = true;
            this.cmbAudioDevices.Location = new System.Drawing.Point(53, 42);
            this.cmbAudioDevices.Name = "cmbAudioDevices";
            this.cmbAudioDevices.Size = new System.Drawing.Size(227, 21);
            this.cmbAudioDevices.TabIndex = 1;
            this.cmbAudioDevices.SelectedIndexChanged += new System.EventHandler(this.cmbAudioDevices_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Device";
            // 
            // cmbAudioLines
            // 
            this.cmbAudioLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAudioLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioLines.FormattingEnabled = true;
            this.cmbAudioLines.Location = new System.Drawing.Point(319, 42);
            this.cmbAudioLines.Name = "cmbAudioLines";
            this.cmbAudioLines.Size = new System.Drawing.Size(216, 21);
            this.cmbAudioLines.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line";
            // 
            // cbEnableAudio
            // 
            this.cbEnableAudio.AutoSize = true;
            this.cbEnableAudio.Checked = true;
            this.cbEnableAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnableAudio.Location = new System.Drawing.Point(9, 19);
            this.cbEnableAudio.Name = "cbEnableAudio";
            this.cbEnableAudio.Size = new System.Drawing.Size(89, 17);
            this.cbEnableAudio.TabIndex = 0;
            this.cbEnableAudio.Text = "Enable Audio";
            this.cbEnableAudio.UseVisualStyleBackColor = true;
            this.cbEnableAudio.CheckedChanged += new System.EventHandler(this.cbEnableAudio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Video Format (SELECT TAB TO SELECT VIDEO FORMAT TO USE)";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageWmv);
            this.tabControl1.Controls.Add(this.tabPageAvi);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 116);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageWmv
            // 
            this.tabPageWmv.Controls.Add(this.cmbWmvAudioFormats);
            this.tabPageWmv.Controls.Add(this.label12);
            this.tabPageWmv.Controls.Add(this.cmbWmvAudioCodecs);
            this.tabPageWmv.Controls.Add(this.label10);
            this.tabPageWmv.Controls.Add(this.cmbWmvVideoCodecs);
            this.tabPageWmv.Controls.Add(this.label11);
            this.tabPageWmv.Location = new System.Drawing.Point(4, 22);
            this.tabPageWmv.Name = "tabPageWmv";
            this.tabPageWmv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWmv.Size = new System.Drawing.Size(521, 90);
            this.tabPageWmv.TabIndex = 1;
            this.tabPageWmv.Text = "WMV Format";
            this.tabPageWmv.UseVisualStyleBackColor = true;
            // 
            // cmbWmvAudioFormats
            // 
            this.cmbWmvAudioFormats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWmvAudioFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWmvAudioFormats.FormattingEnabled = true;
            this.cmbWmvAudioFormats.Location = new System.Drawing.Point(50, 33);
            this.cmbWmvAudioFormats.Name = "cmbWmvAudioFormats";
            this.cmbWmvAudioFormats.Size = new System.Drawing.Size(465, 21);
            this.cmbWmvAudioFormats.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Format";
            // 
            // cmbWmvAudioCodecs
            // 
            this.cmbWmvAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWmvAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWmvAudioCodecs.FormattingEnabled = true;
            this.cmbWmvAudioCodecs.Location = new System.Drawing.Point(50, 6);
            this.cmbWmvAudioCodecs.Name = "cmbWmvAudioCodecs";
            this.cmbWmvAudioCodecs.Size = new System.Drawing.Size(465, 21);
            this.cmbWmvAudioCodecs.TabIndex = 0;
            this.cmbWmvAudioCodecs.SelectedIndexChanged += new System.EventHandler(this.cmbWmvAudioCodecs_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Video";
            // 
            // cmbWmvVideoCodecs
            // 
            this.cmbWmvVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWmvVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWmvVideoCodecs.FormattingEnabled = true;
            this.cmbWmvVideoCodecs.Location = new System.Drawing.Point(50, 60);
            this.cmbWmvVideoCodecs.Name = "cmbWmvVideoCodecs";
            this.cmbWmvVideoCodecs.Size = new System.Drawing.Size(465, 21);
            this.cmbWmvVideoCodecs.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Audio";
            // 
            // tabPageAvi
            // 
            this.tabPageAvi.Controls.Add(this.cmbAviAudioCodecs);
            this.tabPageAvi.Controls.Add(this.btnVideoCodecProps);
            this.tabPageAvi.Controls.Add(this.label3);
            this.tabPageAvi.Controls.Add(this.cmbAviVideoCodecs);
            this.tabPageAvi.Controls.Add(this.label2);
            this.tabPageAvi.Location = new System.Drawing.Point(4, 22);
            this.tabPageAvi.Name = "tabPageAvi";
            this.tabPageAvi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvi.Size = new System.Drawing.Size(521, 90);
            this.tabPageAvi.TabIndex = 2;
            this.tabPageAvi.Text = "AVI format";
            this.tabPageAvi.UseVisualStyleBackColor = true;
            // 
            // cmbAviAudioCodecs
            // 
            this.cmbAviAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAviAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAviAudioCodecs.FormattingEnabled = true;
            this.cmbAviAudioCodecs.Location = new System.Drawing.Point(49, 19);
            this.cmbAviAudioCodecs.Name = "cmbAviAudioCodecs";
            this.cmbAviAudioCodecs.Size = new System.Drawing.Size(434, 21);
            this.cmbAviAudioCodecs.TabIndex = 0;
            // 
            // btnVideoCodecProps
            // 
            this.btnVideoCodecProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoCodecProps.Image = global::VideoAudioSettings.Properties.Resources.wrench;
            this.btnVideoCodecProps.Location = new System.Drawing.Point(489, 42);
            this.btnVideoCodecProps.Name = "btnVideoCodecProps";
            this.btnVideoCodecProps.Size = new System.Drawing.Size(26, 26);
            this.btnVideoCodecProps.TabIndex = 2;
            this.btnVideoCodecProps.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Video";
            // 
            // cmbAviVideoCodecs
            // 
            this.cmbAviVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAviVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAviVideoCodecs.FormattingEnabled = true;
            this.cmbAviVideoCodecs.Location = new System.Drawing.Point(49, 46);
            this.cmbAviVideoCodecs.Name = "cmbAviVideoCodecs";
            this.cmbAviVideoCodecs.Size = new System.Drawing.Size(434, 21);
            this.cmbAviVideoCodecs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Audio";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.rbFullscreen);
            this.groupBox1.Controls.Add(this.rbRegionAroundMouse);
            this.groupBox1.Controls.Add(this.rbRectRegion);
            this.groupBox1.Location = new System.Drawing.Point(12, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Height";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHeight
            // 
            this.tbHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeight.Location = new System.Drawing.Point(484, 44);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(48, 20);
            this.tbHeight.TabIndex = 6;
            this.tbHeight.Text = "480";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Width";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWidth
            // 
            this.tbWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWidth.Location = new System.Drawing.Point(385, 44);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(48, 20);
            this.tbWidth.TabIndex = 5;
            this.tbWidth.Text = "640";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbY
            // 
            this.tbY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbY.Location = new System.Drawing.Point(484, 18);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(48, 20);
            this.tbY.TabIndex = 4;
            this.tbY.Text = "0";
            // 
            // tbX
            // 
            this.tbX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbX.Location = new System.Drawing.Point(385, 18);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(48, 20);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "0";
            // 
            // rbFullscreen
            // 
            this.rbFullscreen.AutoSize = true;
            this.rbFullscreen.Checked = true;
            this.rbFullscreen.Location = new System.Drawing.Point(9, 65);
            this.rbFullscreen.Name = "rbFullscreen";
            this.rbFullscreen.Size = new System.Drawing.Size(76, 17);
            this.rbFullscreen.TabIndex = 2;
            this.rbFullscreen.TabStop = true;
            this.rbFullscreen.Text = "Full screen";
            this.rbFullscreen.UseVisualStyleBackColor = true;
            this.rbFullscreen.CheckedChanged += new System.EventHandler(this.rbFullscreen_CheckedChanged);
            // 
            // rbRegionAroundMouse
            // 
            this.rbRegionAroundMouse.AutoSize = true;
            this.rbRegionAroundMouse.Location = new System.Drawing.Point(9, 42);
            this.rbRegionAroundMouse.Name = "rbRegionAroundMouse";
            this.rbRegionAroundMouse.Size = new System.Drawing.Size(147, 17);
            this.rbRegionAroundMouse.TabIndex = 1;
            this.rbRegionAroundMouse.Text = "Region around the mouse";
            this.rbRegionAroundMouse.UseVisualStyleBackColor = true;
            this.rbRegionAroundMouse.CheckedChanged += new System.EventHandler(this.rbRegionAroundMouse_CheckedChanged);
            // 
            // rbRectRegion
            // 
            this.rbRectRegion.AutoSize = true;
            this.rbRectRegion.Location = new System.Drawing.Point(9, 19);
            this.rbRectRegion.Name = "rbRectRegion";
            this.rbRectRegion.Size = new System.Drawing.Size(115, 17);
            this.rbRectRegion.TabIndex = 0;
            this.rbRectRegion.Text = "Rectangular region";
            this.rbRectRegion.UseVisualStyleBackColor = true;
            this.rbRectRegion.CheckedChanged += new System.EventHandler(this.rbRectRegion_CheckedChanged);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopRecording.Enabled = false;
            this.btnStopRecording.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRecording.Location = new System.Drawing.Point(243, 3);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(114, 70);
            this.btnStopRecording.TabIndex = 2;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRecording.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartRecording.Location = new System.Drawing.Point(0, 3);
            this.btnStartRecording.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(117, 70);
            this.btnStartRecording.TabIndex = 0;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.nudMouseHotSpot);
            this.groupBox4.Controls.Add(this.cbCaptureLayeredWindows);
            this.groupBox4.Controls.Add(this.linkViewLog);
            this.groupBox4.Controls.Add(this.cbLog);
            this.groupBox4.Controls.Add(this.cmbFPS);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Misc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Mouse hot spot radius";
            // 
            // nudMouseHotSpot
            // 
            this.nudMouseHotSpot.Location = new System.Drawing.Point(123, 19);
            this.nudMouseHotSpot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMouseHotSpot.Name = "nudMouseHotSpot";
            this.nudMouseHotSpot.Size = new System.Drawing.Size(60, 20);
            this.nudMouseHotSpot.TabIndex = 1;
            this.nudMouseHotSpot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbCaptureLayeredWindows
            // 
            this.cbCaptureLayeredWindows.AutoSize = true;
            this.cbCaptureLayeredWindows.Location = new System.Drawing.Point(6, 46);
            this.cbCaptureLayeredWindows.Name = "cbCaptureLayeredWindows";
            this.cbCaptureLayeredWindows.Size = new System.Drawing.Size(499, 17);
            this.cbCaptureLayeredWindows.TabIndex = 2;
            this.cbCaptureLayeredWindows.Text = "Capture Layered Windows (transparent windows and controls and WPF based applicati" +
                "on windows) ";
            this.cbCaptureLayeredWindows.UseVisualStyleBackColor = true;
            // 
            // linkViewLog
            // 
            this.linkViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkViewLog.AutoSize = true;
            this.linkViewLog.Location = new System.Drawing.Point(488, 22);
            this.linkViewLog.Name = "linkViewLog";
            this.linkViewLog.Size = new System.Drawing.Size(47, 13);
            this.linkViewLog.TabIndex = 4;
            this.linkViewLog.TabStop = true;
            this.linkViewLog.Text = "View log";
            this.linkViewLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewLog_LinkClicked);
            // 
            // cbLog
            // 
            this.cbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLog.AutoSize = true;
            this.cbLog.Location = new System.Drawing.Point(414, 21);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(68, 17);
            this.cbLog.TabIndex = 3;
            this.cbLog.Text = "Write log";
            this.cbLog.UseVisualStyleBackColor = true;
            // 
            // cmbFPS
            // 
            this.cmbFPS.FormattingEnabled = true;
            this.cmbFPS.Location = new System.Drawing.Point(6, 19);
            this.cmbFPS.Name = "cmbFPS";
            this.cmbFPS.Size = new System.Drawing.Size(60, 21);
            this.cmbFPS.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FPS";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmbWebCameras);
            this.groupBox5.Controls.Add(this.tbWebCameraHeight);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cbShowWebCamOverlay);
            this.groupBox5.Controls.Add(this.tbWebCameraWidth);
            this.groupBox5.Controls.Add(this.tbWebCameraY);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.tbWebCameraX);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(12, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(541, 76);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Web Camera";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Height";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWebCameras
            // 
            this.cmbWebCameras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWebCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWebCameras.FormattingEnabled = true;
            this.cmbWebCameras.Location = new System.Drawing.Point(53, 42);
            this.cmbWebCameras.Name = "cmbWebCameras";
            this.cmbWebCameras.Size = new System.Drawing.Size(278, 21);
            this.cmbWebCameras.TabIndex = 1;
            // 
            // tbWebCameraHeight
            // 
            this.tbWebCameraHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebCameraHeight.Location = new System.Drawing.Point(487, 45);
            this.tbWebCameraHeight.Name = "tbWebCameraHeight";
            this.tbWebCameraHeight.Size = new System.Drawing.Size(48, 20);
            this.tbWebCameraHeight.TabIndex = 5;
            this.tbWebCameraHeight.Text = "120";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Device";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(347, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Width";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbShowWebCamOverlay
            // 
            this.cbShowWebCamOverlay.AutoSize = true;
            this.cbShowWebCamOverlay.Location = new System.Drawing.Point(9, 19);
            this.cbShowWebCamOverlay.Name = "cbShowWebCamOverlay";
            this.cbShowWebCamOverlay.Size = new System.Drawing.Size(200, 17);
            this.cbShowWebCamOverlay.TabIndex = 0;
            this.cbShowWebCamOverlay.Text = "Show video stream from web camera";
            this.cbShowWebCamOverlay.UseVisualStyleBackColor = true;
            // 
            // tbWebCameraWidth
            // 
            this.tbWebCameraWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebCameraWidth.Location = new System.Drawing.Point(388, 45);
            this.tbWebCameraWidth.Name = "tbWebCameraWidth";
            this.tbWebCameraWidth.Size = new System.Drawing.Size(48, 20);
            this.tbWebCameraWidth.TabIndex = 3;
            this.tbWebCameraWidth.Text = "160";
            // 
            // tbWebCameraY
            // 
            this.tbWebCameraY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebCameraY.Location = new System.Drawing.Point(487, 19);
            this.tbWebCameraY.Name = "tbWebCameraY";
            this.tbWebCameraY.Size = new System.Drawing.Size(48, 20);
            this.tbWebCameraY.TabIndex = 4;
            this.tbWebCameraY.Text = "10";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(467, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Y";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbWebCameraX
            // 
            this.tbWebCameraX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebCameraX.Location = new System.Drawing.Point(388, 19);
            this.tbWebCameraX.Name = "tbWebCameraX";
            this.tbWebCameraX.Size = new System.Drawing.Size(48, 20);
            this.tbWebCameraX.TabIndex = 2;
            this.tbWebCameraX.Text = "10";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(368, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "X";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnPauseRecording, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStopRecording, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartRecording, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 499);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 76);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnPauseRecording
            // 
            this.btnPauseRecording.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseRecording.Enabled = false;
            this.btnPauseRecording.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPauseRecording.Location = new System.Drawing.Point(123, 3);
            this.btnPauseRecording.Name = "btnPauseRecording";
            this.btnPauseRecording.Size = new System.Drawing.Size(114, 70);
            this.btnPauseRecording.TabIndex = 1;
            this.btnPauseRecording.Text = "Pause Recording\r\n";
            this.btnPauseRecording.UseVisualStyleBackColor = true;
            this.btnPauseRecording.Click += new System.EventHandler(this.btnPauseRecording_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.BackColor = System.Drawing.SystemColors.Info;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(363, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 70);
            this.label19.TabIndex = 3;
            this.label19.Text = "Full source code of this sample is available in Start | Bytescout Screen Capturin" +
                "g SDK | Advanced Examples | Audio and video settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Capturing";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageWmv.ResumeLayout(false);
            this.tabPageWmv.PerformLayout();
            this.tabPageAvi.ResumeLayout(false);
            this.tabPageAvi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseHotSpot)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbAudioLines;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbEnableAudio;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.LinkLabel linkViewLog;
		private System.Windows.Forms.CheckBox cbLog;
		private System.Windows.Forms.ComboBox cmbFPS;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rbFullscreen;
		private System.Windows.Forms.RadioButton rbRegionAroundMouse;
		private System.Windows.Forms.RadioButton rbRectRegion;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStopRecording;
		private System.Windows.Forms.Button btnStartRecording;
		private System.Windows.Forms.ComboBox cmbAudioDevices;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageWmv;
		private System.Windows.Forms.ComboBox cmbWmvAudioFormats;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbWmvAudioCodecs;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbWmvVideoCodecs;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageAvi;
        private System.Windows.Forms.ComboBox cmbAviAudioCodecs;
        private System.Windows.Forms.Button btnVideoCodecProps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAviVideoCodecs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox cmbWebCameras;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox cbShowWebCamOverlay;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbWebCameraHeight;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbWebCameraWidth;
		private System.Windows.Forms.TextBox tbWebCameraY;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox tbWebCameraX;
        private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnPauseRecording;
		private System.Windows.Forms.CheckBox cbCaptureLayeredWindows;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.NumericUpDown nudMouseHotSpot;
		private System.Windows.Forms.Label label19;
	}
}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.cs:**
    
```
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;
using System.Drawing;

// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 
// Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference


namespace VideoAudioSettings
{
	public partial class Form1 : Form
	{
		private Capturer capturer = null;

		private bool _recording = false;
		private bool _paused = false;

		public Form1()
		{
			InitializeComponent();

			// Create Capturer instance
			capturer = new Capturer();
			capturer.RegistrationName = "demo"; // put your registration name here
			capturer.RegistrationKey = "demo";  // put your registration key here
			

			// Get list of available audio devices
			for (int i = 0; i < capturer.AudioDeviceCount; i++)
			{
				string line = capturer.GetAudioDeviceName(i);
				cmbAudioDevices.Items.Add(line);
			}

			// Select current audio device
			cmbAudioDevices.SelectedIndex = capturer.CurrentAudioDevice;

			// Get list of available AVI audio codecs
			for (int i = 0; i < capturer.AudioCodecsCount; i++)
			{
				string codec = capturer.GetAudioCodecName(i);
				cmbAviAudioCodecs.Items.Add(codec);
			}

			// Select current AVI audio codec
			cmbAviAudioCodecs.SelectedIndex = capturer.CurrentAudioCodec;


			// Get list of available web camera devices
			for (int i = 0; i < capturer.WebCamCount; i++)
			{
				string camera = capturer.GetWebCamName(i);
				cmbWebCameras.Items.Add(camera);
			}

			// Select current web camera
			if (cmbWebCameras.Items.Count != 0)
			{
				cmbWebCameras.SelectedIndex = capturer.CurrentWebCam;
			}
			else
			{
				cmbWebCameras.Items.Add("No devices");
				cmbWebCameras.SelectedIndex = 0;
				cmbWebCameras.Enabled = false;
				cbShowWebCamOverlay.Enabled = false;
			}

			// Get list of available AVI video codecs
			for (int i = 0; i < capturer.VideoCodecsCount; i++)
			{
				string codec = capturer.GetVideoCodecName(i);
				cmbAviVideoCodecs.Items.Add(codec);
			}

			// Select current AVI video codec
			cmbAviVideoCodecs.SelectedIndex = capturer.CurrentVideoCodec;

			// Get list of available WMV audio codecs
			for (int i = 0; i < capturer.WMVAudioCodecsCount; i++)
			{
				string codec = capturer.GetWMVAudioCodecName(i);
				cmbWmvAudioCodecs.Items.Add(codec);
			}

			// Select current WMV audio codec
			cmbWmvAudioCodecs.SelectedIndex = capturer.CurrentWMVAudioCodec;

			// Get list of available WMV video codecs
			for (int i = 0; i < capturer.WMVVideoCodecsCount; i++)
			{
				string codec = capturer.GetWMVVideoCodecName(i);
				cmbWmvVideoCodecs.Items.Add(codec);
			}

			// Select current WMV video codec
			cmbWmvVideoCodecs.SelectedIndex = capturer.CurrentWMVVideoCodec;


			// Fill list of FPS values
			cmbFPS.Items.AddRange(new object[] { 5f, 7.5f, 10f, 12f, 14.985f, 15f, 19.98f, 20f, 23.976f, 24f, 25f, 29.97f, 30f, 50f, 59.94f, 60 });
			// Select current FPS
			cmbFPS.SelectedItem = 14.985f;

			cbCaptureLayeredWindows.Checked = capturer.CaptureTransparentControls;

			nudMouseHotSpot.Value = capturer.MouseSpotRadius;
		}

		// Rectangular region recording mode is selected
		private void cbEnableAudio_CheckedChanged(object sender, EventArgs e)
		{
			cmbAudioDevices.Enabled = cbEnableAudio.Checked;
			cmbAudioLines.Enabled = cbEnableAudio.Checked;
		}

		private void cmbAudioDevices_SelectedIndexChanged(object sender, EventArgs e)
		{
			capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();

			cmbAudioLines.Items.Clear();

			// Get list of available audio lines of current audio device
			for (int i = 0; i < capturer.CurrentAudioDeviceLineCount; i++)
			{
				string line = capturer.GetCurrentAudioDeviceLineName(i);
				cmbAudioLines.Items.Add(line);
			}

			// Select current audio line
            if (cmbAudioLines.Items.Count > 0)
            {
                cmbAudioLines.SelectedIndex = capturer.CurrentAudioDeviceLine;
            }
		}

		private void cmbWmvAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
		{
			capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();

			cmbWmvAudioFormats.Items.Clear();

			// Get list of available WMV audio formats
			for (int i = 0; i < capturer.WMVAudioFormatCount; i++)
			{
				string codec = capturer.GetWMVAudioFormatDescription(i);
				cmbWmvAudioFormats.Items.Add(codec);
			}

			// Select current WMV audio format
			cmbWmvAudioFormats.SelectedIndex = capturer.CurrentWMVAudioFormat;
		}

		private void rbRectRegion_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Region around the mouse recording mode is selected
		private void rbRegionAroundMouse_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Full screen recording mode is selected
		private void rbFullscreen_CheckedChanged(object sender, System.EventArgs e)
		{
			tbX.Enabled = rbRectRegion.Checked;
			tbY.Enabled = rbRectRegion.Checked;
			tbWidth.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
			tbHeight.Enabled = rbRectRegion.Checked || rbRegionAroundMouse.Checked;
		}

		// Show video code internal properties dialog
		private void btnVideoCodecProps_Click(object sender, System.EventArgs e)
		{
			capturer.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex;
			capturer.ShowVideoCodecSettingsDialog(Handle.ToInt32());
		}

		// Show log
		private void linkViewLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string logFile = Path.GetTempPath() + "Capturing Log.txt";

			if (File.Exists(logFile))
			{
				Process prc = new Process();
				prc.StartInfo.FileName = logFile;
				prc.StartInfo.UseShellExecute = true;

				try
				{
					prc.Start();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}    
		
		private void btnStartRecording_Click(object sender, System.EventArgs e)
		{
			// Set up the capturer

			if (cbLog.Checked)
			{
				capturer.SetLogFile(Path.GetTempPath() + "Capturing Log.txt");
			}

			bool captureToAvi = (tabControl1.SelectedIndex == 1);

			capturer.AudioEnabled = cbEnableAudio.Checked;
			capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();
            if (cmbAudioLines.Items.Count>0)
            {
                capturer.CurrentAudioDeviceLineName = cmbAudioLines.SelectedItem.ToString();
            }
				
			if (captureToAvi)
			{
				capturer.CurrentAudioCodecName = cmbAviAudioCodecs.SelectedItem.ToString();
				capturer.CurrentVideoCodecName = cmbAviVideoCodecs.SelectedItem.ToString();
			}
			else // capture to WMV
			{
				capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();
				capturer.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex;
				capturer.CurrentWMVVideoCodecName = cmbWmvVideoCodecs.SelectedItem.ToString();
			}

			capturer.MouseAnimationDuration = 400;
			capturer.FPS = float.Parse(cmbFPS.Text);
			capturer.CaptureTransparentControls = cbCaptureLayeredWindows.Checked;
			capturer.MouseSpotRadius = (int) nudMouseHotSpot.Value;

			capturer.OutputWidth = int.Parse(tbWidth.Text);
			capturer.OutputHeight = int.Parse(tbHeight.Text);

			// Set capturing mode

			if (rbRectRegion.Checked)
			{
				capturer.CapturingType = CaptureAreaType.catRegion;
			}
			else if (rbRegionAroundMouse.Checked)
			{
				capturer.CapturingType = CaptureAreaType.catMouse;
			}
			else
			{
				capturer.CapturingType = CaptureAreaType.catScreen;
			}

			if (cbShowWebCamOverlay.Checked)
			{
				// Set web camera device to add overlaying video to the source
				capturer.AddWebCamVideo = true;

				// Set device name or you can set device by index using .CurrentCaptureDevice property
				capturer.CurrentWebCam = cmbWebCameras.SelectedIndex;

				// Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10,10)
				capturer.SetWebCamVideoRectangle(
					int.Parse(tbWebCameraX.Text), 
					int.Parse(tbWebCameraY.Text), 
					int.Parse(tbWebCameraWidth.Text), 
					int.Parse(tbWebCameraHeight.Text));
			}


            // set border around captured area if we are not capturing entire screen
            if (
                capturer.CapturingType != CaptureAreaType.catScreen &&
                capturer.CapturingType != CaptureAreaType.catWebcamFullScreen
                )
            {
                // set border style
                capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed;
                capturer.CaptureAreaBorderColor = (uint)ColorTranslator.ToOle(Color.Red);
            }

			// Save to temp file

			String filename = Path.GetTempFileName();
			filename = Path.ChangeExtension(filename, captureToAvi ? "avi" : "wmv");
			capturer.OutputFileName = filename;
			
			try
			{
				// Start capturing
				try
				{
					Cursor = Cursors.WaitCursor;
					capturer.Run();
				}
				finally
				{
					Cursor = Cursors.Default;
				}

				_recording = true;
				btnStartRecording.Enabled = false;
				btnPauseRecording.Enabled = true;
				btnStopRecording.Enabled = true;

				// Wait for "Stop Recording" button pressed
				while (_recording)
				{
					Thread.Sleep(10);
					Application.DoEvents();
				}

				// Stop capturing
				try
				{
					Cursor = Cursors.WaitCursor;
					capturer.Stop();
				}
				finally
				{
					Cursor = Cursors.Default;
				}

				// Ask for output file name
				SaveFileDialog dlg = new SaveFileDialog();

				dlg.Title = @"Save captured video as";
				dlg.FileName = @"Screencast";

				if (captureToAvi)
				{
					dlg.DefaultExt = @"*.avi";
					dlg.Filter = @"AVI files (*.avi)|*.avi|All files (*.*)|*.*";
				}
				else
				{
					dlg.DefaultExt = @"*.wmv";
					dlg.Filter = @"WMV files (*.wmv)|*.wmv|All files (*.*)|*.*";
				}
				
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save to specified file name
					File.Copy(capturer.OutputFileName, dlg.FileName, true);
				}

				// clean up
				try
				{
					File.Delete(capturer.OutputFileName);
				}
				catch
				{
				}

				btnStartRecording.Enabled = true;
				btnPauseRecording.Enabled = false;
				btnStopRecording.Enabled = false;

                // open saved video in default video viewer
				try
				{
					Process.Start(dlg.FileName);
				}
				catch
				{
				}
			}
			catch (COMException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnPauseRecording_Click(object sender, EventArgs e)
		{
			bool captureToAvi = (tabControl1.SelectedIndex == 1);

			if (captureToAvi)
			{
				MessageBox.Show("Pausing is only available for WMV format yet.");
				return;
			}

			if (!_paused)
			{
				capturer.Pause();
				_paused = true;
				btnPauseRecording.Text = "Resume recodring";
			}
			else
			{
				// Resume capturing
				capturer.Run(); 
				_paused = false;
				btnPauseRecording.Text = "Pause recording";
			}
		}

		private void btnStopRecording_Click(object sender, System.EventArgs e)
		{
			// Toggle recording flag
			if (_recording)
			{
				_recording = false;
			}
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

namespace VideoAudioSettings
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

##### ****VideoAudioSettings.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{11A1BC38-6283-4C2D-AA81-DCDC4FAEE745}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>VideoAudioSettings</RootNamespace>
    <AssemblyName>VideoAudioSettings</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
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
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
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

##### ****VideoAudioSettings.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{11A1BC38-6283-4C2D-AA81-DCDC4FAEE745}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>VideoAudioSettings</RootNamespace>
    <AssemblyName>VideoAudioSettings</AssemblyName>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
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
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### ****VideoAudioSettings.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{11A1BC38-6283-4C2D-AA81-DCDC4FAEE745}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>VideoAudioSettings</RootNamespace>
    <AssemblyName>VideoAudioSettings</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
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
    <None Include="Resources\wrench.png" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutScreenCapturingLib">
      <Guid>{8EDAD3BB-AE5F-43B4-A2F1-B04F4130F2E0}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
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
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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