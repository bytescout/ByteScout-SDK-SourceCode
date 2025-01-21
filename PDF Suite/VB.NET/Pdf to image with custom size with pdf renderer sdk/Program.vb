'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Generic
Imports Bytescout.PDFRenderer


Class Program
    Friend Shared Sub Main(args As String())

        ' Specify Image Generation Inputs
        Dim imageGenerationInputs As New ImageGenerationInputs()

        imageGenerationInputs.AddCustomSize(width:=320, height:=420)
        imageGenerationInputs.AddCustomSize(width:=600, height:=800)

        imageGenerationInputs.EnableSaveAsPng = True
        imageGenerationInputs.EnableSaveAsJpeg = True
        imageGenerationInputs.EnableSaveAsTiff = True

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        ' Specify Rendering Options to fine tune output generation
        Dim RenderingOptions As New RenderingOptions()
        RenderingOptions.TIFFCompression = TIFFCompression.None
        RenderingOptions.VectorSmoothingMode = GraphicsTransformationQuality.HighQuality

        ' Loop through each custom size specified
        For Each itmCustomSize As KeyValuePair(Of Int32, Int32) In imageGenerationInputs.CustomSizes

            ' Loop through all pages
            For pageIndex As Integer = 0 To renderer.GetPageCount() - 1

                ' Perform save as PNG, if specified
                If imageGenerationInputs.EnableSaveAsPng Then

                    Dim pngImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.png"

                    ' Save png image per page, per custom size
                    renderer.Save(
                            destFileName:=pngImageName,
                            outputFormat:=RasterImageFormat.PNG,
                            pageIndex:=pageIndex,
                            width:=itmCustomSize.Key,
                            height:=itmCustomSize.Value,
                            renderingOptions:=RenderingOptions
                            )

                    Console.WriteLine(pngImageName + " - Generated")

                End If

                ' Perform save as JPG, if specified
                If imageGenerationInputs.EnableSaveAsJpeg Then

                    Dim jpgImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.jpg"

                    ' Save jpg image per page, per custom size
                    renderer.Save(
                            destFileName:=jpgImageName,
                            outputFormat:=RasterImageFormat.JPEG,
                            pageIndex:=pageIndex,
                            width:=itmCustomSize.Key,
                            height:=itmCustomSize.Value,
                            renderingOptions:=RenderingOptions
                            )

                    Console.WriteLine(jpgImageName + " - Generated")

                End If

            Next

            ' Perform save as TIFF, if specified
            If imageGenerationInputs.EnableSaveAsTiff Then

                Dim tiffImageName As String = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}.tiff"

                ' Save tiff image per page, per custom size
                renderer.SaveMultipageTiff(
                        destFileName:=tiffImageName,
                        startPageIndex:=0,
                        endPageIndex:=renderer.GetPageCount() - 1,
                        width:=itmCustomSize.Key,
                        height:=itmCustomSize.Value,
                        renderingOptions:=RenderingOptions)

                Console.WriteLine(tiffImageName + " - Generated")

            End If

        Next


        ' Cleanup
        renderer.Dispose()

        Console.ReadLine()

    End Sub

End Class


Class ImageGenerationInputs

#Region "Constructors"

    Public Sub New()
        CustomSizes = New List(Of KeyValuePair(Of Integer, Integer))()
        EnableSaveAsPng = True
    End Sub

#End Region

#Region "Properties"

    Public Property CustomSizes As List(Of KeyValuePair(Of Int32, Int32))

    Public Property EnableSaveAsPng As Boolean

    Public Property EnableSaveAsJpeg As Boolean

    Public Property EnableSaveAsTiff As Boolean

#End Region

#Region "Methods"

    Public Sub AddCustomSize(ByVal width As Int32, ByVal height As Int32)

        CustomSizes.Add(New KeyValuePair(Of Integer, Integer)(width, height))

    End Sub

#End Region

End Class
