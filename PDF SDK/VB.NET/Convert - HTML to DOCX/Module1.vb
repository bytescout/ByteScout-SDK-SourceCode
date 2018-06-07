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

		Using converter As New HtmlToDocxConverter()

			converter.ConvertHtmlToDocx("sample.html", "result.docx")

		End Using

		' Open result file in default DOCX associated application
		Process.Start("result.docx")

    End Sub

End Module
