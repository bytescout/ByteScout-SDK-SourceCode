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
		Me.lblStub = New System.Windows.Forms.Label()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.filesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiVisitWebsite = New System.Windows.Forms.ToolStripMenuItem()
		Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStrip = New System.Windows.Forms.ToolStrip()
		Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsbPromo = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsbVisitWebsite = New System.Windows.Forms.ToolStripButton()
		Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.menuStrip1.SuspendLayout()
		Me.toolStrip.SuspendLayout()
		Me.SuspendLayout()
		' 
		' lblStub
		' 
		Me.lblStub.BackColor = System.Drawing.SystemColors.Window
		Me.lblStub.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lblStub.Font = New System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Italic)
		Me.lblStub.ForeColor = System.Drawing.SystemColors.AppWorkspace
		Me.lblStub.Location = New System.Drawing.Point(0, 49)
		Me.lblStub.Name = "lblStub"
		Me.lblStub.Size = New System.Drawing.Size(837, 508)
		Me.lblStub.TabIndex = 5
		Me.lblStub.Text = "Click here to open spreadsheet files: " & vbCr & vbLf & vbCr & vbLf & "Excel 2003/2007 (*.xls, *.xlsx) " & vbCr & vbLf & "Open " & "Office Calc (*.ods)" & vbCr & vbLf & "CSV Comma Separated Values (*.csv)" & vbCr & vbLf & "TXT tab-delimited value" & "s (*.txt)"
		Me.lblStub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.lblStub.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filesToolStripMenuItem, Me.helpToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
		Me.menuStrip1.Size = New System.Drawing.Size(837, 24)
		Me.menuStrip1.TabIndex = 6
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' filesToolStripMenuItem
		' 
		Me.filesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOpen, Me.tsmiPrint, Me.tsmiPrintPreview, Me.tsmiExit})
		Me.filesToolStripMenuItem.Name = "filesToolStripMenuItem"
		Me.filesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
		Me.filesToolStripMenuItem.Text = "Files"
		' 
		' tsmiOpen
		' 
		Me.tsmiOpen.Name = "tsmiOpen"
		Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsmiOpen.Size = New System.Drawing.Size(166, 22)
		Me.tsmiOpen.Text = "Open"
		AddHandler Me.tsmiOpen.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' tsmiPrint
		' 
		Me.tsmiPrint.Enabled = False
		Me.tsmiPrint.Name = "tsmiPrint"
		Me.tsmiPrint.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPrint.Text = "Print..."
		Me.tsmiPrint.Visible = False
		' 
		' tsmiPrintPreview
		' 
		Me.tsmiPrintPreview.Enabled = False
		Me.tsmiPrintPreview.Name = "tsmiPrintPreview"
		Me.tsmiPrintPreview.Size = New System.Drawing.Size(166, 22)
		Me.tsmiPrintPreview.Text = "Print Preview..."
		Me.tsmiPrintPreview.Visible = False
		' 
		' tsmiExit
		' 
		Me.tsmiExit.Name = "tsmiExit"
		Me.tsmiExit.Size = New System.Drawing.Size(166, 22)
		Me.tsmiExit.Text = "Exit"
		AddHandler Me.tsmiExit.Click, New System.EventHandler(AddressOf Me.tsmiExit_Click)
		' 
		' helpToolStripMenuItem
		' 
		Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiVisitWebsite, Me.tsmiAbout})
		Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
		Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.helpToolStripMenuItem.Text = "Help"
		' 
		' tsmiVisitWebsite
		' 
		Me.tsmiVisitWebsite.Name = "tsmiVisitWebsite"
		Me.tsmiVisitWebsite.Size = New System.Drawing.Size(152, 22)
		Me.tsmiVisitWebsite.Text = "Visit Website"
		AddHandler Me.tsmiVisitWebsite.Click, New System.EventHandler(AddressOf Me.tsmiVisitWebsite_Click)
		' 
		' tsmiAbout
		' 
		Me.tsmiAbout.Name = "tsmiAbout"
		Me.tsmiAbout.Size = New System.Drawing.Size(152, 22)
		Me.tsmiAbout.Text = "About"
		AddHandler Me.tsmiAbout.Click, New System.EventHandler(AddressOf Me.tsmiAbout_Click)
		' 
		' toolStrip
		' 
		Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.toolStripSeparator1, Me.tsbPromo, Me.toolStripSeparator2, Me.tsbVisitWebsite})
		Me.toolStrip.Location = New System.Drawing.Point(0, 24)
		Me.toolStrip.Name = "toolStrip"
		Me.toolStrip.Size = New System.Drawing.Size(837, 25)
		Me.toolStrip.TabIndex = 7
		Me.toolStrip.Text = "toolStrip1"
		' 
		' tsbOpen
		' 
		Me.tsbOpen.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Black
		Me.tsbOpen.Name = "tsbOpen"
		Me.tsbOpen.Size = New System.Drawing.Size(71, 22)
		Me.tsbOpen.Text = "Open File..."
		AddHandler Me.tsbOpen.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbPromo
		' 
		Me.tsbPromo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.tsbPromo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbPromo.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbPromo.Name = "tsbPromo"
		Me.tsbPromo.Size = New System.Drawing.Size(320, 22)
		Me.tsbPromo.Text = "Developers: Check Bytescout Spreadsheet SDK for .NET"
		AddHandler Me.tsbPromo.Click, New System.EventHandler(AddressOf Me.tsbPromo_Click)
		' 
		' toolStripSeparator2
		' 
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbVisitWebsite
		' 
		Me.tsbVisitWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.tsbVisitWebsite.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
		Me.tsbVisitWebsite.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbVisitWebsite.Name = "tsbVisitWebsite"
		Me.tsbVisitWebsite.Size = New System.Drawing.Size(84, 22)
		Me.tsbVisitWebsite.Text = "Visit Website"
		AddHandler Me.tsbVisitWebsite.Click, New System.EventHandler(AddressOf Me.tsmiVisitWebsite_Click)
		' 
		' openFileDialog
		' 
		Me.openFileDialog.Filter = resources.GetString("openFileDialog.Filter")
		Me.openFileDialog.SupportMultiDottedExtensions = True
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(837, 557)
		Me.Controls.Add(Me.lblStub)
		Me.Controls.Add(Me.toolStrip)
		Me.Controls.Add(Me.menuStrip1)
		Me.Name = "Form1"
		Me.Text = "Spreadsheet Viewer"
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.toolStrip.ResumeLayout(False)
		Me.toolStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private lblStub As System.Windows.Forms.Label
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private filesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiOpen As System.Windows.Forms.ToolStripMenuItem
	Private tsmiPrint As System.Windows.Forms.ToolStripMenuItem
	Private tsmiPrintPreview As System.Windows.Forms.ToolStripMenuItem
	Private tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiVisitWebsite As System.Windows.Forms.ToolStripMenuItem
	Private tsmiAbout As System.Windows.Forms.ToolStripMenuItem
	Private toolStrip As System.Windows.Forms.ToolStrip
	Private tsbOpen As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private tsbPromo As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private tsbVisitWebsite As System.Windows.Forms.ToolStripButton
	Private openFileDialog As System.Windows.Forms.OpenFileDialog

End Class
