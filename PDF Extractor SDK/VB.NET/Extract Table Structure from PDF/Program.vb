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

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.StructuredExtractor instance
        Dim extractor As New StructuredExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
        extractor.LoadDocumentFromFile(".\sample3.pdf")


        For pageIndex As Integer = 0 To extractor.GetPageCount() - 1

            Console.WriteLine("Starting extraction from page #" + pageIndex.ToString())
            Console.WriteLine()

            extractor.PrepareStructure(pageIndex)

            Dim rowCount As Integer = extractor.GetRowCount(pageIndex)

            For row As Integer = 0 To rowCount - 1

                Dim columnCount As Integer = extractor.GetColumnCount(pageIndex, row)

                For col As Integer = 0 To columnCount - 1

                    Console.WriteLine(extractor.GetCellValue(pageIndex, row, col))

                Next
            Next
        Next

        ' Cleanup
		extractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

	End Sub
End Class
