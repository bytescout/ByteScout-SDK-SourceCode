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
		Me.Menu = Me.mainMenu1
		Me.components = New System.ComponentModel.Container()
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
		Me.Text = "Form1"
		Me.AutoScroll = True
	End Sub

	#End Region
End Class

