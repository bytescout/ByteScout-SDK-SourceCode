'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Threading
Imports BytescoutImageToVideo

Class Program

    Private Shared numBusy As Integer
    Private Shared doneEvent As ManualResetEvent

    Friend Shared Sub Main(ByVal args As String())

        doneEvent = New ManualResetEvent(False)

        Console.WriteLine("Converting JPG slides to video in multiple threads, please wait...")

        numBusy = 10 ' 10 threads to start

        ' starting threads one by one
        For i As Integer = 1 To numBusy
            ThreadPool.QueueUserWorkItem(AddressOf DoWork, i)
        Next

        ' wait for all threads finished
        doneEvent.WaitOne()

        Console.WriteLine("All threads are finished. Press any key to continue..")
        Console.ReadKey()

    End Sub



    Private Shared Function GetRandomEffect() As TransitionEffectType
        Dim rr As New Random
        GetRandomEffect = rr.Next(CType(TransitionEffectType.teZoomOut, Integer), CType(TransitionEffectType.teBlinds3DHorz, Integer))
    End Function

    Private Shared Sub DoWork(ByVal data As Object)

        Dim index As Integer = CInt(Data)

        Try
            Console.WriteLine("Thread {0} started...", index)

            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Add images and set the duration for every slide
            Dim slide As Slide
            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide1.jpg"), Slide)
            slide.Duration = 3000  ' 3000ms = 3s
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()


            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide2.jpg"), Slide)
            slide.Duration = 3000
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()

            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide3.jpg"), Slide)
            slide.Duration = 3000
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Set output video file name
            converter.OutputVideoFileName = String.Format("result_{0}.wmv", index)

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            Console.WriteLine("Thread {0} finished.", index)

        Catch ex As Exception
            Console.WriteLine("Thread {0} failed: {1}", index, ex.Message)
        End Try

        If Interlocked.Decrement(numBusy) = 0 Then
            doneEvent.Set()
        End If

    End Sub
End Class
