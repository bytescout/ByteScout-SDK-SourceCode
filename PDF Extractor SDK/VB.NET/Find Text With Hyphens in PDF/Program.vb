'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Drawing
Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

		' Create Bytescout.PDFExtractor.TextExtractor instance
		Dim extractor As New TextExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
		extractor.LoadDocumentFromFile("words-with-hyphens.pdf")

		Dim pageCount As Integer = extractor.GetPageCount()

		' Search each page for "hyphen" string
		For i As Integer = 0 To pageCount - 1
			If extractor.Find(i, "hyphen", False) Then
				Do
					Console.WriteLine("Found on page " & i.ToString() & " at location " & extractor.FoundText.Bounds.ToString())
				Loop While extractor.FindNext()
			End If
		Next

		' Cleanup
		extractor.Dispose()

		Console.WriteLine()
		Console.WriteLine("Press any key to continue...")
		Console.ReadLine()

	End Sub
End Class
