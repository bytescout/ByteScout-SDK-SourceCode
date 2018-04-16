'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
