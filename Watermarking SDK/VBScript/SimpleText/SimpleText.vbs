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
outputFilePath = "result.jpg"

' Add image to apply watermarks to
watermarker.AddInputFile_2 inputFilePath, outputFilePath

' Create new watermark
Set preset = CreateObject("Bytescout.Watermarking.Presets.SimpleText")

' Set watermark text
preset.Text = "Bytescout Watermarking"

' Set watermark font
Set font = CreateObject("Bytescout.Watermarking.WatermarkFont")
font.Name = "Arial"
font.Style = 1 ' Bold
font.SizeType = 1 ' Points
font.Size = 18
preset.Font = font

' Set watermark text color
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
