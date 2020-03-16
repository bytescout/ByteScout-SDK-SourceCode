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
