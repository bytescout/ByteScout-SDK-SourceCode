'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports BytescoutImageToVideo

Module Module1

    Sub Main()

        Try
            Console.WriteLine("Converting JPG slides to video, 70 advanced 3D effects, please wait...")

            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As ImageToVideo = New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Enable transition effects for the first first slide
            converter.UseInEffectForFirstSlide = True

            converter.Slides.DefaultSlideDuration = 1000
            converter.Slides.DefaultSlideEffectDuration = 500

            Dim bChangeSlide As Boolean = True ' temporary variable to change slides

            Dim i As Integer

            ' now try all 67 standard transition effects from 68 to 140
            For i = 68 To 140

                ' Add slide image, set the duration

                Dim slide As Slide

                If (Not bChangeSlide) Then
                    slide = converter.AddImageFromFileName("..\..\..\..\slide1.jpg")
                Else
                    slide = converter.AddImageFromFileName("..\..\..\..\slide2.jpg")
                End If

                bChangeSlide = Not bChangeSlide ' switch to use another slide next tim

                slide.InEffect = i ' effect index

            Next

            ' Set output video size
            converter.OutputWidth = 320
            converter.OutputHeight = 240

            ' Set output video file name
            converter.OutputVideoFileName = "result.wmv"

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            ' Open the result video file in default media player
            Process.Start("result.wmv")

            Console.WriteLine("Done. Press any key to continue...")
            Console.ReadKey()

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try

    End Sub

End Module
