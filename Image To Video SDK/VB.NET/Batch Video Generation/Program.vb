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

Class Program
	Friend Shared Sub Main(args As String())
		Try
            Console.WriteLine("Converting JPG slides to video, please wait...")

			For i As Integer = 0 To 4
				' Create BytescoutImageToVideoLib.ImageToVideo object instance
				Dim converter As New ImageToVideo()

				' Activate the component
				converter.RegistrationName = "demo"
				converter.RegistrationKey = "demo"

				' Set output video size
				converter.OutputWidth = 640
				converter.OutputHeight = 480

				' Add images and set duration and effects for every slide
				Dim slide As Slide
				slide = converter.AddImageFromFileName("..\..\..\..\slide1.jpg")
				slide.Duration = 3000
				' 3000ms = 3s
                slide.InEffect = TransitionEffectType.teFade
                slide.OutEffect = TransitionEffectType.teFade
				Release(slide)
				' useful to decrease memory consumption during the batch conversion but not critical
				slide = converter.AddImageFromFileName("..\..\..\..\slide2.jpg")
				slide.Duration = 3000
                slide.InEffect = TransitionEffectType.teWipeLeft
                slide.OutEffect = TransitionEffectType.teWipeRight
				Release(slide)

				slide = converter.AddImageFromFileName("..\..\..\..\slide3.jpg")
				slide.Duration = 3000
                slide.InEffect = TransitionEffectType.teWipeLeft
                slide.OutEffect = TransitionEffectType.teWipeRight
				Release(slide)

				' Set output video file name
				converter.OutputVideoFileName = "result" & i & ".wmv"

				' Run the conversion
				converter.RunAndWait()

				Console.WriteLine("Created " + converter.OutputVideoFileName)

				' CRITICAL! 
				' Releases all resources consumed during the conversion
				Release(converter)
			Next

			Console.WriteLine("Done. Press any key to continue..")
			Console.ReadKey()
		Catch e As Exception
			Console.WriteLine("Error: " & e.ToString())
			Console.WriteLine(vbLf & "Press any key to exit")
			Console.ReadKey()
		End Try
	End Sub

	Private Shared Sub Release(o As Object)
		Try
			System.Runtime.InteropServices.Marshal.ReleaseComObject(o)
		Catch
		Finally
			o = Nothing
		End Try
	End Sub
End Class
