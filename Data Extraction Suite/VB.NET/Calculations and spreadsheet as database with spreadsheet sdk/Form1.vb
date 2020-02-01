'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.Diagnostics

Public Class Form1
    Dim _spreadsheet As Spreadsheet
    Private Sub LoadXLS()
        Dim worksheet As Worksheet
        _spreadsheet = New Spreadsheet()
        _spreadsheet.LoadFromFile("Database.xls")

        worksheet = _spreadsheet.WorkBook.Worksheets(0)
        Label1.Text = worksheet.Cell("A1").Value
        TextBox1.Text = worksheet.Cell("A2").Value

        Label2.Text = worksheet.Cell("B1").Value
        TextBox2.Text = worksheet.Cell("B2").Value

        Label3.Text = worksheet.Cell("C1").Value
        TextBox3.Text = worksheet.Cell("C2").Formula

        Label4.Text = "Calculated value of C2"
        worksheet.Cell("C2").Calculate()
        TextBox4.Text = worksheet.Cell("C2").Value
    End Sub

    Private Sub SaveXLS()
        Dim worksheet As Worksheet

        worksheet = _spreadsheet.WorkBook.Worksheets(0)

        worksheet.Cell("A2").Value = System.Convert.ToInt32(TextBox1.Text)
        worksheet.Cell("B2").Value = System.Convert.ToInt32(TextBox2.Text)
        worksheet.Cell("C2").Formula = TextBox3.Text

        Try
            System.IO.File.Delete("Database.xls")
        Catch ex As Exception
        End Try

        _spreadsheet.SaveAs("Database.xls")
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveXLS()

        _spreadsheet.Close()
    End Sub


    Private Sub ReCalculate()
        Dim worksheet As Worksheet

        worksheet = _spreadsheet.Workbook.Worksheets(0)

        worksheet.Cell("A2").Value = System.Convert.ToInt32(TextBox1.Text)
        worksheet.Cell("B2").Value = System.Convert.ToInt32(TextBox2.Text)
        worksheet.Cell("C2").Formula = TextBox3.Text
        worksheet.Cell("C2").Calculate()
        TextBox4.Text = worksheet.Cell("C2").Value
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReCalculate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadXLS()
    End Sub


    Private Sub TextBox_Recalculate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReCalculate()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' open in default spreadsheets viewer/editor
        SaveXLS()
        Try
            Process.Start("Database.xls")
        Catch
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadXLS()
        MessageBox.Show("Loaded from Database.xls")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveXLS()
        MessageBox.Show("Saved into Database.xls")
    End Sub
End Class
