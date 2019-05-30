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

    <STAThread>
    Sub Main()

		Using converter As New HtmlToPdfConverter()

			converter.PageSize = PaperKind.A4
			converter.Orientation = PaperOrientation.Portrait
			converter.Footer = "FOOTER TEXT" ' optional footer text

			converter.ConvertHtmlToPdf("sample.html", "result.pdf")
			
			' You can also pass a link instead of the input file:  
			'converter.ConvertHtmlToPdf("http://google.com", "result.pdf")

		End Using

		' Open result file in default PDF viewer
		Process.Start("result.pdf")

    End Sub

End Module
