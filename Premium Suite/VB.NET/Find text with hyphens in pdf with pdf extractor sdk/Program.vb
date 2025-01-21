'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
