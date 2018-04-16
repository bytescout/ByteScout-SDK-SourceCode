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


' This example demonstrates various PDF document splitting scenarios:
' - extract a single page;
' - split in two parts;
' - split by ranges specified in text form: "1-5,6,7-10,11-".

Imports System.IO
Imports Bytescout.PDFExtractor

Class Program
	Friend Shared Sub Main(args As String())
		Dim inputFile As String = ".\sample.pdf"

		Using splitter As New DocumentSplitter("demo", "demo")
			splitter.OptimizeSplittedDocuments = True

			' Extracting specific page:
			' =========================

			splitter.ExtractPage(inputFile, "page3.pdf", 3)
			' (!) Note: page number is 1-based.
			Console.WriteLine("Extracted page 3 to file ""page3.pdf""")
			Console.WriteLine()

			' Split in two parts:
			' ===================

			splitter.Split(inputFile, "part1.pdf", "part2.pdf", 3)
			' (!) Note: page number is 1-based.
			Console.WriteLine("Splitted at page 3 to files ""part1.pdf"" and ""part2.pdf""")
			Console.WriteLine()

			' Split by ranges:
			' ================

			Dim files As String() = splitter.Split(inputFile, "1-3,4-6,7,8-")
			' (!) Note: page numbers are 1-based; ending "-" means "to the end".
			Console.WriteLine("Splitted by ranges: ")
			For Each file As String In files
				Console.WriteLine("    " & Path.GetFileName(file))
			Next
		End Using

		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()
	End Sub
End Class
