Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
        Me.buttonConvert = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.progressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'buttonConvert
        '
        Me.buttonConvert.Location = New System.Drawing.Point(18, 57)
        Me.buttonConvert.Name = "buttonConvert"
        Me.buttonConvert.Size = New System.Drawing.Size(254, 33)
        Me.buttonConvert.TabIndex = 0
        Me.buttonConvert.Text = "Convert slides with conversion preview"
        Me.buttonConvert.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(126, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Conversion progress:"
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(18, 28)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(254, 23)
        Me.progressBar1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 102)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonConvert)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

    Private WithEvents buttonConvert As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private progressBar1 As System.Windows.Forms.ProgressBar
End Class

