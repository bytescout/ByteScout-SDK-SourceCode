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


Imports System.Diagnostics
Imports System.Threading
Imports BytescoutImageToVideo

Class Program
    Friend Shared Sub Main(ByVal args As String())

        Console.WriteLine("Converting JPG slides to video, please wait...")

        ' Create BytescoutImageToVideoLib.ImageToVideo object instance
        Dim converter As New ImageToVideo()

        ' Activate the component
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' set default "in" effect for slides (you can also set effects for each single slide)
        converter.Slides.DefaultSlideInEffect = 1 ' teFadeIn (1) - fades in effect for slides transition
        converter.Slides.DefaultSlideInEffectDuration = 500 ' 500 msec for in effect

        ' Add images and set the duration for every slide
        Dim slide As Slide
        slide = converter.AddImageFromFileName("..\..\..\..\slide1.jpg")
        slide.Duration = 3000 ' 3000ms = 3s
        slide = converter.AddImageFromFileName("..\..\..\..\slide2.jpg")
        slide.Duration = 3000
        slide = converter.AddImageFromFileName("..\..\..\..\slide3.jpg")
        slide.Duration = 3000

        ' Set output video size
        converter.OutputWidth = 640
        converter.OutputHeight = 480

        ' Set output video file name
        converter.OutputVideoFileName = "result.wmv"

        Console.WriteLine("Conversion started. Hit a key to abort...")

        ' Run the conversion
        converter.Run()

        ' Show conversion progress:

        Dim i As Integer = 0
        Dim spin As Char() = New Char() {"|"c, "/"c, "-"c, "\"c}

        While Not Console.KeyAvailable AndAlso converter.IsRunning
            Dim progress As Single = converter.ConversionProgress
            Console.WriteLine([String].Format("Converting images {0}% {1}", progress, spin(i)))
            Console.CursorTop -= 1
            i = i + 1
            i = i Mod 4
            Thread.Sleep(50)
        End While

        If converter.IsRunning Then
            converter.Stop()
            Console.WriteLine("Conversion aborted by user.")
        Else
            Console.WriteLine("Conversion competed successfully.")
        End If

        ' Release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

        ' Open the result video file in default media player
        Process.Start("result.wmv")

        Console.WriteLine()
        Console.WriteLine(vbLf & "Press any key to exit...")
        Console.ReadKey()

    End Sub
End Class
