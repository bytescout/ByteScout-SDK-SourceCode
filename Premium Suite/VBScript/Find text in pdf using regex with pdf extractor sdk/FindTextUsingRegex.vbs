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


' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile("..\..\Invoice.pdf")

extractor.RegexSearch = True ' Turn on the regex search
pattern = "[0-9]{2}/[0-9]{2}/[0-9]{4}" ' Search dates in format 'mm/dd/yyyy'

' Get page count
pageCount = extractor.GetPageCount()

For i = 0 to PageCount - 1 
    If extractor.Find(i, pattern, false) Then ' Parameters are: page index, string to find, case sensitivity
        Do
            extractedString = extractor.FoundText.Text
            MsgBox "Found match on page #" & CStr(i) & ": " & extractedString
            extractor.ResetExtractionArea()
        Loop While extractor.FindNext
    End If
Next

MsgBox "Done"

Set extractor = Nothing
