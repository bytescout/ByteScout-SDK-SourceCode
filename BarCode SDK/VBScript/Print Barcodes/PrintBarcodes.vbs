'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates generation and printing of multiple barcodes

' Prepare Barcode object that will generate barcodes for printing
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
barcode.Symbology = 9 ' EAN13
barcode.DrawCaption = True
barcode.BarHeight = 50
barcode.DrawQuietZones = False
barcode.SetMargins 20, 20, 20, 20, 0

' Prepare BarcodePrinter object
Set barcodePrinter = CreateObject("Bytescout.BarCode.BarcodePrinter")
' Set printer paper size
barcodePrinter.SetPaperSize "A4" 
' Set number of barcodes on a page: 4 lines of 4 barcodes per line = 16 barcodes per page
barcodePrinter.SetGrid 4, 4
' Fit barcodes into the grid cell size
barcodePrinter.FitBarcodesIntoGrid = True
' Set some optional printing params
'barcodePrinter.SetMargins 20, 0, 0, 20
'barcodePrinter.Copies = 2
'barcodePrinter.Collate = True
'barcodePrinter.Color = False


' Generate 25 barcode values in EAN13 format "5901234NNNNN"
' and add them to the BarcodePrinter
For i = 1 To 25
    value = "5901234" + LeftPadding(CStr(i), "0", 5)
    barcodePrinter.AddBarcodeValue value
Next


' Print barcodes to the specified printer 
barcodePrinter.Print (barcode), "Microsoft Print to PDF"


' Function that returns a new string of a specified length in which the beginning of the current string 
' is padded with a specified character.
Private Function LeftPadding(str, paddingChar, length)
    LeftPadding = String(length - Len(str), paddingChar) & str
End Function
