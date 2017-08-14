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
		Me.buttonScreenshot = New System.Windows.Forms.Button()
		Me.buttonStop = New System.Windows.Forms.Button()
		Me.buttonStart = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'buttonScreenshot
		'
		Me.buttonScreenshot.Enabled = False
		Me.buttonScreenshot.Location = New System.Drawing.Point(108, 41)
		Me.buttonScreenshot.Name = "buttonScreenshot"
		Me.buttonScreenshot.Size = New System.Drawing.Size(100, 23)
		Me.buttonScreenshot.TabIndex = 5
		Me.buttonScreenshot.Text = "Take Screenshot"
		Me.buttonScreenshot.UseVisualStyleBackColor = True
		'
		'buttonStop
		'
		Me.buttonStop.Enabled = False
		Me.buttonStop.Location = New System.Drawing.Point(27, 58)
		Me.buttonStop.Name = "buttonStop"
		Me.buttonStop.Size = New System.Drawing.Size(75, 23)
		Me.buttonStop.TabIndex = 4
		Me.buttonStop.Text = "Stop"
		Me.buttonStop.UseVisualStyleBackColor = True
		'
		'buttonStart
		'
		Me.buttonStart.Location = New System.Drawing.Point(27, 29)
		Me.buttonStart.Name = "buttonStart"
		Me.buttonStart.Size = New System.Drawing.Size(75, 23)
		Me.buttonStart.TabIndex = 3
		Me.buttonStart.Text = "Start"
		Me.buttonStart.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(234, 111)
		Me.Controls.Add(Me.buttonScreenshot)
		Me.Controls.Add(Me.buttonStop)
		Me.Controls.Add(Me.buttonStart)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents buttonScreenshot As System.Windows.Forms.Button
	Private WithEvents buttonStop As System.Windows.Forms.Button
	Private WithEvents buttonStart As System.Windows.Forms.Button

End Class
