Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.cmbAudioDevices = New System.Windows.Forms.ComboBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.cmbAudioLines = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cbEnableAudio = New System.Windows.Forms.CheckBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageWmv = New System.Windows.Forms.TabPage()
		Me.cmbWmvAudioFormats = New System.Windows.Forms.ComboBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.cmbWmvAudioCodecs = New System.Windows.Forms.ComboBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.cmbWmvVideoCodecs = New System.Windows.Forms.ComboBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.tabPageAvi = New System.Windows.Forms.TabPage()
		Me.cmbAviAudioCodecs = New System.Windows.Forms.ComboBox()
		Me.btnVideoCodecProps = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cmbAviVideoCodecs = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.tbHeight = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tbWidth = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbY = New System.Windows.Forms.TextBox()
		Me.tbX = New System.Windows.Forms.TextBox()
		Me.rbFullscreen = New System.Windows.Forms.RadioButton()
		Me.rbRegionAroundMouse = New System.Windows.Forms.RadioButton()
		Me.rbRectRegion = New System.Windows.Forms.RadioButton()
		Me.btnStopRecording = New System.Windows.Forms.Button()
		Me.btnStartRecording = New System.Windows.Forms.Button()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.label18 = New System.Windows.Forms.Label()
		Me.nudMouseHotSpot = New System.Windows.Forms.NumericUpDown()
		Me.cbCaptureLayeredWindows = New System.Windows.Forms.CheckBox()
		Me.linkViewLog = New System.Windows.Forms.LinkLabel()
		Me.cbLog = New System.Windows.Forms.CheckBox()
		Me.cmbFPS = New System.Windows.Forms.ComboBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.cmbWebCameras = New System.Windows.Forms.ComboBox()
		Me.tbWebCameraHeight = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.cbShowWebCamOverlay = New System.Windows.Forms.CheckBox()
		Me.tbWebCameraWidth = New System.Windows.Forms.TextBox()
		Me.tbWebCameraY = New System.Windows.Forms.TextBox()
		Me.label16 = New System.Windows.Forms.Label()
		Me.tbWebCameraX = New System.Windows.Forms.TextBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.btnPauseRecording = New System.Windows.Forms.Button()
		Me.label19 = New System.Windows.Forms.Label()
		Me.groupBox3.SuspendLayout()
		Me.groupBox2.SuspendLayout()
		Me.tabControl1.SuspendLayout()
		Me.tabPageWmv.SuspendLayout()
		Me.tabPageAvi.SuspendLayout()
		Me.groupBox1.SuspendLayout()
		Me.groupBox4.SuspendLayout()
		DirectCast(Me.nudMouseHotSpot, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox5.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' groupBox3
		' 
		Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox3.Controls.Add(Me.cmbAudioDevices)
		Me.groupBox3.Controls.Add(Me.label9)
		Me.groupBox3.Controls.Add(Me.cmbAudioLines)
		Me.groupBox3.Controls.Add(Me.label1)
		Me.groupBox3.Controls.Add(Me.cbEnableAudio)
		Me.groupBox3.Location = New System.Drawing.Point(12, 12)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(541, 101)
		Me.groupBox3.TabIndex = 0
		Me.groupBox3.TabStop = False
		Me.groupBox3.Text = "Auidio Input"
		' 
		' cmbAudioDevices
		' 
		Me.cmbAudioDevices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAudioDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAudioDevices.FormattingEnabled = True
		Me.cmbAudioDevices.Location = New System.Drawing.Point(53, 42)
		Me.cmbAudioDevices.Name = "cmbAudioDevices"
		Me.cmbAudioDevices.Size = New System.Drawing.Size(482, 21)
		Me.cmbAudioDevices.TabIndex = 1
		AddHandler Me.cmbAudioDevices.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbAudioDevices_SelectedIndexChanged)
		' 
		' label9
		' 
		Me.label9.AutoSize = True
		Me.label9.Location = New System.Drawing.Point(6, 45)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(41, 13)
		Me.label9.TabIndex = 5
		Me.label9.Text = "Device"
		' 
		' cmbAudioLines
		' 
		Me.cmbAudioLines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAudioLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAudioLines.FormattingEnabled = True
		Me.cmbAudioLines.Location = New System.Drawing.Point(53, 67)
		Me.cmbAudioLines.Name = "cmbAudioLines"
		Me.cmbAudioLines.Size = New System.Drawing.Size(482, 21)
		Me.cmbAudioLines.TabIndex = 2
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(6, 70)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(27, 13)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Line"
		' 
		' cbEnableAudio
		' 
		Me.cbEnableAudio.AutoSize = True
		Me.cbEnableAudio.Checked = True
		Me.cbEnableAudio.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbEnableAudio.Location = New System.Drawing.Point(9, 19)
		Me.cbEnableAudio.Name = "cbEnableAudio"
		Me.cbEnableAudio.Size = New System.Drawing.Size(89, 17)
		Me.cbEnableAudio.TabIndex = 0
		Me.cbEnableAudio.Text = "Enable Audio"
		Me.cbEnableAudio.UseVisualStyleBackColor = True
		AddHandler Me.cbEnableAudio.CheckedChanged, New System.EventHandler(AddressOf Me.cbEnableAudio_CheckedChanged)
		' 
		' groupBox2
		' 
		Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox2.Controls.Add(Me.tabControl1)
		Me.groupBox2.Location = New System.Drawing.Point(12, 201)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(541, 143)
		Me.groupBox2.TabIndex = 2
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "Output Video Format (SELECT TAB TO SELECT VIDEO FORMAT TO USE)"
		' 
		' tabControl1
		' 
		Me.tabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl1.Controls.Add(Me.tabPageWmv)
		Me.tabControl1.Controls.Add(Me.tabPageAvi)
		Me.tabControl1.Location = New System.Drawing.Point(6, 19)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(529, 116)
		Me.tabControl1.TabIndex = 8
		' 
		' tabPageWmv
		' 
		Me.tabPageWmv.Controls.Add(Me.cmbWmvAudioFormats)
		Me.tabPageWmv.Controls.Add(Me.label12)
		Me.tabPageWmv.Controls.Add(Me.cmbWmvAudioCodecs)
		Me.tabPageWmv.Controls.Add(Me.label10)
		Me.tabPageWmv.Controls.Add(Me.cmbWmvVideoCodecs)
		Me.tabPageWmv.Controls.Add(Me.label11)
		Me.tabPageWmv.Location = New System.Drawing.Point(4, 22)
		Me.tabPageWmv.Name = "tabPageWmv"
		Me.tabPageWmv.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageWmv.Size = New System.Drawing.Size(521, 90)
		Me.tabPageWmv.TabIndex = 1
		Me.tabPageWmv.Text = "WMV Format"
		Me.tabPageWmv.UseVisualStyleBackColor = True
		' 
		' cmbWmvAudioFormats
		' 
		Me.cmbWmvAudioFormats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvAudioFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvAudioFormats.FormattingEnabled = True
		Me.cmbWmvAudioFormats.Location = New System.Drawing.Point(50, 33)
		Me.cmbWmvAudioFormats.Name = "cmbWmvAudioFormats"
		Me.cmbWmvAudioFormats.Size = New System.Drawing.Size(465, 21)
		Me.cmbWmvAudioFormats.TabIndex = 1
		' 
		' label12
		' 
		Me.label12.AutoSize = True
		Me.label12.Location = New System.Drawing.Point(6, 36)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(39, 13)
		Me.label12.TabIndex = 14
		Me.label12.Text = "Format"
		' 
		' cmbWmvAudioCodecs
		' 
		Me.cmbWmvAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvAudioCodecs.FormattingEnabled = True
		Me.cmbWmvAudioCodecs.Location = New System.Drawing.Point(50, 6)
		Me.cmbWmvAudioCodecs.Name = "cmbWmvAudioCodecs"
		Me.cmbWmvAudioCodecs.Size = New System.Drawing.Size(465, 21)
		Me.cmbWmvAudioCodecs.TabIndex = 0
		AddHandler Me.cmbWmvAudioCodecs.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbWmvAudioCodecs_SelectedIndexChanged)
		' 
		' label10
		' 
		Me.label10.AutoSize = True
		Me.label10.Location = New System.Drawing.Point(6, 63)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(34, 13)
		Me.label10.TabIndex = 12
		Me.label10.Text = "Video"
		' 
		' cmbWmvVideoCodecs
		' 
		Me.cmbWmvVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWmvVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWmvVideoCodecs.FormattingEnabled = True
		Me.cmbWmvVideoCodecs.Location = New System.Drawing.Point(50, 60)
		Me.cmbWmvVideoCodecs.Name = "cmbWmvVideoCodecs"
		Me.cmbWmvVideoCodecs.Size = New System.Drawing.Size(465, 21)
		Me.cmbWmvVideoCodecs.TabIndex = 2
		' 
		' label11
		' 
		Me.label11.AutoSize = True
		Me.label11.Location = New System.Drawing.Point(6, 9)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(34, 13)
		Me.label11.TabIndex = 11
		Me.label11.Text = "Audio"
		' 
		' tabPageAvi
		' 
		Me.tabPageAvi.Controls.Add(Me.cmbAviAudioCodecs)
		Me.tabPageAvi.Controls.Add(Me.btnVideoCodecProps)
		Me.tabPageAvi.Controls.Add(Me.label3)
		Me.tabPageAvi.Controls.Add(Me.cmbAviVideoCodecs)
		Me.tabPageAvi.Controls.Add(Me.label2)
		Me.tabPageAvi.Location = New System.Drawing.Point(4, 22)
		Me.tabPageAvi.Name = "tabPageAvi"
		Me.tabPageAvi.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageAvi.Size = New System.Drawing.Size(521, 90)
		Me.tabPageAvi.TabIndex = 2
		Me.tabPageAvi.Text = "AVI format"
		Me.tabPageAvi.UseVisualStyleBackColor = True
		' 
		' cmbAviAudioCodecs
		' 
		Me.cmbAviAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAviAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAviAudioCodecs.FormattingEnabled = True
		Me.cmbAviAudioCodecs.Location = New System.Drawing.Point(49, 19)
		Me.cmbAviAudioCodecs.Name = "cmbAviAudioCodecs"
		Me.cmbAviAudioCodecs.Size = New System.Drawing.Size(434, 21)
		Me.cmbAviAudioCodecs.TabIndex = 0
		' 
		' btnVideoCodecProps
		' 
		Me.btnVideoCodecProps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVideoCodecProps.Image = Global.VideoAudioSettings.My.Resources.Resources.wrench
		Me.btnVideoCodecProps.Location = New System.Drawing.Point(489, 42)
		Me.btnVideoCodecProps.Name = "btnVideoCodecProps"
		Me.btnVideoCodecProps.Size = New System.Drawing.Size(26, 26)
		Me.btnVideoCodecProps.TabIndex = 2
		Me.btnVideoCodecProps.UseVisualStyleBackColor = True
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(5, 49)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(34, 13)
		Me.label3.TabIndex = 7
		Me.label3.Text = "Video"
		' 
		' cmbAviVideoCodecs
		' 
		Me.cmbAviVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbAviVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAviVideoCodecs.FormattingEnabled = True
		Me.cmbAviVideoCodecs.Location = New System.Drawing.Point(49, 46)
		Me.cmbAviVideoCodecs.Name = "cmbAviVideoCodecs"
		Me.cmbAviVideoCodecs.Size = New System.Drawing.Size(434, 21)
		Me.cmbAviVideoCodecs.TabIndex = 1
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(5, 22)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(34, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Audio"
		' 
		' groupBox1
		' 
		Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox1.Controls.Add(Me.label8)
		Me.groupBox1.Controls.Add(Me.tbHeight)
		Me.groupBox1.Controls.Add(Me.label7)
		Me.groupBox1.Controls.Add(Me.tbWidth)
		Me.groupBox1.Controls.Add(Me.label6)
		Me.groupBox1.Controls.Add(Me.label5)
		Me.groupBox1.Controls.Add(Me.tbY)
		Me.groupBox1.Controls.Add(Me.tbX)
		Me.groupBox1.Controls.Add(Me.rbFullscreen)
		Me.groupBox1.Controls.Add(Me.rbRegionAroundMouse)
		Me.groupBox1.Controls.Add(Me.rbRectRegion)
		Me.groupBox1.Location = New System.Drawing.Point(12, 455)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(541, 92)
		Me.groupBox1.TabIndex = 4
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Capture"
		' 
		' label8
		' 
		Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label8.AutoSize = True
		Me.label8.Location = New System.Drawing.Point(440, 47)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(38, 13)
		Me.label8.TabIndex = 10
		Me.label8.Text = "Height"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' tbHeight
		' 
		Me.tbHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbHeight.Location = New System.Drawing.Point(484, 44)
		Me.tbHeight.Name = "tbHeight"
		Me.tbHeight.Size = New System.Drawing.Size(48, 20)
		Me.tbHeight.TabIndex = 6
		Me.tbHeight.Text = "480"
		' 
		' label7
		' 
		Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label7.AutoSize = True
		Me.label7.Location = New System.Drawing.Point(344, 47)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(35, 13)
		Me.label7.TabIndex = 8
		Me.label7.Text = "Width"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' tbWidth
		' 
		Me.tbWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbWidth.Location = New System.Drawing.Point(385, 44)
		Me.tbWidth.Name = "tbWidth"
		Me.tbWidth.Size = New System.Drawing.Size(48, 20)
		Me.tbWidth.TabIndex = 5
		Me.tbWidth.Text = "640"
		' 
		' label6
		' 
		Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label6.AutoSize = True
		Me.label6.Location = New System.Drawing.Point(464, 21)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(14, 13)
		Me.label6.TabIndex = 6
		Me.label6.Text = "Y"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' label5
		' 
		Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(365, 21)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(14, 13)
		Me.label5.TabIndex = 5
		Me.label5.Text = "X"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' tbY
		' 
		Me.tbY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbY.Location = New System.Drawing.Point(484, 18)
		Me.tbY.Name = "tbY"
		Me.tbY.Size = New System.Drawing.Size(48, 20)
		Me.tbY.TabIndex = 4
		Me.tbY.Text = "0"
		' 
		' tbX
		' 
		Me.tbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbX.Location = New System.Drawing.Point(385, 18)
		Me.tbX.Name = "tbX"
		Me.tbX.Size = New System.Drawing.Size(48, 20)
		Me.tbX.TabIndex = 3
		Me.tbX.Text = "0"
		' 
		' rbFullscreen
		' 
		Me.rbFullscreen.AutoSize = True
		Me.rbFullscreen.Checked = True
		Me.rbFullscreen.Location = New System.Drawing.Point(9, 65)
		Me.rbFullscreen.Name = "rbFullscreen"
		Me.rbFullscreen.Size = New System.Drawing.Size(76, 17)
		Me.rbFullscreen.TabIndex = 2
		Me.rbFullscreen.TabStop = True
		Me.rbFullscreen.Text = "Full screen"
		Me.rbFullscreen.UseVisualStyleBackColor = True
		AddHandler Me.rbFullscreen.CheckedChanged, New System.EventHandler(AddressOf Me.rbFullscreen_CheckedChanged)
		' 
		' rbRegionAroundMouse
		' 
		Me.rbRegionAroundMouse.AutoSize = True
		Me.rbRegionAroundMouse.Location = New System.Drawing.Point(9, 42)
		Me.rbRegionAroundMouse.Name = "rbRegionAroundMouse"
		Me.rbRegionAroundMouse.Size = New System.Drawing.Size(147, 17)
		Me.rbRegionAroundMouse.TabIndex = 1
		Me.rbRegionAroundMouse.Text = "Region around the mouse"
		Me.rbRegionAroundMouse.UseVisualStyleBackColor = True
		AddHandler Me.rbRegionAroundMouse.CheckedChanged, New System.EventHandler(AddressOf Me.rbRegionAroundMouse_CheckedChanged)
		' 
		' rbRectRegion
		' 
		Me.rbRectRegion.AutoSize = True
		Me.rbRectRegion.Location = New System.Drawing.Point(9, 19)
		Me.rbRectRegion.Name = "rbRectRegion"
		Me.rbRectRegion.Size = New System.Drawing.Size(115, 17)
		Me.rbRectRegion.TabIndex = 0
		Me.rbRectRegion.Text = "Rectangular region"
		Me.rbRectRegion.UseVisualStyleBackColor = True
		AddHandler Me.rbRectRegion.CheckedChanged, New System.EventHandler(AddressOf Me.rbRectRegion_CheckedChanged)
		' 
		' btnStopRecording
		' 
		Me.btnStopRecording.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnStopRecording.Enabled = False
		Me.btnStopRecording.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.btnStopRecording.Location = New System.Drawing.Point(243, 3)
		Me.btnStopRecording.Name = "btnStopRecording"
		Me.btnStopRecording.Size = New System.Drawing.Size(114, 70)
		Me.btnStopRecording.TabIndex = 2
		Me.btnStopRecording.Text = "Stop Recording"
		Me.btnStopRecording.UseVisualStyleBackColor = True
		AddHandler Me.btnStopRecording.Click, New System.EventHandler(AddressOf Me.btnStopRecording_Click)
		' 
		' btnStartRecording
		' 
		Me.btnStartRecording.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnStartRecording.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnStartRecording.Location = New System.Drawing.Point(0, 3)
		Me.btnStartRecording.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
		Me.btnStartRecording.Name = "btnStartRecording"
		Me.btnStartRecording.Size = New System.Drawing.Size(117, 70)
		Me.btnStartRecording.TabIndex = 0
		Me.btnStartRecording.Text = "Start Recording"
		Me.btnStartRecording.UseVisualStyleBackColor = True
		AddHandler Me.btnStartRecording.Click, New System.EventHandler(AddressOf Me.btnStartRecording_Click)
		' 
		' groupBox4
		' 
		Me.groupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox4.Controls.Add(Me.label18)
		Me.groupBox4.Controls.Add(Me.nudMouseHotSpot)
		Me.groupBox4.Controls.Add(Me.cbCaptureLayeredWindows)
		Me.groupBox4.Controls.Add(Me.linkViewLog)
		Me.groupBox4.Controls.Add(Me.cbLog)
		Me.groupBox4.Controls.Add(Me.cmbFPS)
		Me.groupBox4.Controls.Add(Me.label4)
		Me.groupBox4.Location = New System.Drawing.Point(12, 350)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(541, 99)
		Me.groupBox4.TabIndex = 3
		Me.groupBox4.TabStop = False
		Me.groupBox4.Text = "Misc"
		' 
		' label18
		' 
		Me.label18.AutoSize = True
		Me.label18.Location = New System.Drawing.Point(72, 48)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(111, 13)
		Me.label18.TabIndex = 6
		Me.label18.Text = "Mouse hot spot radius"
		' 
		' nudMouseHotSpot
		' 
		Me.nudMouseHotSpot.Location = New System.Drawing.Point(6, 46)
		Me.nudMouseHotSpot.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudMouseHotSpot.Name = "nudMouseHotSpot"
		Me.nudMouseHotSpot.Size = New System.Drawing.Size(60, 20)
		Me.nudMouseHotSpot.TabIndex = 1
		Me.nudMouseHotSpot.Value = New Decimal(New Integer() {1, 0, 0, 0})
		' 
		' cbCaptureLayeredWindows
		' 
		Me.cbCaptureLayeredWindows.AutoSize = True
		Me.cbCaptureLayeredWindows.Location = New System.Drawing.Point(6, 72)
		Me.cbCaptureLayeredWindows.Name = "cbCaptureLayeredWindows"
		Me.cbCaptureLayeredWindows.Size = New System.Drawing.Size(499, 17)
		Me.cbCaptureLayeredWindows.TabIndex = 2
		Me.cbCaptureLayeredWindows.Text = "Capture Layered Windows (transparent windows and controls and WPF based applicati" & "on windows) "
		Me.cbCaptureLayeredWindows.UseVisualStyleBackColor = True
		' 
		' linkViewLog
		' 
		Me.linkViewLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.linkViewLog.AutoSize = True
		Me.linkViewLog.Location = New System.Drawing.Point(488, 22)
		Me.linkViewLog.Name = "linkViewLog"
		Me.linkViewLog.Size = New System.Drawing.Size(47, 13)
		Me.linkViewLog.TabIndex = 4
		Me.linkViewLog.TabStop = True
		Me.linkViewLog.Text = "View log"
		AddHandler Me.linkViewLog.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.linkViewLog_LinkClicked)
		' 
		' cbLog
		' 
		Me.cbLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbLog.AutoSize = True
		Me.cbLog.Location = New System.Drawing.Point(414, 21)
		Me.cbLog.Name = "cbLog"
		Me.cbLog.Size = New System.Drawing.Size(68, 17)
		Me.cbLog.TabIndex = 3
		Me.cbLog.Text = "Write log"
		Me.cbLog.UseVisualStyleBackColor = True
		' 
		' cmbFPS
		' 
		Me.cmbFPS.FormattingEnabled = True
		Me.cmbFPS.Location = New System.Drawing.Point(6, 19)
		Me.cmbFPS.Name = "cmbFPS"
		Me.cmbFPS.Size = New System.Drawing.Size(60, 21)
		Me.cmbFPS.TabIndex = 0
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(72, 22)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(27, 13)
		Me.label4.TabIndex = 3
		Me.label4.Text = "FPS"
		' 
		' groupBox5
		' 
		Me.groupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox5.Controls.Add(Me.label14)
		Me.groupBox5.Controls.Add(Me.cmbWebCameras)
		Me.groupBox5.Controls.Add(Me.tbWebCameraHeight)
		Me.groupBox5.Controls.Add(Me.label13)
		Me.groupBox5.Controls.Add(Me.label15)
		Me.groupBox5.Controls.Add(Me.cbShowWebCamOverlay)
		Me.groupBox5.Controls.Add(Me.tbWebCameraWidth)
		Me.groupBox5.Controls.Add(Me.tbWebCameraY)
		Me.groupBox5.Controls.Add(Me.label16)
		Me.groupBox5.Controls.Add(Me.tbWebCameraX)
		Me.groupBox5.Controls.Add(Me.label17)
		Me.groupBox5.Location = New System.Drawing.Point(12, 119)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(541, 76)
		Me.groupBox5.TabIndex = 1
		Me.groupBox5.TabStop = False
		Me.groupBox5.Text = "Web Camera"
		' 
		' label14
		' 
		Me.label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label14.AutoSize = True
		Me.label14.Location = New System.Drawing.Point(443, 48)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(38, 13)
		Me.label14.TabIndex = 18
		Me.label14.Text = "Height"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' cmbWebCameras
		' 
		Me.cmbWebCameras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbWebCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbWebCameras.FormattingEnabled = True
		Me.cmbWebCameras.Location = New System.Drawing.Point(53, 42)
		Me.cmbWebCameras.Name = "cmbWebCameras"
		Me.cmbWebCameras.Size = New System.Drawing.Size(278, 21)
		Me.cmbWebCameras.TabIndex = 1
		' 
		' tbWebCameraHeight
		' 
		Me.tbWebCameraHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbWebCameraHeight.Location = New System.Drawing.Point(487, 45)
		Me.tbWebCameraHeight.Name = "tbWebCameraHeight"
		Me.tbWebCameraHeight.Size = New System.Drawing.Size(48, 20)
		Me.tbWebCameraHeight.TabIndex = 5
		Me.tbWebCameraHeight.Text = "120"
		' 
		' label13
		' 
		Me.label13.AutoSize = True
		Me.label13.Location = New System.Drawing.Point(6, 45)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(41, 13)
		Me.label13.TabIndex = 5
		Me.label13.Text = "Device"
		' 
		' label15
		' 
		Me.label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label15.AutoSize = True
		Me.label15.Location = New System.Drawing.Point(347, 48)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(35, 13)
		Me.label15.TabIndex = 17
		Me.label15.Text = "Width"
		Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' cbShowWebCamOverlay
		' 
		Me.cbShowWebCamOverlay.AutoSize = True
		Me.cbShowWebCamOverlay.Location = New System.Drawing.Point(9, 19)
		Me.cbShowWebCamOverlay.Name = "cbShowWebCamOverlay"
		Me.cbShowWebCamOverlay.Size = New System.Drawing.Size(200, 17)
		Me.cbShowWebCamOverlay.TabIndex = 0
		Me.cbShowWebCamOverlay.Text = "Show video stream from web camera"
		Me.cbShowWebCamOverlay.UseVisualStyleBackColor = True
		' 
		' tbWebCameraWidth
		' 
		Me.tbWebCameraWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbWebCameraWidth.Location = New System.Drawing.Point(388, 45)
		Me.tbWebCameraWidth.Name = "tbWebCameraWidth"
		Me.tbWebCameraWidth.Size = New System.Drawing.Size(48, 20)
		Me.tbWebCameraWidth.TabIndex = 3
		Me.tbWebCameraWidth.Text = "160"
		' 
		' tbWebCameraY
		' 
		Me.tbWebCameraY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbWebCameraY.Location = New System.Drawing.Point(487, 19)
		Me.tbWebCameraY.Name = "tbWebCameraY"
		Me.tbWebCameraY.Size = New System.Drawing.Size(48, 20)
		Me.tbWebCameraY.TabIndex = 4
		Me.tbWebCameraY.Text = "10"
		' 
		' label16
		' 
		Me.label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label16.AutoSize = True
		Me.label16.Location = New System.Drawing.Point(467, 22)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(14, 13)
		Me.label16.TabIndex = 16
		Me.label16.Text = "Y"
		Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' tbWebCameraX
		' 
		Me.tbWebCameraX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbWebCameraX.Location = New System.Drawing.Point(388, 19)
		Me.tbWebCameraX.Name = "tbWebCameraX"
		Me.tbWebCameraX.Size = New System.Drawing.Size(48, 20)
		Me.tbWebCameraX.TabIndex = 2
		Me.tbWebCameraX.Text = "10"
		' 
		' label17
		' 
		Me.label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label17.AutoSize = True
		Me.label17.Location = New System.Drawing.Point(368, 22)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(14, 13)
		Me.label17.TabIndex = 13
		Me.label17.Text = "X"
		Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.tableLayoutPanel1.ColumnCount = 4
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.tableLayoutPanel1.Controls.Add(Me.btnPauseRecording, 1, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.btnStopRecording, 2, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.btnStartRecording, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.label19, 3, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 553)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(541, 76)
		Me.tableLayoutPanel1.TabIndex = 5
		' 
		' btnPauseRecording
		' 
		Me.btnPauseRecording.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnPauseRecording.Enabled = False
		Me.btnPauseRecording.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnPauseRecording.Location = New System.Drawing.Point(123, 3)
		Me.btnPauseRecording.Name = "btnPauseRecording"
		Me.btnPauseRecording.Size = New System.Drawing.Size(114, 70)
		Me.btnPauseRecording.TabIndex = 1
		Me.btnPauseRecording.Text = "Pause Recording" & vbCr & vbLf
		Me.btnPauseRecording.UseVisualStyleBackColor = True
		AddHandler Me.btnPauseRecording.Click, New System.EventHandler(AddressOf Me.btnPauseRecording_Click)
		' 
		' label19
		' 
		Me.label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label19.BackColor = System.Drawing.SystemColors.Info
		Me.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.label19.Location = New System.Drawing.Point(363, 3)
		Me.label19.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(178, 70)
		Me.label19.TabIndex = 3
		Me.label19.Text = "Full source code of this sample is available in Start | Bytescout Screen Capturin" & "g SDK | Advanced Examples | Audio and video settings"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(565, 641)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.groupBox5)
		Me.Controls.Add(Me.groupBox4)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox3)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Screen Capturing"
		Me.groupBox3.ResumeLayout(False)
		Me.groupBox3.PerformLayout()
		Me.groupBox2.ResumeLayout(False)
		Me.tabControl1.ResumeLayout(False)
		Me.tabPageWmv.ResumeLayout(False)
		Me.tabPageWmv.PerformLayout()
		Me.tabPageAvi.ResumeLayout(False)
		Me.tabPageAvi.PerformLayout()
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.groupBox4.ResumeLayout(False)
		Me.groupBox4.PerformLayout()
		DirectCast(Me.nudMouseHotSpot, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox5.ResumeLayout(False)
		Me.groupBox5.PerformLayout()
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private groupBox3 As System.Windows.Forms.GroupBox
	Private cmbAudioLines As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
    Private WithEvents cbEnableAudio As System.Windows.Forms.CheckBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents linkViewLog As System.Windows.Forms.LinkLabel
	Private cbLog As System.Windows.Forms.CheckBox
	Private cmbFPS As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
    Private WithEvents rbFullscreen As System.Windows.Forms.RadioButton
    Private WithEvents rbRegionAroundMouse As System.Windows.Forms.RadioButton
    Private WithEvents rbRectRegion As System.Windows.Forms.RadioButton
	Private tbY As System.Windows.Forms.TextBox
	Private tbX As System.Windows.Forms.TextBox
	Private label8 As System.Windows.Forms.Label
	Private tbHeight As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private tbWidth As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private btnStopRecording As System.Windows.Forms.Button
	Private btnStartRecording As System.Windows.Forms.Button
    Private WithEvents cmbAudioDevices As System.Windows.Forms.ComboBox
	Private label9 As System.Windows.Forms.Label
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPageWmv As System.Windows.Forms.TabPage
	Private cmbWmvAudioFormats As System.Windows.Forms.ComboBox
	Private label12 As System.Windows.Forms.Label
    Private WithEvents cmbWmvAudioCodecs As System.Windows.Forms.ComboBox
	Private label10 As System.Windows.Forms.Label
	Private cmbWmvVideoCodecs As System.Windows.Forms.ComboBox
	Private label11 As System.Windows.Forms.Label
	Private tabPageAvi As System.Windows.Forms.TabPage
	Private cmbAviAudioCodecs As System.Windows.Forms.ComboBox
	Private btnVideoCodecProps As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private cmbAviVideoCodecs As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private cmbWebCameras As System.Windows.Forms.ComboBox
	Private label13 As System.Windows.Forms.Label
	Private cbShowWebCamOverlay As System.Windows.Forms.CheckBox
	Private label14 As System.Windows.Forms.Label
	Private tbWebCameraHeight As System.Windows.Forms.TextBox
	Private label15 As System.Windows.Forms.Label
	Private tbWebCameraWidth As System.Windows.Forms.TextBox
	Private tbWebCameraY As System.Windows.Forms.TextBox
	Private label16 As System.Windows.Forms.Label
	Private tbWebCameraX As System.Windows.Forms.TextBox
	Private label17 As System.Windows.Forms.Label
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private btnPauseRecording As System.Windows.Forms.Button
	Private cbCaptureLayeredWindows As System.Windows.Forms.CheckBox
	Private label18 As System.Windows.Forms.Label
	Private nudMouseHotSpot As System.Windows.Forms.NumericUpDown
	Private label19 As System.Windows.Forms.Label
End Class

