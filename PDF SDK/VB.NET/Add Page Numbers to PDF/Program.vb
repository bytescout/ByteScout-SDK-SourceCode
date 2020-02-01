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


Imports Bytescout.PDF
Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush

Module Program

#Region "Declarations"

    Private Enum PageNoStyle
        TopLeft
        TopRight
        BottomLeft
        BottomRight
    End Enum

#End Region

    Sub Main()

        Try

            Using doc As Document = New Document()

                ' Add registration keys
                doc.RegistrationName = "demo"
                doc.RegistrationKey = "demo"

                ' Load document
                doc.Load("sample.pdf")

                ' Write template in each pages
                For i As Integer = 0 To doc.Pages.Count - 1
                    Dim currentPage As Page = doc.Pages(i)
                    _AddPageNo(currentPage, "Page #" & (i + 1), PageNoStyle.BottomRight)
                Next

                ' Save output file
                doc.Save("result.pdf")
            End Using

            ' Open output file
            Process.Start("result.pdf")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Add Page No
    ''' </summary>
    Private Sub _AddPageNo(ByVal currentPage As Page, ByVal pageNoText As String, ByVal pageNoStyle As PageNoStyle)

        Dim float_left As Single = 10
        Dim float_top As Single = 10

        Select Case pageNoStyle
            Case PageNoStyle.TopRight
                float_left = currentPage.Width - 60
            Case PageNoStyle.BottomLeft
                float_top = currentPage.Height - 20
            Case PageNoStyle.BottomRight
                float_top = currentPage.Height - 20
                float_left = currentPage.Width - 60
            Case Else
        End Select

        ' Draw/Write page no
        currentPage.Canvas.DrawString(
            pageNoText,
            New Font(StandardFonts.CourierBold, 12),
            New SolidBrush(),
            float_left,
            float_top)

    End Sub

End Module
