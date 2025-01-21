'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections.Generic
Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Module Tutorial
    Sub Main(ByVal args As String())
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


        ' Allow resize
        waterMarker.OutputOptions.Resize = True

        ' Set resize type to percentage
        waterMarker.OutputOptions.ResizeType = ResizeType.Actual

        ' Set units type
        waterMarker.OutputOptions.ResizeActualUnits = ActualSizeUnits.inches

        ' Set image width
        waterMarker.OutputOptions.ResizeWidthInUnits = 1.5F

        ' Set image height
        waterMarker.OutputOptions.ResizeHeightInUnits = 2.0F

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Apply watermarks
        waterMarker.Execute()


        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)
    End Sub
End Module
