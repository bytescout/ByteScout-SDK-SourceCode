'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.extractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
extractor.LoadDocumentFromFile("..\..\attachments.pdf")

' Iterate through attachments and save them
For i = 0 To extractor.Count - 1
 extractor.Save i, extractor.GetFileName(i) ' save in the current folder with original filename
Next

MsgBox "Done: " & CStr(extractor.Count) & " attachments extracted"

Set extractor = Nothing

