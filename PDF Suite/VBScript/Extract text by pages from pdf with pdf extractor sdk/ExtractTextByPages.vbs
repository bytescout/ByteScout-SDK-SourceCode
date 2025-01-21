'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("sample2.pdf")

' Get page count
pageCount = extractor.GetPageCount()
		
For i = 0 To pageCount - 1
	fileName = "page" & i & ".txt"

	' Save extracted page text to file
	extractor.SavePageTextToFile i, fileName
Next

' Open first output file in default associated application
Set shell = CreateObject("WScript.Shell")
shell.Run "page0.txt", 1, false
Set shell = Nothing

Set extractor = Nothing

