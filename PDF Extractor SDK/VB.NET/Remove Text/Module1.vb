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


Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program

    Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.Remover instance
        Dim remover As New Remover("demo", "demo")

        ' Load sample PDF document
        remover.LoadDocumentFromFile("sample1.pdf")

        ' Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
        ' NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
        ' the whole PDF text object containing the search string.
        remover.RemoveText(0, "LOREM IPSUM", True, "result1.pdf")

        ' Remove text objects contained in the specified rectangle or intersecting with it.
        ' NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
        ' to split PDF text objects.
        remover.RemoveText(0, New RectangleF(74.0F, 550.0F, 489.0F, 67.0F), "result2.pdf")

        ' Remove text object contained in the specified point.
        ' NOTE: The removed text might be larger than a word in the specified point. Currently the Remover is able 
        ' to remove only the whole PDF text object containing the word.
        remover.RemoveText(0, New PointF(121.0F, 230.0F), "result3.pdf")

        ' Clean up.
        remover.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue and open result PDF files in default PDF viewer...")
        Console.ReadKey()

        Process.Start("result1.pdf")
        Process.Start("result2.pdf")
        Process.Start("result3.pdf")

    End Sub

End Class
