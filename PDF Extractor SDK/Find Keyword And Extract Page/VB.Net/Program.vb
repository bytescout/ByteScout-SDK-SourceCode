'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example page extraction by found keyword.

Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())
		Dim inputFile As String = "sample.pdf"

		' Create Bytescout.PDFExtractor.TextExtractor instance
		Dim extractor As New TextExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
		extractor.LoadDocumentFromFile("sample.pdf")

		Dim pageCount As Integer = extractor.GetPageCount()

		' Search each page for a keyword 
		For i As Integer = 0 To pageCount - 1
			If extractor.Find(i, "history", False) Then
				' extract page
				Using splitter As New DocumentSplitter("demo", "demo")
					splitter.OptimizeSplittedDocuments = True

					Dim pageNumber As Integer = i + 1
					' (!) page number in ExtractPage() is 1-based
					Dim outputFile As String = "page" & pageNumber.ToString() & ".pdf"
					splitter.ExtractPage(inputFile, outputFile, pageNumber)
					Console.WriteLine("Extracted page " & pageNumber.ToString() & " to file """ & outputFile & """")
				End Using
			End If
		Next

		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()
	End Sub
End Class
