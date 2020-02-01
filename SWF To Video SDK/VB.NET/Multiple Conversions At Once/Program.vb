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


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

Imports System.Diagnostics
Imports System.Threading
Imports BytescoutSWFToVideo

Class Program

    Shared _numBusy As Integer
    Shared _doneEvent As ManualResetEvent

    Public Shared Sub Main(ByVal args As String())

        _doneEvent = New ManualResetEvent(False)

        Console.WriteLine("Converting SWF movies to video in multiple threads, please wait...")

        _numBusy = 3

        ' Start 3 conversion threads
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 1)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 2)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 3)

        ' Wait for all threads finished
        _doneEvent.WaitOne()

        Console.WriteLine("All threads are finished. Press any key to continue..")
        Console.ReadKey()

    End Sub

    Public Shared Sub DoWork(ByVal data As Object)

        Dim index As Integer = CType(data, Integer)

        Try
            Console.WriteLine("Thread {0} started...", index)

            ' Create BytescoutImageToVideo.ImageToVideo object instance
            Dim converter As SWFToVideo = New SWFToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            converter.SWFConversionMode = SWFConversionModeType.SWFAnimation

            ' set input SWF file 
            converter.InputSWFFileName = String.Format("movie{0}.swf", index)

            ' Set output video file name
            converter.OutputVideoFileName = String.Format("result_{0}.wmv", index)

            ' set FPS 
            converter.FPS = 29.97F

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            Console.WriteLine("Thread {0} finished.", index)

        Catch ex As Exception

            Console.WriteLine("Thread {0} failed: {1}", index, ex.Message)

        End Try

        If Interlocked.Decrement(_numBusy) = 0 Then _doneEvent.Set()

    End Sub

End Class
