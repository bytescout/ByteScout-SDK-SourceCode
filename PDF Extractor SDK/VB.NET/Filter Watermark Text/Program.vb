'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

		' Create Bytescout.PDFExtractor.TextExtractor instance
		Dim extractor As New TextExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
		extractor.LoadDocumentFromFile(".\DocumentWithWatermark.pdf")

        ' Filter text using text filter
        extractor.AddFilter("^COPY$", caseSensitive:=True, useRegex:=True)

        ' Filter text using appearance filter
        ' extractor.AddFilter("Arial", fontSize:=203, exclude:=True)

        ' Save extracted text to file
        extractor.SaveTextToFile(".\result.txt")

		' Cleanup
		extractor.Dispose()

		' Open result file in default associated application (for demo purposes)
		System.Diagnostics.Process.Start(".\result.txt")
	End Sub
End Class
