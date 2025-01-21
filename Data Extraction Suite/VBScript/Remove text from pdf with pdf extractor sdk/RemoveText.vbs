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
Set remover = CreateObject("Bytescout.PDFExtractor.Remover")
remover.RegistrationName = "demo"
remover.RegistrationKey = "demo"

' Load sample PDF document
remover.LoadDocumentFromFile "../../sample1.pdf"

' Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
' NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
' the whole PDF text object containing the search string.
remover.RemoveText 0, "LOREM IPSUM", True, "result.pdf"
        
WScript.Echo "Modified document saved as 'result.pdf' file."
