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

Namespace FindText

	Class Program

		Friend Shared Sub Main(args As String())

            ' Create Bytescout.PDFExtractor.TextExtractor instance
			Dim extractor As New TextExtractor()
			extractor.RegistrationName = "demo"
			extractor.RegistrationKey = "demo"

			' Load sample PDF document
			extractor.LoadDocumentFromFile(".\sample2.pdf")

			Dim pageCount As Integer = extractor.GetPageCount()

			' Search each page for some keyword 
			For i As Integer = 0 To pageCount - 1
				If extractor.Find(i, "References", False) Then
					' If page contains the keyword, extract a text from it.
					' For demonstration we'll extract the text from top part of the page only
					extractor.SetExtractionArea(0, 0, 600, 200)
					Dim text As String = extractor.GetTextFromPage(i)
					Console.WriteLine(text)
				End If
			Next

			' Cleanup
			extractor.Dispose()

			Console.WriteLine()
			Console.WriteLine("Press any key to continue...")
			Console.ReadLine()

		End Sub
		
	End Class

End Namespace
