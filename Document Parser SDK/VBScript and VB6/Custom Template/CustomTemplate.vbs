'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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

