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


if Wscript.Arguments.Length < 2 Then
    WScript.Echo "Usage: PdfToXls.vbs ""input.pdf"" ""output.xlsx"""
    WScript.Quit
End If

' Create Bytescout.PDFExtractor.XLSExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XLSExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set Excel format
extractor.OutputFormat = 1 ' 0 - XLS format; 1 - XLSX format.

' Load sample PDF document
extractor.LoadDocumentFromFile WScript.Arguments.Item(0)

' Extract data to Excel format
extractor.SaveToXLSFile WScript.Arguments.Item(1)

WScript.Echo "Extracted data saved to '" & WScript.Arguments.Item(1) & "' file."
