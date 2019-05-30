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
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Dim extractor As New CSVExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3.pdf")

            'extractor.CSVSeparatorSymbol = "," // you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales

            ' Get page count
            Dim pageCount As Integer = extractor.GetPageCount()

            For i As Integer = 0 To pageCount - 1
                Dim fileName As String = "page" & i & ".csv"

                ' Save extracted page text to file
                extractor.SavePageCSVToFile(i, fileName)
            Next

            ' Cleanup
		    extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...")
            Console.ReadKey()

            ' Open result file in default associated application (for demo purposes)
            Process.Start("page0.csv")

        End Sub

    End Class

End Namespace

