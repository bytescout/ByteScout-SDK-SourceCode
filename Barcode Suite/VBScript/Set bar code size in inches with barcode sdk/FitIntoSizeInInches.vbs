'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set symbology to PDF417
bc.Symbology = 13 ' 13 = PDF417 barcode type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying a square the barcode will be fitted into 5x2 inches square
' Last parameter is the Measure Unit: Inch (2) Specifies the inch as the unit of measure. 
bc.FitInto_3 5, 2, 2

bc.CutUnusedSpace = False ' you can set it to True to cut unused space

bc.SaveImage "result.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing
