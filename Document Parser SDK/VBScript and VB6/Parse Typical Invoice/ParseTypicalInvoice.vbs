'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates parsing of typical invoice.

inputDocument = ".\SampleInvoice.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Add an internal generic template for typical invoices.
' Note, if it does not parse all required fields, you should create
' own template using Template Editor application.
documentParser.AddTemplate("internal://invoice")

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output.json", 0, False ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument, "output.yml", 1, False ' 1 = OutputFormat.YAML

' Parse document data in XML format
documentParser.ParseDocument inputDocument, "output.xml", 2, True ' 2 = OutputFormat.XML

' Parse document data in CSV format
documentParser.ParseDocument inputDocument, "output.csv", 3, True ' 3 = OutputFormat.CSV

WScript.Echo "Parsed data saved as 'output.json', 'output.yml', 'output.xml', 'output.csv'."

Set documentParser = Nothing

