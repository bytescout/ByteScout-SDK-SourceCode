Partial Class Service1
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.eventLog1 = New System.Diagnostics.EventLog()
		DirectCast(Me.eventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Service1
		' 
		Me.ServiceName = "Service1"
		DirectCast(Me.eventLog1, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private eventLog1 As System.Diagnostics.EventLog
End Class
