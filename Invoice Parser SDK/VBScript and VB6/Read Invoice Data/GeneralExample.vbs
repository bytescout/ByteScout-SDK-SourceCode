'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates invoice data parsing to JSON and YAML formats.

inputDocument1 = "DigitalOcean.pdf"
inputDocument2 = "AmazonAWS.pdf"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument1, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse invoice data in YAML format
invoiceParser.ParseDocument inputDocument2, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set invoiceParser = Nothing

