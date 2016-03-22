'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.ImageExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.ImageExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()
		
' Extract images from each page
For i = 0 To pageCount - 1

	j = 0
	
	' Initialize page images enumeration
	If extractor.GetFirstPageImage(i) Then
	    Do
	        outputFileName = "page" & i & "image" & j & ".png"


        ' display coordinates of the image
	MsgBox      "Image #" & CStr(j) & " on page #" & CStr(i) & vbCRLF & "Coordinates: " & CStr( extractor.GetCurrentImageRectangle_Left()) & ", " & CStr( extractor.GetCurrentImageRectangle_Top()) & ", " & CStr( extractor.GetCurrentImageRectangle_Width()) & ", " & CStr( extractor.GetCurrentImageRectangle_Height())

	        j = j + 1

	    Loop While extractor.GetNextImage() ' Advance image enumeration
	End If
Next


Set extractor = Nothing

