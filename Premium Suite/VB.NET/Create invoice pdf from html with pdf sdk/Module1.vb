'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing.Printing
Imports Bytescout.PDF.Converters

Module Module1

    ''' <summary>
    ''' This example demonstrates how to create invoice from HTML.
    ''' </summary>
    <STAThread>
    Sub Main()

        Using converter As New HtmlToPdfConverter()

            converter.PageSize = PaperKind.Letter
            converter.Orientation = PaperOrientation.Portrait

            ' Convert input HTML to output pdf
            converter.ConvertHtmlToPdf("invoice.html", "result.pdf")

        End Using

        ' Open result file in default PDF viewer
        Process.Start("result.pdf")

    End Sub

End Module
