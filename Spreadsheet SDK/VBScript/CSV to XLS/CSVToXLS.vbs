'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

document.LoadFromFile("input.csv")

' save document
document.SaveAs "Output.xls"

' save as xlsx
document.SaveAs "Output.xlsx"

' close Spreadsheet
Set document = Nothing

MsgBox "Done! See output.xls"

