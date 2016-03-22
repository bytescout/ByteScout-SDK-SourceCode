'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.XLSExtractor instance

		Dim extractor As New XLSExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		File.Delete("output.xls")

		' Load sample PDF document
		extractor.LoadDocumentFromFile("sample3.pdf")

		' Save the spreadsheet to file
        extractor.SaveToXLSFile("output.xls")

		' Open the spreadsheet in default associated application
		Process.Start("output.xls")
	End Sub
End Class
