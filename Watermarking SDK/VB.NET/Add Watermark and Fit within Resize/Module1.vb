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

        ' Allow resize
        waterMarker.OutputOptions.Resize = True

        ' Allow to enlarge image
        waterMarker.OutputOptions.DontEnlargeSmallImages = False

        ' Set resize type to pixels
        waterMarker.OutputOptions.ResizeType = ResizeType.Pixels

        ' Fit to width
        waterMarker.OutputOptions.ResizeFitWithin = FitWithin.WidthOnly

        ' Set width
        waterMarker.OutputOptions.ResizeWidthInPixels = 600

        ' Set height
        waterMarker.OutputOptions.ResizeHeightInPixels = 20


        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."


        ' Apply watermarks
        waterMarker.Execute()

        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)
    End Sub

End Module
