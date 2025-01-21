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
