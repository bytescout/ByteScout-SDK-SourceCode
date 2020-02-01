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


Imports System.Drawing

Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Module Module1

    Sub Main()
        ' Create Watermarker instance
        Dim waterMarker As New Watermarker()

        Dim inputFilePath As String
        Dim outputFilePath As String

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Set input file name
        inputFilePath = "my_sample_image.jpg"
        ' Set output file title
        outputFilePath = "my_sample_output.jpg"

        ' Add image to apply watermarks to
        waterMarker.AddInputFile(inputFilePath, outputFilePath)

        ' Create new watermark
        Dim preset As New LogoImage()

        ' Select image file
        preset.ImageFile = "mylogo.png"

        ' Set text transparency
        preset.Transparency = 40

        ' Set watermark placement
        preset.Placement = WatermarkPlacement.MiddleCenter

        ' Set scale
        preset.Scale = 2.0F

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Set output format
        waterMarker.OutputOptions.ImageFormat = OutputFormats.JPEG

        ' Apply watermarks
        waterMarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
