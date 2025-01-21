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
Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Class Program
	Friend Shared Sub Main(args As String())
		' Create Watermarker instance
		Dim waterMarker As New Watermarker()

		' Initialize library
		waterMarker.InitLibrary("demo", "demo")

		' Add images to apply watermarks to
		waterMarker.AddInputFile("image1.jpg", "image1_watermarked.jpg")
		waterMarker.AddInputFile("image2.jpg", "image2_watermarked.jpg")
		waterMarker.AddInputFile("image3.jpg", "image3_watermarked.jpg")

		' Create new watermark
		Dim preset As New TextFitsPage()

		' Set watermark text
		preset.Text = "My Watermark (c) Me 2010"

		' Add watermark to watermarker
		waterMarker.AddWatermark(preset)

		' Add Progress event handler
		AddHandler waterMarker.Progress, New ProgressEventHandler(AddressOf waterMarker_Progress)

		' Apply watermarks
		waterMarker.Execute()

		Console.WriteLine()
		Console.WriteLine("Hit any key...")
		Console.ReadKey()
	End Sub

	Private Shared Sub waterMarker_Progress(percent As Double, status As String, processedFile As String, ByRef abort As Boolean)
		Dim message As String

        If Not String.IsNullOrEmpty(processedFile) Then
            message = String.Format("{0}: {1}: {2:f02}%", Path.GetFileName(processedFile), status, percent)
        Else
            message = String.Format("{0}: {1:f02}%", status, percent)
        End If

		Console.WriteLine(message.PadRight(Console.WindowWidth))
	End Sub
End Class
