'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


if (WScript.Arguments.Count < 1) Then

	MsgBox "Run with the file name as the argument" & vbCRLF & vbCRLF & "ReadUSPSTrayLabel.vbs <InputFileName>"
 	WScript.Quit 0
End If

WScript.Echo "Reading barcode(s) from image " & WScript.Arguments(0)

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
' "USPS Tray Label" barcode type is the same as "Interleaved 2 of 5"
reader.BarcodeTypesToFind.Interleaved2of5 = True

reader.ReadFromFile WScript.Arguments(0)

For i = 0 To reader.FoundCount - 1 

	' Write to console
	WScript.Echo "Found barcode with type '" & reader.GetFoundBarcodeType(i) & "' and value '" & reader.GetFoundBarcodeValue(i) & "'"
Next

' Cleanup
Set reader = Nothing
