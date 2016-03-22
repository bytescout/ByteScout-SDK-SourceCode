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
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count

pageCount = extractor.GetPageCount()

foundMessage = ""

For i=0 to PageCount-1 
 
 If extractor.Find(i, "ipsum", false) Then ' parameters are: page index, string to find, case sensitivity
 	Do
	
		foundMessage = "Found word 'ipsum' on page #" & CStr(i) & " at left=" & CStr(extractor.FoundText.Left) & "; top=" & CStr(extractor.FoundText.Top) & "; width=" & CStr(extractor.FoundText.Width) & "; height=" & CStr(extractor.FoundText.Height)

		' iterate through each element in the found text
		For j=0 to extractor.FoundText.ElementCount-1 	
		
		' get search result element
		Set element = extractor.FoundText.GetElement(0)	

		elementInfo= "Element #" & CStr(j) & " at left=" & CStr(element.Left) & "; top=" & CStr(element.Top) & "; width=" & CStr(element.Width) & "; height=" & CStr(element.Height) & vbCRLF
		elementInfo= elementInfo& "Text: " & CStr(element.Text) & vbCRLF
		elementInfo= elementInfo& "Font is bold: " & CStr(element.FontIsBold) & vbCRLF
		elementInfo= elementInfo& "Font is italic:" & CStr(element.FontIsItalic) & vbCRLF
		elementInfo= elementInfo& "Font name: " & CStr(element.FontName) & vbCRLF
		elementInfo= elementInfo& "Font size:" & CStr(element.FontSize) & vbCRLF
		elementInfo= elementInfo & "Font color (as Ole Color):" & CStr(element.FontColorAsOleColor) 			
		Next 

		MsgBox foundMessage & vbCRLF & vbCRLF & elementInfo


  	Loop While extractor.FindNext
 End If

Next

MsgBox "Done"

Set extractor = Nothing

