'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFAFormExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "..\..\samplexfa.pdf"


for i=0 to 12 ' iterate through 12 content types (see XFAFormContentType enum in the documentation, there are 13 types)

count = extractor.GetCount(i) ' get count of the given type
 For j=0 to count-1
   extractor.SaveToFile i, j, CStr(i) & "-" & CStr(j) & ".xml"
 Next

Next


MsgBox "XFA xml data has been extracted"

