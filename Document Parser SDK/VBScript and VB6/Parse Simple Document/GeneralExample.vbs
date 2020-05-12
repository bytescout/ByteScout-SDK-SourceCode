'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates document data parsing to JSON and YAML formats.

templatesFolder = "..\..\_Sample Templates"

template1 = ".\DigitalOcean.yml"
template2 = ".\AmazonAWS.yml"

inputDocument1 = "..\..\DigitalOcean.pdf"
inputDocument2 = "..\..\AmazonAWS.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading templates...
documentParser.AddTemplate(template1)
documentParser.AddTemplate(template2)

' Parse document data in JSON format
documentParser.ParseDocument inputDocument1, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument2, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set documentParser = Nothing

