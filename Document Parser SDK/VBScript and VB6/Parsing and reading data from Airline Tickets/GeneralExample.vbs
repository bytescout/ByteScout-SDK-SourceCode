'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates document data parsing to JSON and YAML formats.

templatesDocument = "..\..\_Sample Templates\SampleTicket.yml"
inputDocument = "..\..\SampleTicket.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate templatesDocument

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set documentParser = Nothing

