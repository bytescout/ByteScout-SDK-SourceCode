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


Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\Invoice.pdf")

        extractor.RegexSearch = True ' Enable the regular expressions

        Dim pageCount As Integer = extractor.GetPageCount()

        ' Search through pages
        For i As Integer = 0 To pageCount - 1

            ' Search dates in format 12/31/1999
            Dim regexPattern As String = "[0-9]{2}/[0-9]{2}/[0-9]{4}"
            ' See the complete regular expressions reference at https://msdn.microsoft.com/en-us/library/az24scfc(v=vs.110).aspx

            ' Search each page for the pattern
            If extractor.Find(i, regexPattern, False) Then
                Do
                    Console.WriteLine("")
                    Console.WriteLine(("Found on page " & i & " at location ") + extractor.FoundText.Bounds.ToString())
                    Console.WriteLine("")

                    ' Iterate through each element in the found text
                    For Each element As ISearchResultElement In extractor.FoundText.Elements
                        Console.WriteLine("   Text: " + element.Text)
                        Console.WriteLine("   Font is bold: " + element.FontIsBold.ToString())
                        Console.WriteLine("   Font is italic:" + element.FontIsItalic.ToString())
                        Console.WriteLine("   Font name: " + element.FontName)
                        Console.WriteLine("   Font size:" + element.FontSize.ToString())
                        Console.WriteLine("   Font color:" + element.FontColor.ToString())
                        Console.WriteLine()
                    Next

                Loop While extractor.FindNext()

            End If
        Next

        ' Cleanup
		extractor.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()
    End Sub

End Class
