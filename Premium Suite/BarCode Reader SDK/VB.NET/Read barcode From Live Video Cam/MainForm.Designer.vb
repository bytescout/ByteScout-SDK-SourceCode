<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnUpdateCameraImageDimensions = New System.Windows.Forms.Button()
		Me.cbStopOnFirstBarcode = New System.Windows.Forms.CheckBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tbCameraHeight = New System.Windows.Forms.TextBox()
		Me.tbCameraWidth = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.lblScanning = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cmbBarcodeType = New System.Windows.Forms.ComboBox()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cmbCamera = New System.Windows.Forms.ComboBox()
		Me.rtbFoundBarcodes = New System.Windows.Forms.RichTextBox()
		Me.btnStop = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.pictureBoxPreview = New System.Windows.Forms.PictureBox()
		Me.lblFoundBarcodes = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.pictureBoxPreview,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnUpdateCameraImageDimensions
		'
		Me.btnUpdateCameraImageDimensions.Location = New System.Drawing.Point(265, 64)
		Me.btnUpdateCameraImageDimensions.Name = "btnUpdateCameraImageDimensions"
		Me.btnUpdateCameraImageDimensions.Size = New System.Drawing.Size(71, 24)
		Me.btnUpdateCameraImageDimensions.TabIndex = 4
		Me.btnUpdateCameraImageDimensions.Text = "Update"
		Me.btnUpdateCameraImageDimensions.UseVisualStyleBackColor = true
		'
		'cbStopOnFirstBarcode
		'
		Me.cbStopOnFirstBarcode.AutoSize = true
		Me.cbStopOnFirstBarcode.Location = New System.Drawing.Point(14, 94)
		Me.cbStopOnFirstBarcode.Name = "cbStopOnFirstBarcode"
		Me.cbStopOnFirstBarcode.Size = New System.Drawing.Size(154, 17)
		Me.cbStopOnFirstBarcode.TabIndex = 5
		Me.cbStopOnFirstBarcode.Text = "Stop on first barcode found"
		Me.cbStopOnFirstBarcode.UseVisualStyleBackColor = true
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(206, 69)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(12, 13)
		Me.label4.TabIndex = 46
		Me.label4.Text = "x"
		'
		'tbCameraHeight
		'
		Me.tbCameraHeight.Location = New System.Drawing.Point(224, 66)
		Me.tbCameraHeight.Name = "tbCameraHeight"
		Me.tbCameraHeight.Size = New System.Drawing.Size(35, 20)
		Me.tbCameraHeight.TabIndex = 3
		Me.tbCameraHeight.Text = "480"
		'
		'tbCameraWidth
		'
		Me.tbCameraWidth.Location = New System.Drawing.Point(165, 66)
		Me.tbCameraWidth.Name = "tbCameraWidth"
		Me.tbCameraWidth.Size = New System.Drawing.Size(35, 20)
		Me.tbCameraWidth.TabIndex = 2
		Me.tbCameraWidth.Text = "640"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(11, 69)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(132, 13)
		Me.label2.TabIndex = 45
		Me.label2.Text = "Camera Image Dimensions"
		'
		'lblScanning
		'
		Me.lblScanning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lblScanning.AutoSize = true
		Me.lblScanning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.lblScanning.Location = New System.Drawing.Point(582, 600)
		Me.lblScanning.Name = "lblScanning"
		Me.lblScanning.Size = New System.Drawing.Size(67, 13)
		Me.lblScanning.TabIndex = 44
		Me.lblScanning.Text = "Scanning..."
		Me.lblScanning.Visible = false
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.label3.Location = New System.Drawing.Point(11, 15)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(131, 13)
		Me.label3.TabIndex = 43
		Me.label3.Text = "Barcode Type To Scan"
		'
		'cmbBarcodeType
		'
		Me.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbBarcodeType.FormattingEnabled = true
		Me.cmbBarcodeType.Location = New System.Drawing.Point(165, 12)
		Me.cmbBarcodeType.Name = "cmbBarcodeType"
		Me.cmbBarcodeType.Size = New System.Drawing.Size(245, 21)
		Me.cmbBarcodeType.Sorted = true
		Me.cmbBarcodeType.TabIndex = 0
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnExit.Location = New System.Drawing.Point(564, 690)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(90, 26)
		Me.btnExit.TabIndex = 9
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(11, 42)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(80, 13)
		Me.label1.TabIndex = 42
		Me.label1.Text = "Camera Device"
		'
		'cmbCamera
		'
		Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCamera.FormattingEnabled = true
		Me.cmbCamera.Location = New System.Drawing.Point(165, 39)
		Me.cmbCamera.Name = "cmbCamera"
		Me.cmbCamera.Size = New System.Drawing.Size(245, 21)
		Me.cmbCamera.TabIndex = 1
		'
		'rtbFoundBarcodes
		'
		Me.rtbFoundBarcodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.rtbFoundBarcodes.Location = New System.Drawing.Point(14, 616)
		Me.rtbFoundBarcodes.Name = "rtbFoundBarcodes"
		Me.rtbFoundBarcodes.Size = New System.Drawing.Size(640, 68)
		Me.rtbFoundBarcodes.TabIndex = 6
		Me.rtbFoundBarcodes.Text = ""
		'
		'btnStop
		'
		Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnStop.Enabled = false
		Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnStop.Location = New System.Drawing.Point(100, 690)
		Me.btnStop.Name = "btnStop"
		Me.btnStop.Size = New System.Drawing.Size(80, 26)
		Me.btnStop.TabIndex = 8
		Me.btnStop.Text = "Stop"
		Me.btnStop.UseVisualStyleBackColor = true
		'
		'btnStart
		'
		Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.btnStart.Location = New System.Drawing.Point(14, 690)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(80, 26)
		Me.btnStart.TabIndex = 7
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = true
		'
		'pictureBoxPreview
		'
		Me.pictureBoxPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.pictureBoxPreview.BackColor = System.Drawing.Color.White
		Me.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pictureBoxPreview.Location = New System.Drawing.Point(14, 117)
		Me.pictureBoxPreview.Name = "pictureBoxPreview"
		Me.pictureBoxPreview.Size = New System.Drawing.Size(640, 480)
		Me.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.pictureBoxPreview.TabIndex = 40
		Me.pictureBoxPreview.TabStop = false
		'
		'lblFoundBarcodes
		'
		Me.lblFoundBarcodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.lblFoundBarcodes.AutoSize = true
		Me.lblFoundBarcodes.Location = New System.Drawing.Point(14, 600)
		Me.lblFoundBarcodes.Name = "lblFoundBarcodes"
		Me.lblFoundBarcodes.Size = New System.Drawing.Size(93, 13)
		Me.lblFoundBarcodes.TabIndex = 38
		Me.lblFoundBarcodes.Text = "Found 0 barcodes"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(416, 38)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(129, 23)
		Me.Button1.TabIndex = 47
		Me.Button1.Text = "Camera Properties"
		Me.Button1.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(664, 728)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnUpdateCameraImageDimensions)
		Me.Controls.Add(Me.cbStopOnFirstBarcode)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbCameraHeight)
		Me.Controls.Add(Me.tbCameraWidth)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.lblScanning)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.cmbBarcodeType)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.cmbCamera)
		Me.Controls.Add(Me.rtbFoundBarcodes)
		Me.Controls.Add(Me.btnStop)
		Me.Controls.Add(Me.btnStart)
		Me.Controls.Add(Me.pictureBoxPreview)
		Me.Controls.Add(Me.lblFoundBarcodes)
		Me.Name = "MainForm"
		Me.ShowIcon = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Barcode Scanner"
		CType(Me.pictureBoxPreview,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Private WithEvents btnUpdateCameraImageDimensions As Windows.Forms.Button
	Private WithEvents cbStopOnFirstBarcode As Windows.Forms.CheckBox
	Private WithEvents label4 As Windows.Forms.Label
	Private WithEvents tbCameraHeight As Windows.Forms.TextBox
	Private WithEvents tbCameraWidth As Windows.Forms.TextBox
	Private WithEvents label2 As Windows.Forms.Label
	Private WithEvents lblScanning As Windows.Forms.Label
	Private WithEvents label3 As Windows.Forms.Label
	Private WithEvents cmbBarcodeType As Windows.Forms.ComboBox
	Private WithEvents btnExit As Windows.Forms.Button
	Private WithEvents label1 As Windows.Forms.Label
	Private WithEvents cmbCamera As Windows.Forms.ComboBox
	Private WithEvents rtbFoundBarcodes As Windows.Forms.RichTextBox
	Private WithEvents btnStop As Windows.Forms.Button
	Private WithEvents btnStart As Windows.Forms.Button
	Private WithEvents pictureBoxPreview As Windows.Forms.PictureBox
	Private WithEvents lblFoundBarcodes As Windows.Forms.Label
	Friend WithEvents Button1 As Windows.Forms.Button
End Class
