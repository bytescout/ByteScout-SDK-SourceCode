'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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

' Uncomment this line if you need all pages converted into a single worksheet:
'extractor.PageToWorksheet = False

' Load sample PDF document
extractor.LoadDocumentFromFile WScript.Arguments.Item(0)

' Extract data to Excel format
extractor.SaveToXLSFile WScript.Arguments.Item(1)

WScript.Echo "Extracted data saved to '" & WScript.Arguments.Item(1) & "' file."
