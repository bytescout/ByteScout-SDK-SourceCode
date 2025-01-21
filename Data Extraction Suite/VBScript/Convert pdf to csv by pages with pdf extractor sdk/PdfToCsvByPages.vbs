'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.CSVExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample3.pdf"

' You can change CSV separator and quotation symbols if needed
'extractor.CSVSeparatorSymbol = "," 
'extractor.CSVQuotaionSymbol = "'" 

' Get page count
pageCount = extractor.GetPageCount()
		
For i = 0 To pageCount - 1

	fileName = "page" & i & ".csv"

	' Save extracted page text to file
	extractor.SavePageCSVToFile i, fileName
Next

WScript.Echo "Extracted data saved as 'page0.csv' and so on..."

