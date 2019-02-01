'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections.Generic
Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

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

        ' Allow to override resolution
        waterMarker.OutputOptions.OverrideResolution = True

        ' Set vertical resolution
        waterMarker.OutputOptions.VerticalResolution = 300

        ' Set horizontal resolution
        waterMarker.OutputOptions.HorizontalResolution = 300


        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."


        ' Apply watermarks
        waterMarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)
    End Sub

End Module
