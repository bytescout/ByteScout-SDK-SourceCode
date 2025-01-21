'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.InfoExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.InfoExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample1.pdf")

Dim info
info = "Author: " & extractor.Author & vbCrLf & _
       "Creator: " & extractor.Creator & vbCrLf & _
       "Producer: " & extractor.Producer & vbCrLf & _
       "Subject: " & extractor.Subject & vbCrLf & _
       "Title: " & extractor.Title & vbCrLf & _
       "CreationDate: " & extractor.CreationDate & vbCrLf & _
       "Keywords: " & extractor.Keywords & vbCrLf & _
       "Encrypted: " & extractor.Encrypted & vbCrLf & _
       "Bookmarks: " & extractor.Bookmarks & vbCrLf

MsgBox info

Set extractor = Nothing

