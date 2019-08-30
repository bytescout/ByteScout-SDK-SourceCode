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


' Create Bytescout.PDFExtractor.TextExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Get all files in folder
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set objFolder = objFSO.GetFolder("..\..")
Set colFiles = objFolder.Files

' Convert every PDF file to text 
For Each objFile In colFiles
    if objFSO.GetExtensionName(objFile) = "pdf" Then
        ' Load PDF file
        extractor.LoadDocumentFromFile objFile.Path
        ' Save extracted text to .txt file
        extractor.SaveTextToFile Replace(objFile.Name, "." & objFSO.GetExtensionName(objFile),".txt")
        ' Reset the extractor before load another file
        extractor.Reset
    End If
Next
