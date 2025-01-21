'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.extractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
extractor.LoadDocumentFromFile("attachments.pdf")

' Iterate through attachments and save them
For i = 0 To extractor.Count - 1
    ' Save file to current folder with original name
    extractor.Save i, extractor.GetFileName(i)
Next

MsgBox "Done: " & CStr(extractor.Count) & " attachments extracted"

Set extractor = Nothing

