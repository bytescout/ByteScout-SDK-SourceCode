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
        Dim watermarker As New Watermarker()

        Dim inputFilePath As String
        Dim outputFilePath As String

        ' Initialize library
        watermarker.InitLibrary("demo", "demo")

        ' Set input file name
        inputFilePath = "my_sample_image.jpg"
        ' Set output file title
        outputFilePath = "my_sample_output.png"

        ' Add image to apply watermarks to
        watermarker.AddInputFile(inputFilePath, outputFilePath)

        ' Create new watermark
        Dim preset As New TextAnnotation()

        ' Set radius of the corners of the rectangle
        preset.Radius = 30

        ' Set text
        preset.Text = "Date and Time: {{LOCAL_DATE_LONG}} {{LOCAL_TIME}}" + vbCrLf
        preset.Text += "Path: {{DIRECTORY}}" + vbCrLf
        preset.Text += "Filename: {{FILENAME}}" + vbCrLf
        preset.Text += "Manufacturer: {{EXIF_EQUIPMENT_MANUFACTURER}}" + vbCrLf
        preset.Text += "Model: {{EXIF_EQUIPMENT_MODEL}}" + vbCrLf
        preset.Text += "Software: {{EXIF_SOFTWARE_USED}}" + vbCrLf
        preset.Text += "Date/Time: {{EXIF_ORIGINAL_DATE}}" + vbCrLf
        preset.Text += "Exposure Time: {{EXIF_EXPOSURE_TIME}} sec" + vbCrLf
        preset.Text += "Exposure Program: {{EXIF_EXPOSURE_PROGRAM}}" + vbCrLf
        preset.Text += "Exposure Bias: {{EXIF_EXPOSURE_BIAS}} EV" + vbCrLf
        preset.Text += "F Number: F {{EXIF_F_NUMBER}}" + vbCrLf
        preset.Text += "ISO Speed Rating: ISO {{EXIF_ISO_SPEED}}" + vbCrLf
        preset.Text += "Flash: {{EXIF_FLASH}}" + vbCrLf
        preset.Text += "Focal Length: {{EXIF_FOCAL_LENGTH}} mm" + vbCrLf
        preset.Text += "Metering Mode: {{EXIF_METERING_MODE}}" + vbCrLf

        ' Set watermark font
        preset.Font = New WatermarkFont("Tahoma", FontStyle.Regular, FontSizeType.Points, 7)

        ' Add watermark to watermarker
        watermarker.AddWatermark(preset)

        ' Set output directory
        watermarker.OutputOptions.OutputDirectory = "."

        ' Set output format
        watermarker.OutputOptions.ImageFormat = OutputFormats.PNG

        ' Apply watermarks
        watermarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)

    End Sub

End Module
