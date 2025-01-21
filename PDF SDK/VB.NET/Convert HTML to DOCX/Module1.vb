'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
