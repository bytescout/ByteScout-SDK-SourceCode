'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Windows.Forms

Public Partial Class PasswordDialog
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Public ReadOnly Property Password() As String
		Get
			Return textBoxPassword.Text
		End Get
	End Property

	Private Sub btnOk_Click(sender As Object, e As EventArgs)
		'DialogResult = DialogResult.OK;
		'Close();
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub checkBoxHide_CheckedChanged(sender As Object, e As EventArgs)
		If checkBoxHide.Checked Then
			textBoxPassword.PasswordChar = "*"C
		Else
			textBoxPassword.PasswordChar = ControlChars.NullChar
		End If
	End Sub
End Class
