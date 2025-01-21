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

' IMPORTANT: This functionality is outdated! Please try Web API version for better results. Free signup: https://pdf.co/
Module Module1

    Sub Main()

		Using converter As New DocxToPdfConverter()

			converter.PageSize = PaperKind.A4
			converter.Orientation = PaperOrientation.Portrait
			converter.Footer = "<p style=""color: blue;"">FOOTER TEXT</p>"

			converter.ConvertDocxToPdf("sample.docx", "result.pdf")

		End Using

		' Open result file in default PDF viewer
		Process.Start("result.pdf")

    End Sub

End Module
