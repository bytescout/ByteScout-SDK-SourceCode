'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
