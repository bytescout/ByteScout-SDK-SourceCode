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


' Create Bytescout.PDFExtractor.AttachmentExtractor object
Set AttachmentExtractor = CreateObject("Bytescout.PDFExtractor.AttachmentExtractor")
AttachmentExtractor.RegistrationName = "demo"
AttachmentExtractor.RegistrationKey = "demo"

' Load sample PDF document with embedded attachments
AttachmentExtractor.LoadDocumentFromFile("..\..\ZUGFeRD-invoice.pdf")

' Walk through attachments and save them
For i = 0 To AttachmentExtractor.Count - 1
    ' Save file to current folder with original name
    AttachmentExtractor.Save i, AttachmentExtractor.GetFileName(i) 
Next

WScript.Echo "Done! Click OK to open the XML invoice"

Set extractor = Nothing

