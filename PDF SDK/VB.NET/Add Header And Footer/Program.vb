'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports Bytescout.PDF
Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush

Module Program

    Sub Main()

        Try

            Using doc As Document = New Document()

                doc.RegistrationName = "demo"
                doc.RegistrationKey = "demo"

                doc.Load("sample.pdf")

                ' Prepare simple template (for example, a logo) And draw it on every page
                ' Create template of specified size
                Dim headerTemplate As GraphicsTemplate = New GraphicsTemplate(250, 50)
                headerTemplate.DrawString("Here is a header text", New Font(StandardFonts.CourierBold, 15), New SolidBrush(), 30, 10)

                Dim footerTemplate As GraphicsTemplate = New GraphicsTemplate(250, 50)
                footerTemplate.DrawString("Here is the footer text", New Font(StandardFonts.CourierBold, 15), New SolidBrush(), 30, 10)

                ' Write template in each pages
                For i As Integer = 0 To doc.Pages.Count - 1
                    Dim currentPage As Page = doc.Pages(i)
                    currentPage.Canvas.DrawTemplate(headerTemplate, 40, 10)
                    currentPage.Canvas.DrawTemplate(footerTemplate, 350, (currentPage.Height - 40))
                Next

                ' Save output file
                doc.Save("result.pdf")
            End Using

            ' Open output file
            Process.Start("result.pdf")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

End Module
