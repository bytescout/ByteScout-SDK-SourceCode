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

        ' Barcode reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        'If you are reading barcodes from PDF Then you may reduce CPU And RAM load Using the following approach:
        '- instead of using All1D Or All2D barcode types, set it to the specific types you have in your documents Like PDF417 Or Code 39. You may set multiple barcode types if you need to
        '- reduce PDF rendering resolution to 200-150 dpi (depends on your document)
        '- set specific pages to read barcodes from. If you have barcodes on 2 first pages only then change the code to read barcodes from first 2 pages only.
        '- if barcodes are always located / printed in the same corner then also specify the area to read from instead of whole page for scanning

        ' Input filename
        Dim inputFileName As String = "barcode_multipage.pdf"

        ' Set specific barcode type to read
        reader.BarcodeTypesToFind.Code128 = True

        ' Reduce PDF rendering resolution
        reader.PDFRenderingResolution = 150

        ' Set specific area to read from
        reader.CustomAreaLeft = 407
        reader.CustomAreaTop = 494
        reader.CustomAreaHeight = 605
        reader.CustomAreaWidth = 999

        ' Set specific page to read from along with filename
        reader.ReadFromPdfFilePage(inputFileName, 1, 1)

        ' Get all found barcodes
        Dim barcodes As FoundBarcode() = reader.FoundBarcodes

        ' Display found barcodes
        Console.WriteLine("Reading barcode(s) from PDF file...")

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found Barcode - Type: '{0}', Value: '{1}'", barcode.Type, barcode.Value)
        Next

        ' Cleanup
        reader.Dispose()

        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.ReadKey()
	End Sub
End Class
