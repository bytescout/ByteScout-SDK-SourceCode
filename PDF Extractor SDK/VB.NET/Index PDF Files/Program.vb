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


Imports System.IO
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.InfoExtractor instance
        Dim infoExtractor As New InfoExtractor()
        infoExtractor.RegistrationName = "demo"
        infoExtractor.RegistrationKey = "demo"

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim textExtractor As New TextExtractor()
        textExtractor.RegistrationName = "demo"
        textExtractor.RegistrationKey = "demo"

        ' List all PDF files in directory
        For Each file As String In Directory.GetFiles("..\..\..\..", "*.pdf")
            infoExtractor.LoadDocumentFromFile(file)

            Console.WriteLine("File Name:      " & Path.GetFileName(file))
            Console.WriteLine("Page Count:     " & infoExtractor.GetPageCount())
            Console.WriteLine("Author:         " & infoExtractor.Author)
            Console.WriteLine("Title:          " & infoExtractor.Title)
            Console.WriteLine("Producer:       " & infoExtractor.Producer)
            Console.WriteLine("Subject:        " & infoExtractor.Subject)
            Console.WriteLine("CreationDate:   " & infoExtractor.CreationDate)
            Console.WriteLine("Text (2 lines): ")

            textExtractor.LoadDocumentFromFile(file)
            Using stringReader As New StringReader(textExtractor.GetTextFromPage(0))
                Console.WriteLine(stringReader.ReadLine())
                Console.WriteLine(stringReader.ReadLine())
            End Using
            Console.WriteLine()
        Next

        infoExtractor.Dispose()
        textExtractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()
    End Sub
End Class
