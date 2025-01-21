'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
        extractor.LoadDocumentFromFile("sample2.pdf")

        ' Get page count
        Dim pageCount As Integer = extractor.GetPageCount()

        ' Iterate through pages
        For i As Integer = 0 To pageCount - 1

            ' Define rectangle location to extract from
            Dim location As RectangleF = New RectangleF(0, 0, 200, 200)

            ' Set extraction area
            extractor.SetExtractionArea(location)

            ' Extract text from the extraction area
            Dim text As String = extractor.GetTextFromPage(i)

            Console.WriteLine("Extracted from page #" + i.ToString() + ":")
            Console.WriteLine()
            Console.WriteLine(text)

            ' Reset the extraction area
            extractor.ResetExtractionArea()

            Console.WriteLine()

        Next

        ' Cleanup
		extractor.Dispose()


        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Class
