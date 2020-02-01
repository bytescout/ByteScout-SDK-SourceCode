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


Imports System.Diagnostics
Imports Bytescout.BarCodeReader

Class Program
    Friend Shared Sub Main(args As String())

        Using reader_default As New Reader("demo", "demo")

            ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
            ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
            ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
            reader_default.BarcodeTypesToFind.All1D = True

            ' Using StopWatch to track operation time
            Dim sw_reader_default As New Stopwatch()
            sw_reader_default.Start()

            Console.WriteLine("Reading barcodes from PDF document with default resolution ..." + Environment.NewLine)

            Dim barcodes As FoundBarcode() = reader_default.ReadFrom("example.pdf")

            For Each barcode As FoundBarcode In barcodes
                Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
            Next

            sw_reader_default.Stop()

            Console.WriteLine(Environment.NewLine + "ELAPSED TIME (in milliseconds): " + CStr(sw_reader_default.ElapsedMilliseconds))

        End Using

        Console.WriteLine(Environment.NewLine + "===============" + Environment.NewLine)

        Using reader_with_filter As New Reader("demo", "demo")

            ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
            ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
            ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
            reader_with_filter.BarcodeTypesToFind.All1D = True

            ' Setting PDF rendering resolution to 150
            reader_with_filter.PDFRenderingResolution = 150

            ' Using StopWatch to track operation time
            Dim sw_reader_optimized As New Stopwatch()
            sw_reader_optimized.Start()

            Console.WriteLine("Reading barcodes from PDF document with filter set for resolution ..." + Environment.NewLine)

            Dim barcodes As FoundBarcode() = reader_with_filter.ReadFrom("example.pdf")

            For Each barcode As FoundBarcode In barcodes
                Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
            Next

            sw_reader_optimized.Stop()

            Console.WriteLine(Environment.NewLine + "ELAPSED TIME (in milliseconds): " + CStr(sw_reader_optimized.ElapsedMilliseconds))

        End Using


        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.ReadKey()
    End Sub
End Class
