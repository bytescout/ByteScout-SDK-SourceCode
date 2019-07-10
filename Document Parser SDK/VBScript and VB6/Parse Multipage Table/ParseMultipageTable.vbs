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


' This example demonstrates parsing of multipage tables in two different approaches.
' See comments in the code of templates.

inputDocument = "..\..\MultiPageTable.pdf"
template1 = "..\..\_Sample Templates\MultiPageTable-template1.yml"
template2 = "..\..\_Sample Templates\MultiPageTable-template2.yml"


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

