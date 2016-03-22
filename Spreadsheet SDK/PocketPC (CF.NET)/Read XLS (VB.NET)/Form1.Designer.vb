Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing
	Private mainMenu1 As System.Windows.Forms.MainMenu

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
		Me.mainMenu1 = New System.Windows.Forms.MainMenu()
		Me.SuspendLayout()
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(96F, 96F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.AutoScroll = True
		Me.ClientSize = New System.Drawing.Size(240, 268)
		Me.KeyPreview = True
		Me.Menu = Me.mainMenu1
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub

	#End Region
End Class

