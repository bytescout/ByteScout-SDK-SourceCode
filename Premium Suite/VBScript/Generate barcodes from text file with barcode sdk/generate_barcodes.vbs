'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


'*** Prepare Barcode object
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
' Set barcode type to PDF417
barcode.Symbology = 16 ' 16 means QR Code
' Set higher resoultion (300 is good for printing)
barcode.ResolutionX = 300
barcode.ResolutionY = 300
' Show barcode caption (remove these lines if you don't need it)
barcode.DrawCaption = True
barcode.DrawCaptionFor2DBarcodes = True

' Open text file containing barcode data and read it line by line
Set fso = CreateObject("Scripting.FileSystemObject")
Set listFile = fso.OpenTextFile("list.txt")
i = 0

do while not listFile.AtEndOfStream 
    ' Set barcode value
    barcode.Value = listFile.ReadLine()
	' Fit barcode into 30x30 mm rectangle
	barcode.FitInto_3 30, 30, 4 ' 4 means millimeter units
	' Save barcode image to file
	barcode.SaveImage("barcode" & i & ".png")
	i = i + 1
loop

Set barcode = Nothing
set fso = Nothing
