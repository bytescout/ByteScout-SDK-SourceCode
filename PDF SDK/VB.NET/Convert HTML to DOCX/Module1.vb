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


Imports Bytescout.PDF.Converters

Module Module1

    Sub Main()

		Using converter As New HtmlToDocxConverter()

			converter.ConvertHtmlToDocx("sample.html", "result.docx")

		End Using

		' Open result file in default DOCX associated application
		Process.Start("result.docx")

    End Sub

End Module
