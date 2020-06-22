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


Imports Bytescout.BarCodeReader

Class Program

    Friend Shared Sub Main(args As String())

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
        ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
        ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
        reader.BarcodeTypesToFind.All1D = True

        ' Input barcode document
        Dim inputDocument As String = "example.pdf"

        Console.WriteLine("First Attempt - Reading barcodes from PDF document...")
        Dim foundBarcodesFirstAttempt As FoundBarcode() = GetBarcodes(reader, inputDocument)

        If Not foundBarcodesFirstAttempt Is Nothing AndAlso foundBarcodesFirstAttempt.Length > 0 Then
            DisplayBarcodeResult(foundBarcodesFirstAttempt)
        Else
            Console.WriteLine("No Barccodes found...")
            ' Try Second attempt
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Second Attempt - Reading barcodes from PDF document...")

            ' Change PDF rendering resolution
            reader.PDFRenderingResolution = 150

            ' Get found barcodes 
            Dim foundBarcodesSecondAttempt As FoundBarcode() = GetBarcodes(reader, inputDocument)

            If Not foundBarcodesSecondAttempt Is Nothing AndAlso foundBarcodesSecondAttempt.Length > 0 Then
                DisplayBarcodeResult(foundBarcodesSecondAttempt)
            End If
        End If

        ' Cleanup
        reader.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.ReadKey()

    End Sub

    ''' <summary>
    ''' Get Barcodes
    ''' </summary>
    Shared Function GetBarcodes(reader As Reader, inputDocument As String) As FoundBarcode()
        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 
        Return reader.ReadFrom(inputDocument)
    End Function

    ''' <summary>
    ''' Display found barcodes
    ''' </summary>
    Shared Sub DisplayBarcodeResult(foundBarcodes As FoundBarcode())
        For Each barcode As FoundBarcode In foundBarcodes
            Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
        Next
    End Sub

End Class
