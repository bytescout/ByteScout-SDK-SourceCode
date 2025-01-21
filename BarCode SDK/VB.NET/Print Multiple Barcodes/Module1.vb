'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.BarCode

' This example demonstrates generation and printing of multiple barcodes.

Module Module1

    Sub Main()

        ' Prepare Barcode object that will generate barcodes for printing
        Dim barcode = New Barcode()
        barcode.RegistrationName = "demo"
        barcode.RegistrationKey = "demo"
        barcode.Symbology = SymbologyType.EAN13
        barcode.DrawCaption = True
        barcode.BarHeight = 50
        barcode.DrawQuietZones = False
        barcode.Margins = New Margins(20, 20, 20, 20)

        ' Prepare BarcodePrinter object
        Dim barcodePrinter = New BarcodePrinter()
        ' Set printer paper size
        barcodePrinter.SetPaperSize("A4")
        ' Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
        barcodePrinter.SetGrid(4, 4)
        ' Fit barcodes into the grid cell size
        barcodePrinter.FitBarcodesIntoGrid = True
        ' Set some optional printing params
        'barcodePrinter.SetMargins(20, 0, 0, 20)
        'barcodePrinter.Copies = 2
        'barcodePrinter.Collate = True
        'barcodePrinter.Color = False

        ' Generate 25 barcode values in EAN13 format "5901234NNNNN"
        ' and add them to the BarcodePrinter
        For i As Integer = 1 To 25
            Dim value = "5901234" + CStr(i).PadLeft(5, "0")
            barcodePrinter.AddBarcodeValue(value)
        Next

        ' Print barcodes to the specified printer 
        barcodePrinter.Print(barcode, "Microsoft Print to PDF")

    End Sub

End Module
