'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


if WScript.Arguments.Count < 1 Then
    WScript.Echo "Set barcode value as command line parameter: " & vbCRLF & vbCRLF & "GenerateQRCode.vbs <value>"
    WScript.Quit 0
End If

' Create and activate QRCode instance
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' Set barcode type
barcode.Symbology = 16 ' 16 = QRCode symbology

' Set barcode value from the command line parameter
barcode.Value = WScript.Arguments(0)

' Save barcode image to file
barcode.SaveImage("result.png")

Set barcode = Nothing
