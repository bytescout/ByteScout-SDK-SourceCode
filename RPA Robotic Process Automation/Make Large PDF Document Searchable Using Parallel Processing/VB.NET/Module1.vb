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


Imports System.IO
Imports System.Threading
Imports Bytescout.PDFExtractor

Module Module1

    ' Limit to 4 threads in queue.
    ' Set this value to number of your processor cores for max performance.
    Dim ThreadLimiter as Semaphore = New Semaphore(4, 4)

	<MTAThread>
	Sub Main()

		Const inputFile = "sample.pdf"
		Const resultFile = "result.pdf"

		Dim pageCount As Integer

		' Get document page count
		Using infoExtractor = New InfoExtractor()
			infoExtractor.LoadDocumentFromFile(inputFile)
			pageCount = infoExtractor.GetPageCount()
		End Using

		' Process the document by 10-page pieces
		Dim numberOfThreads As Integer
		numberOfThreads = pageCount \ 10
		If (pageCount - numberOfThreads * 10 > 0) Then numberOfThreads = numberOfThreads + 1

		Dim doneEvents(numberOfThreads - 1) As WaitHandle
		Dim stopwatch As Stopwatch = Stopwatch.StartNew()
		Dim startPage, endPage As Integer
		Dim pieces(numberOfThreads - 1) As String

		' Run threads
		For i As Integer = 0 To numberOfThreads - 1

            ' Wait for the queue
		    ThreadLimiter.WaitOne()

			doneEvents(i) = New ManualResetEvent(False)
			startPage = i * 10
			endPage = Math.Min(pageCount - 1, (i + 1) * 10 - 1)
			
			If numberOfThreads = 1 Then
				endPage = endPage - 1
			End If
						
			pieces(i) = String.Format("temp-{0}-{1}.pdf", startPage, endPage)
			ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf ThreadProc), New Object() {i, doneEvents(i), inputFile, pieces(i), startPage, endPage})

		Next

		' Wait for all threads
		WaitHandle.WaitAll(doneEvents)

		' Merge pieces 
		Using merger = New DocumentMerger
			merger.Merge(pieces, resultFile)
		End Using

		' Delete temp files
		For Each tempFile As String In pieces
			File.Delete(tempFile)
		Next
		
		Console.WriteLine("All done in {0}.", stopwatch.Elapsed)
		Console.WriteLine()

		Console.WriteLine("Press any key to exit...")
		Console.ReadKey()

	End Sub

	Sub ThreadProc(ByVal stateInfo As Object)

		Dim threadIndex As Integer = stateInfo(0)
		Dim waitEvent As ManualResetEvent = stateInfo(1)
		Dim inputFile As String = stateInfo(2)
		Dim outputFile As String = stateInfo(3)
		Dim startPage As Integer = stateInfo(4)
		Dim endPage As Integer = stateInfo(5)

	    Try

	        Console.WriteLine("Thread #{0} started with the page range from {1} to {2}.", threadIndex, startPage, endPage)

		    Dim stopwatch As Stopwatch = Stopwatch.StartNew()

		    ' Extract a piece of document
		    Dim chunk As String = String.Format("temp-{0}-{1}", startPage, endPage)
		    Using splitter = New DocumentSplitter
			    splitter.ExtractPageRange(inputFile, chunk, startPage + 1, endPage + 1)
		    End Using

		    ' Process the piece
		    Using searchablePdfMaker As New SearchablePDFMaker("demo", "demo")

			    searchablePdfMaker.OCRDetectPageRotation = True
			    searchablePdfMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"
			    searchablePdfMaker.LoadDocumentFromFile(chunk)

			    ' 300 DPI resolution is recommended. 
			    ' Using of higher values will slow down the processing but does not guarantee the higher quality.
			    searchablePdfMaker.OCRResolution = 300

			    searchablePdfMaker.MakePDFSearchable(outputFile)

		    End Using

		    File.Delete(chunk)

		    Console.WriteLine("Thread #{0} finished in {1}.", threadIndex, stopwatch.Elapsed)

	    Finally

            ' Signal the thread is finished
	        waitEvent.Set()

            ' Release semaphore
	        ThreadLimiter.Release()

	    End Try

		
	End Sub

End Module
