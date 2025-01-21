'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Set Barcode Types to Find
bc.BarcodeTypesToFind.PatchCode = True

' Add vertical orientations to analysis
bc.Orientation = 17 Or 2 Or 32768

' Reading barcode from image file
bc.ReadFromFile "PatchCode.png"

' Iterate throuhg all found barcodes
For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Next

Set bc = Nothing
