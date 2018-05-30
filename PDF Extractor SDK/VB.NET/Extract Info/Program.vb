'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.InfoExtractor instance
        Dim extractor As New InfoExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
        extractor.LoadDocumentFromFile(".\sample1.pdf")

        Console.WriteLine("Author:       " + extractor.Author)
        Console.WriteLine("Creator:      " + extractor.Creator)
        Console.WriteLine("Producer:     " + extractor.Producer)
        Console.WriteLine("Subject:      " + extractor.Subject)
        Console.WriteLine("Title:        " + extractor.Title)
        Console.WriteLine("CreationDate: " + extractor.CreationDate)
        Console.WriteLine("Keywords:     " + extractor.Keywords)
        Console.WriteLine("Bookmarks:    " + extractor.Bookmarks)
        Console.WriteLine("Encrypted:    " + extractor.Encrypted.ToString)

        ' Cleanup
		extractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

	End Sub
End Class
