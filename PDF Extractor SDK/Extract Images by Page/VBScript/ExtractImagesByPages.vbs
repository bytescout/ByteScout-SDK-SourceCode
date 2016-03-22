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

	        ' Save image to file
	        extractor.SaveCurrentImageToFile outputFileName

	        j = j + 1

	    Loop While extractor.GetNextImage() ' Advance image enumeration
	End If
Next

' Open first output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "page0image0.png", 1, false
Set shell = Nothing

Set extractor = Nothing

