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

' add a cell 
Set cell = worksheet.Cell(1, 1)
cell.Value = "Testing, Testing, Testing, Testing..."

' Save spreadsheet as PDF file:

' Save PDF with automatic page size...
document.SaveAsPDF "autosized.pdf"
' ... or save PDF with fixed page size
document.SaveAsPDF_2 "fixedsize.pdf", False ' the second parameter disables autosizing 

' close Spreadsheet
Set document = Nothing

