'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "sample3.pdf"

' Add the following params to get clean data with word nodes only:
extractor.DetectNewColumnBySpacesRatio = 0.1 ' this splits all text into words
extractor.PreserveFormattingOnTextExtraction = false ' get rid of empty nodes

extractor.SaveXMLToFile "output.xml"

WScript.Echo "Extracted data saved to 'output.xml' file."
