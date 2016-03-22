'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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
Set TS = FSO.CreateTextFile("output.txt")

For Each file in files
	
	ext = UCase(FSO.GetExtensionName(file))	
	If ext = "PDF" Then
		
        infoExtractor.LoadDocumentFromFile(file)    
        TS.WriteLine("File Name:    " & FSO.GetFileName(file))
        TS.WriteLine("Page Count:   " & infoExtractor.GetPageCount())
        TS.WriteLine("Author:       " & infoExtractor.Author)
        TS.WriteLine("Title:        " & infoExtractor.Title)
        TS.WriteLine("Producer:     " & infoExtractor.Producer)
        TS.WriteLine("Subject:      " & infoExtractor.Subject)
        TS.WriteLine("CreationDate: " & infoExtractor.CreationDate)
        		
		textExtractor.LoadDocumentFromFile(file)
		text = textExtractor.GetTextFromPage(0)
		
		If len(text) > 0 Then
			TS.WriteLine("Text (a bit): ")
			TS.WriteLine(Mid(text, 1, 200))
		End If
		
		TS.WriteBlankLines(2)
	End If 
	
Next

TS.Close

Set infoExtractor = Nothing
Set textExtractor = Nothing
Set FSO = Nothing
