'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())

		' Create Bytescout.PDFExtractor.TextExtractor instance
		Dim extractor As New TextExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
		extractor.LoadDocumentFromFile("sample2.pdf")

		' set to extract text column by column
		extractor.ExtractColumnByColumn = true

		' Save extracted text to file
		extractor.SaveTextToFile("output.txt")

		' Open output file in default associated application
		System.Diagnostics.Process.Start("output.txt")
	End Sub
End Class
