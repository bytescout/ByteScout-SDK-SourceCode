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


Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to create tables.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add page
        Dim page = New Page(PaperFormat.A4)
        pdfDocument.Pages.Add(page)


        Dim lightGrayColor = New ColorGray(200)
        Dim whiteColor = New ColorGray(255)
        Dim lightBlueColor = New ColorRGB(200, 200, 250)
        Dim lightRedColor = New ColorRGB(255, 200, 200)

        ' Create a table and set default background color
        Dim table = New Table()
        table.BackgroundColor = lightGrayColor

        ' Add row headers column and set its color
        table.Columns.Add(New TableColumn("RowHeaders"))
        table.Columns(0).BackgroundColor = lightGrayColor

        ' Add columns A, B, C, ...
        For c As Integer = 0 To 9
            Dim columnName = Convert.ToChar(65 + c).ToString()
            table.Columns.Add(New TableColumn(columnName, columnName))
        Next

        ' Add rows
        For r As Integer = 0 To 9
            ' Create new row and set its background color
            Dim row = table.NewRow()
            row.BackgroundColor = whiteColor

            ' Set row header text
            row("RowHeaders").Text = (r + 1).ToString()

            ' Set cell text
            For c As Integer = 0 To 9
                Dim columnName As String = Convert.ToChar(65 + c).ToString()
                row(columnName).Text = columnName + (r + 1).ToString()
            Next

            ' Add the row to the table
            table.Rows.Add(row)
        Next

        ' Decorate the table
        table.Rows(1)("B").BackgroundColor = lightRedColor
        table.Columns(2).BackgroundColor = lightBlueColor
        table.Rows(1).BackgroundColor = lightBlueColor
        table.Rows(1)("RowHeaders").BackgroundColor = lightBlueColor

        ' Draw the table on canvas
        page.Canvas.DrawTable(table, 20, 20)

        
        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
        pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
