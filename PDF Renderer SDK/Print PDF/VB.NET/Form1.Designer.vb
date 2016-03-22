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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.buttonPageSetup = New System.Windows.Forms.Button()
		Me.buttonPrintPreview = New System.Windows.Forms.Button()
		Me.buttonPrint = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' printDocument1
		' 
		AddHandler Me.printDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf Me.printDocument1_PrintPage)
		' 
		' printPreviewDialog1
		' 
		Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.printPreviewDialog1.Document = Me.printDocument1
		Me.printPreviewDialog1.Enabled = True
		Me.printPreviewDialog1.Icon = DirectCast(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.printPreviewDialog1.Name = "printPreviewDialog1"
		Me.printPreviewDialog1.UseAntiAlias = True
		Me.printPreviewDialog1.Visible = False
		' 
		' pageSetupDialog1
		' 
		Me.pageSetupDialog1.Document = Me.printDocument1
		' 
		' printDialog1
		' 
		Me.printDialog1.Document = Me.printDocument1
		Me.printDialog1.UseEXDialog = True
		' 
		' buttonPageSetup
		' 
		Me.buttonPageSetup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPageSetup.Location = New System.Drawing.Point(12, 12)
		Me.buttonPageSetup.Name = "buttonPageSetup"
		Me.buttonPageSetup.Size = New System.Drawing.Size(253, 41)
		Me.buttonPageSetup.TabIndex = 0
		Me.buttonPageSetup.Text = "Page Setup"
		Me.buttonPageSetup.UseVisualStyleBackColor = True
		AddHandler Me.buttonPageSetup.Click, New System.EventHandler(AddressOf Me.buttonPageSetup_Click)
		' 
		' buttonPrintPreview
		' 
		Me.buttonPrintPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPrintPreview.Location = New System.Drawing.Point(12, 59)
		Me.buttonPrintPreview.Name = "buttonPrintPreview"
		Me.buttonPrintPreview.Size = New System.Drawing.Size(253, 41)
		Me.buttonPrintPreview.TabIndex = 1
		Me.buttonPrintPreview.Text = "Print Preview"
		Me.buttonPrintPreview.UseVisualStyleBackColor = True
		AddHandler Me.buttonPrintPreview.Click, New System.EventHandler(AddressOf Me.buttonPrintPreview_Click)
		' 
		' buttonPrint
		' 
		Me.buttonPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonPrint.Location = New System.Drawing.Point(12, 106)
		Me.buttonPrint.Name = "buttonPrint"
		Me.buttonPrint.Size = New System.Drawing.Size(253, 41)
		Me.buttonPrint.TabIndex = 2
		Me.buttonPrint.Text = "Print"
		Me.buttonPrint.UseVisualStyleBackColor = True
		AddHandler Me.buttonPrint.Click, New System.EventHandler(AddressOf Me.buttonPrint_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(277, 161)
		Me.Controls.Add(Me.buttonPrint)
		Me.Controls.Add(Me.buttonPrintPreview)
		Me.Controls.Add(Me.buttonPageSetup)
		Me.Name = "Form1"
		Me.Text = "Print PDF"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Private pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private buttonPageSetup As System.Windows.Forms.Button
	Private buttonPrintPreview As System.Windows.Forms.Button
	Private buttonPrint As System.Windows.Forms.Button
End Class

