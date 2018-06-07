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


Imports Bytescout.PDFExtractor
Imports System.IO

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor = New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Get PDF files 
        Dim pdfFiles() = Directory.GetFiles(".", "*.pdf")

        For Each file As String In pdfFiles

            ' Load document
            extractor.LoadDocumentFromFile(file)

            ' Save extracted text to .txt file
            extractor.SaveTextToFile(Path.ChangeExtension(file, ".txt"))

            ' Reset the extractor before load another file
            extractor.Reset()

        Next

        ' Cleanup
		extractor.Dispose()

    End Sub

End Module
