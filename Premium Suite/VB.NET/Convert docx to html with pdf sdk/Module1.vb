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

' IMPORTANT: This functionality is outdated! Please try Web API version for better results. Free signup: https://pdf.co/
Module Module1

    Sub Main()

		Using converter As New DocxToHtmlConverter()

			converter.IndentHtmlCode = True
			converter.WriteByteOrderMark = True

			converter.ConvertDocxToHtml("sample.docx", "result.html", True)

		End Using

		' Open merged document in default browser
		Process.Start("result.html")

    End Sub

End Module
