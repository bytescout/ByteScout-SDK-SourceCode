'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create Bytescout.PDFExtractor.InfoExtractor object
Set infoExtractor = CreateObject("Bytescout.PDFExtractor.InfoExtractor")
infoExtractor.RegistrationName = "demo"
infoExtractor.RegistrationKey = "demo"

' Create Bytescout.PDFExtractor.TextExtractor object
Set textExtractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
textExtractor.RegistrationName = "demo"
textExtractor.RegistrationKey = "demo"

' Create File System object
Set FSO = CreateObject("Scripting.FileSystemObject")

' Get folder object
Set objFolder = FSO.GetFolder("..\..")
' Get file list
Set files = objFolder.Files

' Create output file
Set textFile = FSO.CreateTextFile("output.txt", True, True)

For Each file in files
    
    ext = UCase(FSO.GetExtensionName(file))	
    If ext = "PDF" Then
        
        infoExtractor.LoadDocumentFromFile(file)    
        textFile.WriteLine("File Name:    " & FSO.GetFileName(file))
        textFile.WriteLine("Page Count:   " & infoExtractor.GetPageCount())
        textFile.WriteLine("Author:       " & infoExtractor.Author)
        textFile.WriteLine("Title:        " & infoExtractor.Title)
        textFile.WriteLine("Producer:     " & infoExtractor.Producer)
        textFile.WriteLine("Subject:      " & infoExtractor.Subject)
        textFile.WriteLine("CreationDate: " & infoExtractor.CreationDate)
                
        textExtractor.LoadDocumentFromFile(file)
        text = textExtractor.GetTextFromPage(0)
        
        If len(text) > 0 Then
            textFile.WriteLine("Text (first 200 chars): ")
            textFile.WriteLine(Mid(text, 1, 200))
        End If
        
        textFile.WriteBlankLines(2)
    End If 
    
Next

textFile.Close

Set infoExtractor = Nothing
Set textExtractor = Nothing
Set FSO = Nothing

WScript.Echo "Done."
