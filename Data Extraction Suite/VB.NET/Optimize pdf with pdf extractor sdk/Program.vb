'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            Using docOptimizer As New DocumentOptimizer("demo", "demo")

                'Set Optimization Options
                Dim OptimizationOptions = New OptimizationOptions

                'This will resize high resolution images
                OptimizationOptions.ResampleImages = True

                ''Set image optimization format
                'OptimizationOptions.ImageOptimizationFormat = ImageOptimizationFormat.JPEG

                ''Control Optimized image quality, for further fine grained control
                'OptimizationOptions.JPEGQuality = 10

                'Perform Optimization
                docOptimizer.OptimizeDocument("sample.pdf", "sample_optimized.pdf", OptimizationOptions)

                ''Get Optimized file info
                Dim fileInfo_Sample = New System.IO.FileInfo("sample.pdf")
                Dim fileInfo_SampleOptimized = New System.IO.FileInfo("sample_optimized.pdf")

                'Write Stats
                Console.WriteLine("Source File Size: " + fileInfo_Sample.Length.ToString() + " bytes")
                Console.WriteLine("Source File Optimized to Size: " + fileInfo_SampleOptimized.Length.ToString() + " bytes")

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
