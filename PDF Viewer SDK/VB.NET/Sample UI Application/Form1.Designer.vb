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
        Me.pdfViewerControl1 = New Bytescout.PDFViewer.PDFViewerControl
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pdfViewerControl1
        '
        Me.pdfViewerControl1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfViewerControl1.Location = New System.Drawing.Point(0, 25)
        Me.pdfViewerControl1.MouseMode = Bytescout.PDFViewer.MouseMode.Hand
        Me.pdfViewerControl1.Name = "pdfViewerControl1"
        Me.pdfViewerControl1.ShowToolbar = True
        Me.pdfViewerControl1.Size = New System.Drawing.Size(842, 514)
        Me.pdfViewerControl1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(842, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.Image = Global.Sample_UI_Application.My.Resources.Resources.folder_page
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(80, 22)
        Me.tsbOpen.Text = "&Open PDF"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 539)
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

	Private pdfViewerControl1 As Bytescout.PDFViewer.PDFViewerControl
	Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
End Class

