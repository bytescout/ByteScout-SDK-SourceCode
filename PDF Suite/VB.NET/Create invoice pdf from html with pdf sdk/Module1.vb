'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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
