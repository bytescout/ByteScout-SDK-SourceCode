'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create Watermarker instance
Set watermarker = CreateObject("Bytescout.Watermarking.Watermarker")

' Initialize library
watermarker.InitLibrary "demo", "demo"

' Set input file name
Dim inputFilePath
inputFilePath = "..\sample_image.jpg"
' Set output file title
Dim outputFilePath
outputFilePath = "result.png"

' Add image to apply watermarks to
watermarker.AddInputFile_2 inputFilePath, outputFilePath

' Create new watermark
Set preset = CreateObject("Bytescout.Watermarking.Presets.TextAnnotation")

' Set watermark text with macros.
' Complete list of available macros please see in the SDK documentation.
preset.Text = "Date Time: {{LOCAL_DATE_LONG}} {{LOCAL_TIME}}" & vbCrLf & _
            "Filename: {{FILENAME}}" & vbCrLf & _
            "Manufacturer: {{EXIF_EQUIPMENT_MANUFACTURER}}" & vbCrLf & _
            "Model: {{EXIF_EQUIPMENT_MODEL}}" & vbCrLf & _
            "Software: {{EXIF_SOFTWARE_USED}}" & vbCrLf & _
            "Date/Time: {{EXIF_ORIGINAL_DATE}}" & vbCrLf & _
            "Exposure Time: {{EXIF_EXPOSURE_TIME}} sec" & vbCrLf & _
            "Exposure Program: {{EXIF_EXPOSURE_PROGRAM}}" & vbCrLf & _
            "Exposure Bias: {{EXIF_EXPOSURE_BIAS}} EV" & vbCrLf & _
            "F Number: F {{EXIF_F_NUMBER}}" & vbCrLf & _
            "ISO Speed Rating: ISO {{EXIF_ISO_SPEED}}" & vbCrLf & _
            "Flash: {{EXIF_FLASH}}" & vbCrLf & _
            "Focal Length: {{EXIF_FOCAL_LENGTH}} mm" & vbCrLf & _
            "Metering Mode: {{EXIF_METERING_MODE}}"

' Set watermark font
Set font = CreateObject("Bytescout.Watermarking.WatermarkFont")
font.Name = "Arial"
font.Style = 1 ' Bold
font.SizeType = 1 ' Points
font.Size = 12
preset.Font = font

' Set text color
preset.SetTextColor 255, 255, 255, 255 ' White color in ARGB values

' Add watermark to watermarker
waterMarker.AddWatermark(preset)

' Apply watermarks
waterMarker.Execute()

' open generated image file in default image viewer installed in Windows
Set shell = CreateObject("WScript.Shell")
shell.Run outputFilePath, 1, false
Set shell = Nothing

' Cleanup
Set font = Nothing
Set preset = Nothing
Set watermarker = Nothing
