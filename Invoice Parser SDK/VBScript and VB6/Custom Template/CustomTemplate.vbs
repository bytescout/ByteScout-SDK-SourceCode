'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


' This example demonstrates invoice data parsing using the custom template.

customTemplate = ".\SampleTemplate.yml"
inputDocument = ".\SampleInvoice.pdf"

' Create InvoiceParser object
Set invoiceParser = CreateObject("Bytescout.InvoiceParser.InvoiceParser")
invoiceParser.RegistrationName = "demo"
invoiceParser.RegistrationKey = "demo"

' Load custom template
invoiceParser.AddTemplateFromFile customTemplate

' Parse invoice data in JSON format
invoiceParser.ParseDocument inputDocument, "output1.json", 0 ' 0 = OutputFormat.JSON


WScript.Echo "Parsed data saved as 'output1.json'."

Set invoiceParser = Nothing

