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


Imports Bytescout.PDF.Converters

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
