'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.QRCode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Enable generation of GS1 version of QR Code
barcode.IsGS1 = True

' Set value that is formatted according to GS1 specification
barcode.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811"

' Save barcode image to file
barcode.SaveImage("result.png")

' Open the image in default image viewer (for demo purpose)
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set barcode = Nothing
