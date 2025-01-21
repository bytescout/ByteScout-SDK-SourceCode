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

    Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.Remover instance
        Dim remover As New Remover("demo", "demo")

        ' Load sample PDF document
        remover.LoadDocumentFromFile("sample1.pdf")

        ' Remove text objects contained in the specified rectangle or intersecting with it.
        ' NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
        ' to split PDF text objects.
        remover.RemoveText(0, New RectangleF(45.0F, 101.0F, 183.0F, 310.0F), "result1.pdf")

        ' Clean up.
        remover.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue and open result PDF files in default PDF viewer...")
        Console.ReadKey()

        Process.Start("result1.pdf")

    End Sub

End Class
