'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()

For i = 0 to pageCount - 1

	' find some text
	If extractor.Find (i, "ALIQUIP EX EA COMMODO", false) Then

		Do
			RectLeft = extractor.GetFoundTextRectangle_Left
			RectTop = extractor.GetFoundTextRectangle_Top
			RectWidth = extractor.GetFoundTextRectangle_Width
			RectHeight = extractor.GetFoundTextRectangle_Height

			Wscript.echo "Found on page #" & CStr(i) & " at left=" & CStr(RectLeft) & "; top=" & CStr(RectTop) & "; width=" & CStr(RectWidth) & "; height=" & CStr(RectHeight)

			' check the same text is extracted from returned coordinates
			extractor.SetExtractionArea RectLeft, RectTop, RectWidth, RectHeight
			Wscript.echo "Extracted text: " & extractor.GetTextFromPage(i)
			extractor.ResetExtractionArea
		
		Loop While extractor.FindNext
		
	End If
Next

Set extractor = Nothing

