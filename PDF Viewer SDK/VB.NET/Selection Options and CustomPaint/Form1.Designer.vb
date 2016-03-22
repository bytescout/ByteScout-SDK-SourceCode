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
        Me.pdfViewerControl1 = New Bytescout.PDFViewer.PDFViewerControl()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.cbLockSelection = New System.Windows.Forms.CheckBox()
        Me.cbAllowResizeSelection = New System.Windows.Forms.CheckBox()
        Me.cbMultiSelectMode = New System.Windows.Forms.CheckBox()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pdfViewerControl1
        '
        Me.pdfViewerControl1.AllowResizeSelectionRectangles = True
        Me.pdfViewerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pdfViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pdfViewerControl1.Location = New System.Drawing.Point(12, 97)
        Me.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Selection
        Me.pdfViewerControl1.MultiSelectMode = True
        Me.pdfViewerControl1.Name = "pdfViewerControl1"
        Me.pdfViewerControl1.RegistrationKey = Nothing
        Me.pdfViewerControl1.RegistrationName = Nothing
        Me.pdfViewerControl1.Size = New System.Drawing.Size(1153, 568)
        Me.pdfViewerControl1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(1177, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(80, 22)
        Me.tsbOpen.Text = "&Open PDF"
        '
        'cbLockSelection
        '
        Me.cbLockSelection.AutoSize = True
        Me.cbLockSelection.Location = New System.Drawing.Point(12, 74)
        Me.cbLockSelection.Name = "cbLockSelection"
        Me.cbLockSelection.Size = New System.Drawing.Size(95, 17)
        Me.cbLockSelection.TabIndex = 2
        Me.cbLockSelection.Text = "Lock selection"
        Me.cbLockSelection.UseVisualStyleBackColor = True
        '
        'cbAllowResizeSelection
        '
        Me.cbAllowResizeSelection.AutoSize = True
        Me.cbAllowResizeSelection.Checked = True
        Me.cbAllowResizeSelection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAllowResizeSelection.Location = New System.Drawing.Point(12, 51)
        Me.cbAllowResizeSelection.Name = "cbAllowResizeSelection"
        Me.cbAllowResizeSelection.Size = New System.Drawing.Size(178, 17)
        Me.cbAllowResizeSelection.TabIndex = 3
        Me.cbAllowResizeSelection.Text = "Allow resize selection rectangles"
        Me.cbAllowResizeSelection.UseVisualStyleBackColor = True
        '
        'cbMultiSelectMode
        '
        Me.cbMultiSelectMode.AutoSize = True
        Me.cbMultiSelectMode.Checked = True
        Me.cbMultiSelectMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMultiSelectMode.Location = New System.Drawing.Point(12, 28)
        Me.cbMultiSelectMode.Name = "cbMultiSelectMode"
        Me.cbMultiSelectMode.Size = New System.Drawing.Size(108, 17)
        Me.cbMultiSelectMode.TabIndex = 4
        Me.cbMultiSelectMode.Text = "Multi-select mode"
        Me.cbMultiSelectMode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 677)
        Me.Controls.Add(Me.cbMultiSelectMode)
        Me.Controls.Add(Me.cbAllowResizeSelection)
        Me.Controls.Add(Me.cbLockSelection)
        Me.Controls.Add(Me.pdfViewerControl1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

    Private WithEvents pdfViewerControl1 As Bytescout.PDFViewer.PDFViewerControl
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Private WithEvents cbLockSelection As System.Windows.Forms.CheckBox
    Private WithEvents cbAllowResizeSelection As System.Windows.Forms.CheckBox
    Private WithEvents cbMultiSelectMode As System.Windows.Forms.CheckBox
End Class

