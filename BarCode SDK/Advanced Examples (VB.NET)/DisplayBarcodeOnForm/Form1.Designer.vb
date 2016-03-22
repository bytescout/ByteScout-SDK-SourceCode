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
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' pictureBox1
		' 
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Location = New System.Drawing.Point(12, 36)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(270, 270)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = False
		' 
		' panel1
		' 
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Location = New System.Drawing.Point(314, 36)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(270, 270)
		Me.panel1.TabIndex = 1
		AddHandler Me.panel1.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.panel1_Paint)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(179, 13)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Show barcode in PictureBox control:"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(311, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(157, 13)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Draw barcode on Panel control:"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(599, 349)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.pictureBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
End Class

