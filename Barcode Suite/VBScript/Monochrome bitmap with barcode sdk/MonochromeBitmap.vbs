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

' set barcode type (symbology)
bc.Symbology = 16 ' 16 = QR Code

' set monochrome output 
bc.ProduceMonochromeImages = True

' set barcode value to encode
bc.Value = "012345"

' save image to file
bc.SaveImage "result.bmp" 

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.bmp", 1, false
Set shell = Nothing
