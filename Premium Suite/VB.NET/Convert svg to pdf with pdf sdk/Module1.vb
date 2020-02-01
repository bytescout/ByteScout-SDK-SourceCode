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


Imports System.Drawing.Printing
Imports Bytescout.PDF.Converters

Module Module1

    <STAThread>
    Sub Main()

        ' HtmlToPdfConverter can convert HTML files with SVG content, or SVG files directly.
        Using converter As New HtmlToPdfConverter()

            converter.PageSize = PaperKind.A4

            converter.ConvertHtmlToPdf("drawing.svg", "result.pdf")
            
            ' You can also pass a link instead of the input file:  
            'converter.ConvertHtmlToPdf("http://somesite.com/files/drawing.svg", "result.pdf")

        End Using

        ' Open result file in default PDF viewer
        Process.Start("result.pdf")

    End Sub

End Module
