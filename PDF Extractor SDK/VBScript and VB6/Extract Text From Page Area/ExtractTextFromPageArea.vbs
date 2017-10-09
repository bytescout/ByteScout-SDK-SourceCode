'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\sample1.pdf")

' Get page count
pageCount = extractor.GetPageCount()

' Iterate through pages
For i = 0 to pageCount - 1

	' Set extraction area (in Points. 1 Point = 1/72 in.)
	extractor.SetExtractionArea 0, 0, 200, 200
	
	' Extract text from the extraction area
	text = extractor.GetTextFromPage(i)

	Wscript.echo "Page #" & CStr(i) & " text from area (0, 0, 200, 200): " & vbCr & vbLf & text

	extractor.ResetExtractionArea
	
Next

Set extractor = Nothing

