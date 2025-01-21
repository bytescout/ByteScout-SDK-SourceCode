'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates extracting line items from tables on multiple pages with two different approaches.
' See comments in the code of templates.

inputDocument = ".\MultiPageTable.pdf"
template1 = ".\MultiPageTable-template1.yml"
template2 = ".\MultiPageTable-template2.yml"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate(template1)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "result1.json", 0

Set documentParser = Nothing


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate(template2)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "result2.json", 0


WScript.Echo "Parsed data saved as 'result1.json' and 'result2.json'."

Set documentParser = Nothing

