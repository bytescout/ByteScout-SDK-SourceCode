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

Module Program

    Sub Main()

        Try

            Using pdfDocument As New Document

                pdfDocument.RegistrationName = "demo"
                pdfDocument.RegistrationKey = "demo"

                pdfDocument.Load("sample.pdf")

                Dim page As Page = pdfDocument.Pages(0)

                ' copy page content as template
                Dim template As GraphicsTemplate = page.SaveAsTemplate()

                ' create New page of required size
                Dim newPage = New Page(PaperFormat.A4)
                ' draw the stored template on the New page with required offset
                newPage.Canvas.DrawTemplate(template, 50, 50)

                ' replace the old page with the New one
                pdfDocument.Pages.Remove(0)
                pdfDocument.Pages.Add(newPage)

                'Save output file
                pdfDocument.Save("result.pdf")


            End Using

            'Open output file
            Process.Start("result.pdf")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
