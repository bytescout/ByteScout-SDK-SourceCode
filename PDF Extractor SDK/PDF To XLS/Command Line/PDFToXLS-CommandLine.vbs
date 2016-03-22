'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

if Wscript.Arguments.Length < 2 Then
 WScript.Echo "Usage: PDFToXLS.vbs ""input.PDF"" ""output.XLS"""
 WScript.Quit
End If

' Create Bytescout.PDFExtractor.XLSExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XLSExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

WScript.Echo "Loading file from " & WScript.Arguments.Item(0)
' Load sample PDF document
extractor.LoadDocumentFromFile WScript.Arguments.Item(0)

WScript.Echo "Saving file to " & WScript.Arguments.Item(1)
extractor.SaveToXLSFile WScript.Arguments.Item(1)

WScript.Echo "Success: Data has been extracted to '" & WScript.Arguments.Item(1) & "' file."

