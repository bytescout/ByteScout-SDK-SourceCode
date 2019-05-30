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
            Console.WriteLine("Converting JPG slides to video, please wait...")

            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As ImageToVideo = New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Add images from memory and set the duration for every slide
            Dim slide As Slide
            Dim bytes As Byte()

            bytes = System.IO.File.ReadAllBytes("..\..\..\..\slide1.jpg")
            slide = converter.AddImageFromBuffer(bytes)
            slide.Duration = 3000 ' 3000ms = 3s
            bytes = System.IO.File.ReadAllBytes("..\..\..\..\slide2.jpg")
            slide = converter.AddImageFromBuffer(bytes)
            slide.Duration = 3000
            bytes = System.IO.File.ReadAllBytes("..\..\..\..\slide3.jpg")
            slide = converter.AddImageFromBuffer(bytes)
            slide.Duration = 3000

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Set output video file name
            converter.OutputVideoFileName = "result.wmv"

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            Console.WriteLine("Done. Press any key to continue...")
            Console.ReadKey()

            ' Open the result video file in default media player
            Process.Start("result.wmv")

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try

    End Sub

End Module
