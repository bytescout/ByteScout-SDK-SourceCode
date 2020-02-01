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
Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets


Module Module1

    Sub Main()
	' Create new watermarker
        Dim waterMarker As New Watermarker()
	' Create new preset
        Dim preset As New TextFitsPage()
	' Create new string
        Dim inputFilePath As String
	' Create new string
        Dim outputFilePath As String

        ' Set input file path
        inputFilePath = "my_sample_image.jpg"
        ' Set output file path
        outputFilePath = "my_sample_output.jpg"

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Add image to apply watermarks to
        waterMarker.AddInputFile(inputFilePath, outputFilePath)

        ' Set preset text
        preset.Text = "Bytescout Watermarking"

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Apply watermarks
        waterMarker.Execute()

        ' Open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
