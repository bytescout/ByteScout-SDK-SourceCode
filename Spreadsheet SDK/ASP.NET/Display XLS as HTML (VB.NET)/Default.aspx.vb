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



Imports Bytescout.Spreadsheet

Public Partial Class _Default
	Inherits System.Web.UI.Page

	Private _document As Spreadsheet = Nothing

	Protected Sub Page_Load(sender As Object, e As EventArgs)

		Dim inputXlsFile As String = Server.MapPath("example.xls")

		' Open spreadsheet
		_document = New Spreadsheet()
		_document.LoadFromFile(inputXlsFile)

		Label1.Text = """Example.xls"" loaded"

		For i As Integer = 0 To _document.Worksheets.Count - 1
			DropDownList1.Items.Add(_document.Worksheets(i).Name)
		Next

	End Sub

	Protected Sub ButtonGo_Click(ByVal sender As Object, ByVal e As EventArgs)

		Dim sheet As String = DropDownList1.SelectedItem.Text

		If Not String.IsNullOrEmpty(sheet) Then

			' Clear HTTP output
			Response.Clear()
			' Set the content type to HTML
			Response.ContentType = "text/HTML"
			' Save selected worksheet to output stream as HTML
			_document.Worksheets(sheet).SaveAsHTML(Response.OutputStream)

			Response.End()

		End If

	End Sub
End Class
