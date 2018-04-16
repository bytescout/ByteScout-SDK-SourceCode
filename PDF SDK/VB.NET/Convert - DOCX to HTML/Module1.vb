'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
