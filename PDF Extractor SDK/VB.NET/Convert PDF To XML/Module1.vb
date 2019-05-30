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


Imports System
Imports Bytescout.PDFExtractor

Namespace PDF2XML

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.XMLExtractor instance
            Dim extractor As New XMLExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            extractor.SaveXMLToFile("output.XML")

            ' Cleanup
		    extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.XML' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key...")
            Console.ReadKey()

        End Sub

    End Class

End Namespace

