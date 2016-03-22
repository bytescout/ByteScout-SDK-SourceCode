'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\words-with-hyphens.pdf")

' Get page count

pageCount = extractor.GetPageCount()

For i=0 to PageCount-1 
 
 If extractor.Find(i, "hyphen", false) Then ' parameters are: page index, string to find, case sensitivity
 	Do
 		MsgBox "Found word 'hyphen' on page #" & CStr(i) & " at left=" & CStr(extractor.FoundText.Left) & "; top=" & CStr(extractor.FoundText.Top) & "; width=" & CStr(extractor.FoundText.Width) & "; height=" & CStr(extractor.FoundText.Height)
  	Loop While extractor.FindNext
 End If

Next

MsgBox "Done"

Set extractor = Nothing

