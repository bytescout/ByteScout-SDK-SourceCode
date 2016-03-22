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
		Me.cmbCapturingType = New System.Windows.Forms.ComboBox()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' cmbCapturingType
		' 
		Me.cmbCapturingType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbCapturingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCapturingType.FormattingEnabled = True
		Me.cmbCapturingType.Items.AddRange(New Object() {"Area around the mouse pointer", "Full screen"})
		Me.cmbCapturingType.Location = New System.Drawing.Point(97, 12)
		Me.cmbCapturingType.Name = "cmbCapturingType"
		Me.cmbCapturingType.Size = New System.Drawing.Size(213, 21)
		Me.cmbCapturingType.TabIndex = 0
		' 
		' btnStart
		' 
		Me.btnStart.Location = New System.Drawing.Point(3, 3)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(143, 44)
		Me.btnStart.TabIndex = 1
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = True
		AddHandler Me.btnStart.Click, New System.EventHandler(AddressOf Me.btnStart_Click)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(79, 13)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Capturing Type"
		' 
		' btnStop
		' 
		Me.btnStop.Enabled = False
		Me.btnStop.Location = New System.Drawing.Point(152, 3)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(143, 44)
		Me.btnStop.TabIndex = 4
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = True
		AddHandler Me.btnStop.Click, New System.EventHandler(AddressOf Me.btnStop_Click)
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel1.ColumnCount = 2
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Controls.Add(Me.btnStart, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.btnStop, 1, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(12, 52)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 1
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(298, 57)
		Me.tableLayoutPanel1.TabIndex = 5
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(322, 121)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.cmbCapturingType)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Capture From Separate Thread"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private cmbCapturingType As System.Windows.Forms.ComboBox
	Private btnStart As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private btnStop As System.Windows.Forms.Button
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class

