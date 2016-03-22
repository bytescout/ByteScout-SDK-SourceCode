'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.IO
Imports System.Threading
Imports Bytescout.PDFRenderer

Class Program

    Private Shared _doneEvent As New ManualResetEvent(False) ' synchronization event
    Private Shared _counter As Integer ' thread counter

    Friend Shared Sub Main(args As String())

        ' Get all PDF files in current directory
        Dim pdfFiles As String() = Directory.GetFiles(".", "*.pdf")
        _counter = pdfFiles.Length

        ' Render PDF files in separate threads
        For Each pdfFile As String In pdfFiles
            Dim backgroundThread As New Thread(AddressOf BackgroundThreadProc)
            backgroundThread.Start(pdfFile)
            Console.WriteLine(pdfFile & " - conversion started.")
        Next

        ' Wait until threads finished
        _doneEvent.WaitOne()

        Console.WriteLine("Done.")
        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
    End Sub

	' Rendering thread function
    Private Shared Sub BackgroundThreadProc(data As Object)

        Dim fileName As String = DirectCast(data, String)

        Try
            ' Create renderer
            Using renderer As New RasterRenderer()
                renderer.LoadDocumentFromFile(fileName)

                ' Setup rendering
                renderer.Resolution = 150
                renderer.JPEGQuality = 90

                ' Render document pages
                For i As Integer = 0 To renderer.GetPageCount() - 1
                    renderer.RenderPageToFile(i, RasterOutputFormat.JPEG, fileName & ".page" & i & ".jpg")
                Next
            End Using

            Console.WriteLine(fileName & " - successfully converted.")
        Catch exception As Exception
            Console.WriteLine(exception.ToString())
        End Try

        If Interlocked.Decrement(_counter) = 0 Then
            ' Set event if all threads finished
            _doneEvent.Set()
        End If
    End Sub
End Class
