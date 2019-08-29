<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.buttonPrint = New System.Windows.Forms.Button()
		Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.SuspendLayout()
		'
		'buttonPrint
		'
		Me.buttonPrint.Location = New System.Drawing.Point(12, 12)
		Me.buttonPrint.Name = "buttonPrint"
		Me.buttonPrint.Size = New System.Drawing.Size(260, 57)
		Me.buttonPrint.TabIndex = 1
		Me.buttonPrint.Text = "Draw And Print Cards"
		Me.buttonPrint.UseVisualStyleBackColor = True
		'
		'PrintPreviewDialog1
		'
		Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.PrintPreviewDialog1.Document = Me.PrintDocument1
		Me.PrintPreviewDialog1.Enabled = True
		Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
		Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
		Me.PrintPreviewDialog1.Visible = False
		'
		'PrintDocument1
		'
		'
		'PrintDialog1
		'
		Me.PrintDialog1.Document = Me.PrintDocument1
		Me.PrintDialog1.UseEXDialog = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 149)
		Me.Controls.Add(Me.buttonPrint)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents buttonPrint As System.Windows.Forms.Button
	Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
	Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog

End Class
