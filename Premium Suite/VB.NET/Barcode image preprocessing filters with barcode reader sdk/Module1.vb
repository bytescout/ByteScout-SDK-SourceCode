'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.BarCodeReader

Module Module1
    ''' <summary>
    ''' This exmaple demonstrates the use of image filters to improve the decoding or speed.
    ''' </summary>
    Sub Main()

        Using reader As New Reader("demo", "demo")

            ' Set barcode type to find
            reader.BarcodeTypesToFind.Code128 = True


            ' WORKING WITH LOW CONTRAST BARCODE IMAGES

            ' Add the contrast adjustment for the low contrast image
            reader.ImagePreprocessingFilters.AddContrast(40)

            Console.WriteLine("Image {0}", "low-contrast-barcode.png")

            ' -----------------------------------------------------------------------
            ' NOTE: We can read barcodes from specific page to increase performance .
            ' For sample please refer to "Decoding barcodes from PDF by pages" program.
            ' ----------------------------------------------------------------------- 

            Dim barcodes As FoundBarcode() = reader.ReadFrom("low-contrast-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' WORKING WITH NOISY BARCODE IMAGES

            ' Add the median filter to lower the noise
            reader.ImagePreprocessingFilters.AddMedian()

            Console.WriteLine("Image {0}", "noisy-barcode.png")

            barcodes = reader.ReadFrom("noisy-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' WORKING WITH DENSE AND ILLEGIBLE BARCODES

            ' Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
            reader.ImagePreprocessingFilters.AddScale(2) ' enlarge twice

            Console.WriteLine("Image {0}", "too-dense-barcode.png")

            barcodes = reader.ReadFrom("too-dense-barcode.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()


            ' REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

            ' Add the crop filter to cut off empty margins from the image.
            ' This will not improve the recognition quality but may speed up the processing 
            ' if you enabled multiple barcode types to search. 
            reader.ImagePreprocessingFilters.AddCropDark()

            Console.WriteLine("Image {0}", "barcode-with-large-margins.png")

            barcodes = reader.ReadFrom("barcode-with-large-margins.png")

            If barcodes.Length = 0 Then
                Console.WriteLine("No barcode found!")
            Else
                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found barcode {0} with value '{1}'", barcode.Type, barcode.Value)
                Next
            End If

            reader.ImagePreprocessingFilters.Clear()
            Console.WriteLine()

        End Using

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
