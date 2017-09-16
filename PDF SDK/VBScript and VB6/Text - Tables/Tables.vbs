'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' This example demonstrates how to create tables.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set lightGrayColor = comHelpers.CreateColorGray(200)
Set whiteColor = comHelpers.CreateColorGray(255)
Set lightBlueColor = comHelpers.CreateColorRGB(200, 200, 250)
Set lightRedColor = comHelpers.CreateColorRGB(255, 200, 200)

' Create a table and set default background color
Set table = comHelpers.CreateTable()
table.BackgroundColor = lightGrayColor

' Add row headers column and set its color
table.Columns.Add(comHelpers.CreateTableColumn("RowHeaders", ""))
table.Columns.Item(0).BackgroundColor = lightGrayColor

' Add columns A, B, C, ...
For c = 0 To 9
    columnName = Chr(65 + c)
    table.Columns.Add(comHelpers.CreateTableColumn(columnName, columnName))
Next

' Add rows
For r = 0 To 9
    ' Create new row and set its background color
    Set row = table.NewRow()
    row.BackgroundColor = whiteColor

    ' Set row header text
    row("RowHeaders").Text = CStr(r + 1)

    ' Set cell text
    For c = 0 To 9
        columnName = Chr(65 + c)
        row(columnName).Text = columnName + CStr(r + 1)
    Next

    ' Add the row to the table
    table.Rows.Add(row)
Next

' Decorate the table
table.Rows.Item(1)("B").BackgroundColor = lightRedColor
table.Columns.Item(2).BackgroundColor = lightBlueColor
table.Rows.Item(1).BackgroundColor = lightBlueColor
table.Rows.Item(1)("RowHeaders").BackgroundColor = lightBlueColor

' Draw the table on canvas
page1.Canvas.DrawTable (table), 20, 20

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
