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
            extractor.LoadDocumentFromFile(".\sample1.pdf")
            
            ' Set the matching mode.
            ' WordMatchingMode.None - treats the search string as substring;
            ' WordMatchingMode.ExactMatch - treats the search string as separate word;
            ' WordMatchingMode.SmartMatch - will find the word in various forms (like Adobe Reader).
            extractor.WordMatchingMode = WordMatchingMode.ExactMatch

            Dim pageCount As Integer = extractor.GetPageCount()

            For i As Integer = 0 To pageCount - 1
                ' Search each page for "ipsum" string
                If extractor.Find(i, "ipsum", False) Then
                    Do
                        Console.WriteLine("")
                        Console.WriteLine(("Found on page " & i & " at location ") + extractor.FoundText.Bounds.ToString())
                        Console.WriteLine("")
                        ' Iterate through each element in the found text
                        For Each element As SearchResultElement In extractor.FoundText.Elements
                        Console.WriteLine((((("Element #" + element.Index.ToString() & " at left=") + element.Left.ToString() & "; top=") + element.Top.ToString() & "; width=") + element.Width.ToString() & "; height=") + element.Height.ToString())
                        Console.WriteLine("Text: " + element.Text)
                        Console.WriteLine("Font is bold: " + element.FontIsBold.ToString())
                        Console.WriteLine("Font is italic:" + element.FontIsItalic.ToString())
                        Console.WriteLine("Font name: " + element.FontName)
                        Console.WriteLine("Font size:" + element.FontSize.ToString())
                        Console.WriteLine("Font color:" + element.FontColor.ToString())

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
