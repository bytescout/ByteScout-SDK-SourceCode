'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports BytescoutImageToVideo

Module Module1

    Sub Main()

        Try

            Console.WriteLine("Converting JPG slides to video, please wait...")

            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As ImageToVideo = New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Enable transition effects for the first and last slide
            converter.UseInEffectForFirstSlide = True
            converter.UseOutEffectForLastSlide = True

            ' Add images and set slide durations and transition effects
            Dim slide As Slide
            slide = converter.AddImageFromFileName("..\..\..\..\slide1.jpg")
            slide.Duration = 3000 ' 3000ms = 3s
            slide.InEffect = TransitionEffectType.teFade
            slide.OutEffect = TransitionEffectType.teFade

            slide = converter.AddImageFromFileName("..\..\..\..\slide2.jpg")
            slide.Duration = 3000
            slide.InEffect = TransitionEffectType.teWipeLeft
            slide.OutEffect = TransitionEffectType.teWipeRight

            slide = converter.AddImageFromFileName("..\..\..\..\slide3.jpg")
            slide.Duration = 3000
            slide.InEffect = TransitionEffectType.teWipeLeft
            slide.OutEffect = TransitionEffectType.teWipeRight

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Set output video file name
            converter.OutputVideoFileName = "result.webm"

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            ' Open the result video file in default webm player
            Process.Start("result.webm")

            Console.WriteLine("Done. Press any key to continue...")
            Console.ReadKey()

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try

    End Sub

End Module
