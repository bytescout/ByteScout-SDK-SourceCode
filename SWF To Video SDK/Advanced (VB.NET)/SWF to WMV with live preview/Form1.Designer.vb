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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.label1 = New System.Windows.Forms.Label
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonConvert
        '
        Me.buttonConvert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonConvert.Location = New System.Drawing.Point(18, 227)
        Me.buttonConvert.Name = "buttonConvert"
        Me.buttonConvert.Size = New System.Drawing.Size(254, 23)
        Me.buttonConvert.TabIndex = 0
        Me.buttonConvert.Text = "Convert test.swf with conversion preview"
        Me.buttonConvert.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.Location = New System.Drawing.Point(18, 31)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(254, 180)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(122, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Conversion preview:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.buttonConvert)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

    Private WithEvents buttonConvert As System.Windows.Forms.Button
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label1 As System.Windows.Forms.Label
End Class

