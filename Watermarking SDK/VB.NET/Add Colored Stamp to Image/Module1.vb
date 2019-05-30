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


Imports System.Drawing

Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Module Module1

    Sub Main()
        ' Create Watermarker instance
        Dim watermarker As New Watermarker()

        Dim inputFilePath As String
        Dim outputFilePath As String

        ' Initialize library
        watermarker.InitLibrary("demo", "demo")

        ' Set input file name
        inputFilePath = "my_sample_image.jpg"
        ' Set output file title
        outputFilePath = "my_sample_output.jpg"

        ' Add image to apply watermarks to
        watermarker.AddInputFile(inputFilePath, outputFilePath)

        ' Create new watermark
        Dim preset As New StampFitsPage()

        ' Set stamp type
        preset.ImageFile = "[DONOTCOPY]"

        ' Set stamp color
        preset.ColorizeByColor(Color.Red)

        ' Set stamp transparency
        preset.Transparency = 75

        ' Add watermark to watermarker
        watermarker.AddWatermark(preset)

        ' Set output directory
        watermarker.OutputOptions.OutputDirectory = "."

        ' Apply watermarks
        watermarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
