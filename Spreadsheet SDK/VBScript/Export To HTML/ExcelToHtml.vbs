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

document.LoadFromFile("TestForHtmlExport.xls")

' Export whole document to set of HTML files
document.SaveAsHTML "Document.html"

' Export single worksheet
document.Worksheets.Item(0).SaveAsHTML "Worksheet1.html"

