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

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

bc.AdditionalCaption = "2nd caption"

bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false
Set shell = Nothing


Set bc = Nothing

