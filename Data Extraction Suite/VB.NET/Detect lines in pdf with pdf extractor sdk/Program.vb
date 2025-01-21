'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

' Detect all lines in PDF documents

Module Program

    Sub Main()

        Try

            Using lineDetector As New LineDetector("demo", "demo")

                ' Load PDF Document
                lineDetector.LoadDocumentFromFile("LineDetectSample.pdf")

                ' Get all lines
                Dim foundLinesCollection As FoundLinesCollection = lineDetector.FindLines(0, LineOrientationsToFind.HorizontalAndVertical)

                ' Print output
                Console.WriteLine("Total {0} lines Detected", foundLinesCollection.Count)

                For Each foundLine As FoundLine In foundLinesCollection
                    Console.WriteLine("From: {0}, To: {1}, Width: {2}, Line Orientation: {3}",
                            foundLine.From.ToString(), foundLine.To.ToString(), foundLine.Width, foundLine.LineOrientation.ToString())
                Next

            End Using

        Catch ex As Exception
            Console.WriteLine("ERROR:" + ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub

End Module
