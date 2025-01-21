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
