'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
