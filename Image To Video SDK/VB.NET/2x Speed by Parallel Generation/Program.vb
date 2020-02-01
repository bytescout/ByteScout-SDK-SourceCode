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


' You can speed up the conversion using the following technique:
' 1) Generate video parts in parallel threads;
' 2) Combine these parts into final video.
' Let us say you have 20 slides.
' Then you can run a thread to convert 1-10 slides and another one to convert 11-20 slides.
' Finally combine these parts into a single one using .JoinWMVFiles(part1, part2, output) 
' or .JoingAVIFiles(part1, part2, output) functions.

Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Threading
Imports BytescoutImageToVideo

Class ThreadData
	Public InputFiles As String()
	Public OutputFile As String

    Public Sub New(ByVal inputFiles As String(), ByVal outputFile As String)
        Me.InputFiles = inputFiles
        Me.OutputFile = outputFile
    End Sub
End Class

Class Program
    Private Shared NumBusy As Integer
    Private Shared DoneEvent As ManualResetEvent

    Friend Shared Sub Main(ByVal args As String())
        DoneEvent = New ManualResetEvent(False)
        NumBusy = 2

        ' variable to store video file extension
        Dim videoFileExt As String

        ' are we using WMV or AVI video format for output
        Dim isWMV As Boolean = False

        ' if is WMV then use .wmv extension
        If isWMV Then
            videoFileExt = ".wmv"
        Else
            ' else use AVI
            videoFileExt = ".avi"
        End If

        ' Start two conversion threads
        Console.WriteLine("Start first thread...")
        Dim threadData1 As New ThreadData(New String() {"slide1.jpg", "slide2.jpg", "slide3.jpg"}, "Part1" & videoFileExt)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, threadData1)

        Console.WriteLine("Start second thread...")
        Dim threadData2 As New ThreadData(New String() {"slide4.jpg", "slide5.jpg", "slide6.jpg"}, "Part2" & videoFileExt)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, threadData2)

        ' Wait for both threads finished
        DoneEvent.WaitOne()

        ' Join generates parts
        Console.WriteLine("Join parts into the final video file...")
        Dim converter As New ImageToVideo()

        If isWMV Then
            converter.JoinWMVFiles("Part1" & videoFileExt, "Part2" & videoFileExt, "Result" & videoFileExt)
        Else
            converter.JoinAVIFiles("Part1" & videoFileExt, "Part2" & videoFileExt, "Result" & videoFileExt)
        End If

        ' Open the output video file in default media player
        Process.Start("Result" & videoFileExt)

        Console.WriteLine("Done. Press any key to continue...")
        Console.ReadKey()
    End Sub

    Private Shared Sub DoWork(ByVal data As Object)

        Dim threadData As ThreadData = DirectCast(data, ThreadData)

        Try
            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Add slides
            For Each file As String In threadData.InputFiles
                Dim slide As Slide = converter.AddImageFromFileName(file)
                slide.Duration = 3000 ' 3000ms = 3s
                slide.Effect = SlideEffectType.seEaseIn
            Next

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Set output video file name
            converter.OutputVideoFileName = threadData.OutputFile

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            Marshal.ReleaseComObject(converter)

            Console.WriteLine("Thread finished.")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        If Interlocked.Decrement(NumBusy) = 0 Then
            DoneEvent.Set()
        End If

    End Sub
End Class
