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

