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


Imports Bytescout.Watermarking

Module Module1

    Sub Main()
        ' Create Watermarker instance
        Dim waterMarker As New Watermarker()

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Set input file name
        Dim inputFilePath As String = "my_sample_image.jpg"
        ' Set output file title
        Dim outputFilePath As String = "my_sample_output.jpg"

        ' Add image to apply watermarks to
        waterMarker.AddInputFile(inputFilePath, outputFilePath)

        ' Create new watermark
        Dim preset As New Presets.StampFitsPage()

        ' Set stamp type
        preset.ImageFile = "[APPROVED]"

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Apply watermarks
        waterMarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
