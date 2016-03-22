'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports Bytescout.Spreadsheet

Public Partial Class _Default
	Inherits System.Web.UI.Page

    Private document As Spreadsheet = Nothing

	Protected Sub Page_Load(sender As Object, e As EventArgs)

        Dim inputXlsFile As String = Server.MapPath("example.xls")

		' Open spreadsheet
		document = New Spreadsheet(inputXlsFile)

		Label1.Text = """Example.xls"" loaded"

		For i As Integer = 0 To document.Worksheets.Count - 1
			DropDownList1.Items.Add(document.Worksheets(i).Name)
        Next

	End Sub

    Protected Sub ButtonGo_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim sheet As String = DropDownList1.SelectedItem.Text

        If Not String.IsNullOrEmpty(sheet) Then
            ' clear HTTP output
            Response.Clear()
            ' set the content type to HTML
            Response.ContentType = "text/HTML"
            ' save selected worksheet to output stream as HTML
            document.Worksheets(sheet).SaveAsHTML(Response.OutputStream)
            Response.End()
        End If

    End Sub
End Class
