Partial Class VideoScanForm
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
        Me.lblFoundBarcodes = New System.Windows.Forms.Label
        Me.pictureVideoPreview = New System.Windows.Forms.PictureBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.textAreaBarcodes = New System.Windows.Forms.RichTextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cbCamera = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.cbBarCodeType = New System.Windows.Forms.ComboBox
        Me.lblScanning = New System.Windows.Forms.Label
        Me.btnTryPopup = New System.Windows.Forms.Button
        Me.tbCameraWidth = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbCameraHeight = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.pictureVideoPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFoundBarcodes
        '
        Me.lblFoundBarcodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFoundBarcodes.AutoSize = True
        Me.lblFoundBarcodes.Location = New System.Drawing.Point(12, 309)
        Me.lblFoundBarcodes.Name = "lblFoundBarcodes"
        Me.lblFoundBarcodes.Size = New System.Drawing.Size(129, 13)
        Me.lblFoundBarcodes.TabIndex = 5
        Me.lblFoundBarcodes.Text = "Found barcodes (0 found)"
        '
        'pictureVideoPreview
        '
        Me.pictureVideoPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureVideoPreview.BackColor = System.Drawing.Color.White
        Me.pictureVideoPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureVideoPreview.Location = New System.Drawing.Point(12, 119)
        Me.pictureVideoPreview.Name = "pictureVideoPreview"
        Me.pictureVideoPreview.Size = New System.Drawing.Size(434, 187)
        Me.pictureVideoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureVideoPreview.TabIndex = 8
        Me.pictureVideoPreview.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStop.Location = New System.Drawing.Point(76, 399)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(65, 26)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStart.Location = New System.Drawing.Point(12, 399)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(58, 26)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'textAreaBarcodes
        '
        Me.textAreaBarcodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textAreaBarcodes.Location = New System.Drawing.Point(12, 325)
        Me.textAreaBarcodes.Name = "textAreaBarcodes"
        Me.textAreaBarcodes.Size = New System.Drawing.Size(434, 68)
        Me.textAreaBarcodes.TabIndex = 2
        Me.textAreaBarcodes.Text = ""
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(113, 13)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Select Camera Device"
        '
        'cbCamera
        '
        Me.cbCamera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCamera.FormattingEnabled = True
        Me.cbCamera.Location = New System.Drawing.Point(163, 39)
        Me.cbCamera.Name = "cbCamera"
        Me.cbCamera.Size = New System.Drawing.Size(283, 21)
        Me.cbCamera.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(356, 399)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 26)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label3.Location = New System.Drawing.Point(12, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(132, 13)
        Me.label3.TabIndex = 23
        Me.label3.Text = "BarCode Type To Scan"
        '
        'cbBarCodeType
        '
        Me.cbBarCodeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBarCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBarCodeType.FormattingEnabled = True
        Me.cbBarCodeType.Location = New System.Drawing.Point(163, 12)
        Me.cbBarCodeType.Name = "cbBarCodeType"
        Me.cbBarCodeType.Size = New System.Drawing.Size(283, 21)
        Me.cbBarCodeType.TabIndex = 0
        '
        'lblScanning
        '
        Me.lblScanning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScanning.AutoSize = True
        Me.lblScanning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblScanning.Location = New System.Drawing.Point(374, 309)
        Me.lblScanning.Name = "lblScanning"
        Me.lblScanning.Size = New System.Drawing.Size(67, 13)
        Me.lblScanning.TabIndex = 24
        Me.lblScanning.Text = "Scanning..."
        '
        'btnTryPopup
        '
        Me.btnTryPopup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTryPopup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTryPopup.Location = New System.Drawing.Point(163, 399)
        Me.btnTryPopup.Name = "btnTryPopup"
        Me.btnTryPopup.Size = New System.Drawing.Size(170, 26)
        Me.btnTryPopup.TabIndex = 25
        Me.btnTryPopup.Text = "Scan As One Time Popup..."
        Me.btnTryPopup.UseVisualStyleBackColor = True
        '
        'tbCameraWidth
        '
        Me.tbCameraWidth.Location = New System.Drawing.Point(284, 75)
        Me.tbCameraWidth.Name = "tbCameraWidth"
        Me.tbCameraWidth.Size = New System.Drawing.Size(49, 20)
        Me.tbCameraWidth.TabIndex = 26
        Me.tbCameraWidth.Text = "640"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Camera image size (increase for more quality)"
        '
        'tbCameraHeight
        '
        Me.tbCameraHeight.Location = New System.Drawing.Point(392, 75)
        Me.tbCameraHeight.Name = "tbCameraHeight"
        Me.tbCameraHeight.Size = New System.Drawing.Size(49, 20)
        Me.tbCameraHeight.TabIndex = 28
        Me.tbCameraHeight.Text = "480"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(348, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "X"
        '
        'VideoScanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(458, 437)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCameraHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCameraWidth)
        Me.Controls.Add(Me.btnTryPopup)
        Me.Controls.Add(Me.lblScanning)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cbBarCodeType)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbCamera)
        Me.Controls.Add(Me.textAreaBarcodes)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pictureVideoPreview)
        Me.Controls.Add(Me.lblFoundBarcodes)
        Me.MaximizeBox = False
        Me.Name = "VideoScanForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Bar Code Scanner"
        CType(Me.pictureVideoPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private lblFoundBarcodes As System.Windows.Forms.Label
    Private pictureVideoPreview As System.Windows.Forms.PictureBox
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private textAreaBarcodes As System.Windows.Forms.RichTextBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents cbCamera As System.Windows.Forms.ComboBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private label3 As System.Windows.Forms.Label
    Private cbBarCodeType As System.Windows.Forms.ComboBox
    Private lblScanning As System.Windows.Forms.Label
    Private WithEvents btnTryPopup As System.Windows.Forms.Button
    Friend WithEvents tbCameraWidth As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCameraHeight As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class

