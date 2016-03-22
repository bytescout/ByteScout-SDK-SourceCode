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
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.pictureBoxBarcode = New System.Windows.Forms.PictureBox()
		Me.textBoxFileName = New System.Windows.Forms.TextBox()
		Me.textBoxResults = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.checkBoxAll1D = New System.Windows.Forms.CheckBox()
		Me.checkBoxAll2D = New System.Windows.Forms.CheckBox()
		Me.buttonSearch = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		DirectCast(Me.pictureBoxBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(9, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(120, 13)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Image or PDF file name:"
		' 
		' buttonBrowse
		' 
		Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.Location = New System.Drawing.Point(792, 23)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(78, 23)
		Me.buttonBrowse.TabIndex = 0
		Me.buttonBrowse.Text = "Browse..."
		Me.buttonBrowse.UseVisualStyleBackColor = True
		AddHandler Me.buttonBrowse.Click, New System.EventHandler(AddressOf Me.buttonBrowse_Click)
		' 
		' pictureBoxBarcode
		' 
		Me.pictureBoxBarcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pictureBoxBarcode.Location = New System.Drawing.Point(0, 0)
		Me.pictureBoxBarcode.Name = "pictureBoxBarcode"
		Me.pictureBoxBarcode.Size = New System.Drawing.Size(138, 113)
		Me.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pictureBoxBarcode.TabIndex = 2
		Me.pictureBoxBarcode.TabStop = False
		' 
		' textBoxFileName
		' 
		Me.textBoxFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxFileName.Location = New System.Drawing.Point(12, 25)
		Me.textBoxFileName.Name = "textBoxFileName"
		Me.textBoxFileName.[ReadOnly] = True
		Me.textBoxFileName.Size = New System.Drawing.Size(774, 20)
		Me.textBoxFileName.TabIndex = 0
		' 
		' textBoxResults
		' 
		Me.textBoxResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxResults.Location = New System.Drawing.Point(12, 486)
		Me.textBoxResults.Multiline = True
		Me.textBoxResults.Name = "textBoxResults"
		Me.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBoxResults.Size = New System.Drawing.Size(858, 102)
		Me.textBoxResults.TabIndex = 4
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(12, 470)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(87, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Found barcodes:"
		' 
		' openFileDialog
		' 
		Me.openFileDialog.Filter = "Image and PDF files|*.bmp;*.gif;*.tif;*.tiff;*.png;*.jpg;*.jpeg;*.pdf|All files|*" & ".*"
		' 
		' checkBoxAll1D
		' 
		Me.checkBoxAll1D.AutoSize = True
		Me.checkBoxAll1D.Checked = True
		Me.checkBoxAll1D.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBoxAll1D.Location = New System.Drawing.Point(12, 51)
		Me.checkBoxAll1D.Name = "checkBoxAll1D"
		Me.checkBoxAll1D.Size = New System.Drawing.Size(359, 17)
		Me.checkBoxAll1D.TabIndex = 1
		Me.checkBoxAll1D.Text = "One-dimensional (linear) barcodes (Code39, Code128, GS1, EAN, etc.)"
		Me.checkBoxAll1D.UseVisualStyleBackColor = True
		' 
		' checkBoxAll2D
		' 
		Me.checkBoxAll2D.AutoSize = True
		Me.checkBoxAll2D.Checked = True
		Me.checkBoxAll2D.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBoxAll2D.Location = New System.Drawing.Point(12, 74)
		Me.checkBoxAll2D.Name = "checkBoxAll2D"
		Me.checkBoxAll2D.Size = New System.Drawing.Size(363, 17)
		Me.checkBoxAll2D.TabIndex = 2
		Me.checkBoxAll2D.Text = "Two-dimensional barcodes (Aztec, PDF417, QR Code, Datamatrix, etc.)"
		Me.checkBoxAll2D.UseVisualStyleBackColor = True
		' 
		' buttonSearch
		' 
		Me.buttonSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonSearch.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.buttonSearch.Location = New System.Drawing.Point(742, 51)
		Me.buttonSearch.Name = "buttonSearch"
		Me.buttonSearch.Size = New System.Drawing.Size(128, 40)
		Me.buttonSearch.TabIndex = 3
		Me.buttonSearch.Text = "Search Barcodes"
		Me.buttonSearch.UseVisualStyleBackColor = True
		AddHandler Me.buttonSearch.Click, New System.EventHandler(AddressOf Me.buttonSearchBarcodes_Click)
		' 
		' panel1
		' 
		Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panel1.AutoScroll = True
		Me.panel1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.pictureBoxBarcode)
		Me.panel1.Location = New System.Drawing.Point(12, 97)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(858, 370)
		Me.panel1.TabIndex = 9
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(882, 600)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.buttonSearch)
		Me.Controls.Add(Me.checkBoxAll2D)
		Me.Controls.Add(Me.checkBoxAll1D)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBoxResults)
		Me.Controls.Add(Me.textBoxFileName)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Barcode Reader"
		DirectCast(Me.pictureBoxBarcode, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private buttonBrowse As System.Windows.Forms.Button
	Private pictureBoxBarcode As System.Windows.Forms.PictureBox
	Private textBoxFileName As System.Windows.Forms.TextBox
	Private textBoxResults As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private openFileDialog As System.Windows.Forms.OpenFileDialog
	Private checkBoxAll1D As System.Windows.Forms.CheckBox
	Private checkBoxAll2D As System.Windows.Forms.CheckBox
	Private buttonSearch As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
End Class

