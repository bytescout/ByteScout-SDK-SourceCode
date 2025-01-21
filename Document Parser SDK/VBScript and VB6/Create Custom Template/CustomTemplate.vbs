'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates data parsing from an invoice using the custom template.

customTemplate = ".\SampleTemplate.yml"
inputDocument = ".\SampleInvoice.pdf"

' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Load custom template
documentParser.AddTemplate customTemplate

' Parse invoice data in JSON format
documentParser.ParseDocument inputDocument, "output1.json", 0 ' 0 = OutputFormat.JSON


WScript.Echo "Parsed data saved as 'output1.json'."

Set documentParser = Nothing

