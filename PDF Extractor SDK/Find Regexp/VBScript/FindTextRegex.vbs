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
extractor.LoadDocumentFromFile("sample.pdf")

extractor.RegexSearch = True ' turn on the regex search
pattern = "\d{1,3}[\.,]+\d{2,3}[\.,]+\d{2,4}" ' search for numbers in format like 12,123,000 or 12.10.2010

' complete regular expressions patterns reference: https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx


' Get page count
pageCount = extractor.GetPageCount()

For i = 0 to PageCount-1 
 
If extractor.Find(i, pattern, false) Then ' parameters are: page index, string to find, case sensitivity
	Do
 		extractedString = extractor.FoundText.Text
 		MsgBox "Found match on page #" & CStr(i) & ": " & extractedString
 		extractor.ResetExtractionArea()
	Loop While extractor.FindNext
End If

Next

MsgBox "Done"

Set extractor = Nothing
