'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'




Imports System.IO
Imports System.Threading
Imports BytescoutImageToVideo

Module Program

    <MTAThreadAttribute()>
    Sub Main()
        Try
            Dim event1 As ManualResetEvent = New ManualResetEvent(False)
            Dim event2 As ManualResetEvent = New ManualResetEvent(False)

            ThreadPool.QueueUserWorkItem(AddressOf ThreadProc1, event1)

            ' (!) Start the second thread with a delay because codecs are locked during the video initialization.
            Thread.Sleep(1000)

            ThreadPool.QueueUserWorkItem(AddressOf ThreadProc2, event2)

            WaitHandle.WaitAll(New WaitHandle() {event1, event2})

        Catch ex As Exception
            Console.WriteLine("Erorr: {0}", ex.Message)
        End Try

        Console.WriteLine("Done. Press enter key to exit...")
        Console.ReadLine()
    End Sub

    Private Sub ThreadProc1(ByVal state As Object)
        Dim event1 As ManualResetEvent = CType(state, ManualResetEvent)

        Try
            Dim converter As ImageToVideo = New ImageToVideo()
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"
            Dim x As Array = [Enum].GetValues(GetType(PanZoomEffectType))

            For Each file As String In Directory.GetFiles(".\images")
                Dim slide As Slide = converter.AddImageFromFileName(file)
                slide.Duration = 3000
                slide.PanZoomEffect = CType(x.GetValue((New Random()).[Next](8)), PanZoomEffectType)
                slide.InEffect = TransitionEffectType.teFade
                slide.InEffectDuration = 250
                slide.OutEffect = TransitionEffectType.teFade
                slide.OutEffectDuration = 250
            Next

            converter.OutputVideoFileName = "result1.wmv"
            converter.OutputWidth = 800
            converter.OutputHeight = 600
            converter.RunAndWait()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
            Console.WriteLine("First thread finished.")
        Catch e As Exception
            Console.WriteLine("Error: " & e.ToString())
        Finally
            event1.Set()
        End Try
    End Sub

    Private Sub ThreadProc2(ByVal state As Object)
        Dim event2 As ManualResetEvent = CType(state, ManualResetEvent)

        Try
            Dim converter As ImageToVideo = New ImageToVideo()
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"
            Dim x As Array = [Enum].GetValues(GetType(PanZoomEffectType))

            For Each file As String In Directory.GetFiles(".\images")
                Dim slide As Slide = converter.AddImageFromFileName(file)
                slide.Duration = 3000
                slide.PanZoomEffect = CType(x.GetValue((New Random()).[Next](8)), PanZoomEffectType)
                slide.InEffect = TransitionEffectType.teFade
                slide.InEffectDuration = 250
                slide.OutEffect = TransitionEffectType.teFade
                slide.OutEffectDuration = 250
            Next

            converter.OutputVideoFileName = "result2.wmv"
            converter.OutputWidth = 640
            converter.OutputHeight = 480
            converter.RunAndWait()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
            Console.WriteLine("Second thread finished.")
        Catch e As Exception
            Console.WriteLine("Error: " & e.ToString())
        Finally
            event2.Set()
        End Try
    End Sub

End Module
