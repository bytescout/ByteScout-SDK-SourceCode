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

Class Program
	Friend Shared Sub Main(args As String())

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
        ' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
        ' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
        reader.BarcodeTypesToFind.All1D = True

        Console.WriteLine("Reading barcodes from PDF document...")

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        Dim barcodes As FoundBarcode() = reader.ReadFrom("example.pdf")

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found barcode with type '{0}' and value '{1}' at page {2} at {3}", barcode.Type, barcode.Value, barcode.Page, barcode.Rect.ToString())
        Next

        ' Cleanup
        reader.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.ReadKey()
	End Sub
End Class
