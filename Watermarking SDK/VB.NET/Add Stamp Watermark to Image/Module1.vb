'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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

        For Each stampType As String In Presets.Stamp.PresetImages
            ' Set output file title
            Dim outputFilePath As String = "my_sample_output_" + stampType + ".jpg"

            ' Add image to apply watermarks to
            waterMarker.AddInputFile(inputFilePath, outputFilePath)

            ' Set output directory
            waterMarker.OutputOptions.OutputDirectory = "."

            ' Create new watermark
            Dim preset As New Presets.Stamp()

            ' Set stamp type
            preset.ImageFile = stampType

            ' Add watermark to watermarker
            waterMarker.AddWatermark(preset)

            ' Apply watermarks
            waterMarker.Execute()

            ' Clear all settings
            waterMarker.Clear()
        Next

    End Sub

End Module
