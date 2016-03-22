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
            this.groupBox3.Text = "Auidio Input";
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

