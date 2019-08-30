'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' change width of the column #1
set column = worksheet.columns.Item(1)
column.Width = 200

' change height of row #1
set row = worksheet.rows.Item(1)
row.Height = 100

' Merge cells
Set range = worksheet.Range_2("A1:D5")
range.Merge()

' Write text
Set cell = worksheet.Cell_2("A2")
set leftCell = cell.MergedWithCell()

leftCell.ValueAsHTML = "<center><b>Bold text</b> and <i>Italic text</i></center>"

' set alignment 
' setting right alignment for the cell
leftcell.AlignmentHorizontal = 3 ' see (0) Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right


' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile("Output.xls")
Set fso = nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

