'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


'*** Prepare Spreadsheet object
Set spreadsheet = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
spreadsheet.RegistrationName = "demo"
spreadsheet.RegistrationKey = "demo"
' Load Excel document
spreadsheet.LoadFromFile("test.xlsx")
' Take the first worksheet
Set worksheet = spreadsheet.Worksheet(0)

'*** Prepare Barcode object
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
' Set barcode type to PDF417
barcode.Symbology = 13 ' 13 means PDF417 barcode
' Set higher resoultion (300 is good for printing)
barcode.ResolutionX = 300
barcode.ResolutionY = 300
' Show barcode caption (remove these lines if you don't need it)
barcode.DrawCaption = True
barcode.DrawCaptionFor2DBarcodes = True

' Run through worksheet rows
For i = 0 To worksheet.NotEmptyRowMax - 1
	' Get barcode value from first worksheet column 
	barcode.Value = worksheet.Item(i, 0).ValueAsString
	' Fit barcode into 40x15 mm rectangle
	barcode.FitInto_3 40, 15, 4 ' 4 means millimeter units
	' Save barcode image to file
	barcode.SaveImage("barcode" & i & ".png")
Next

' Release objects
Set spreadsheet = Nothing
Set barcode = Nothing
