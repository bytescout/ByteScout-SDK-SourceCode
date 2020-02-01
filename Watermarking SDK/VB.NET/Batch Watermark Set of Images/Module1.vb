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

        ' Add images to apply watermarks to
        waterMarker.AddInputFile("my_sample_image2.jpg", "my_sample_image2_output.jpg")
        waterMarker.AddInputFile("my_sample_image3.jpg", "my_sample_image3_output.jpg")

        ' Create new watermark
        Dim preset As New Presets.TextFitsPage()

        ' Set watermark text
        preset.Text = "Bytescout Watermarking"

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Apply watermarks
        waterMarker.Execute()

    End Sub

End Module
