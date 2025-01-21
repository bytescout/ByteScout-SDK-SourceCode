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

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
bc.BarcodeTypesToFind.SetAll1D()

' Reading barcode from PDF
bc.ReadFromFile "example.pdf"

' Iterate throuhg all found barcodes
For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode on page #" & CStr(bc.GetFoundBarcodePage(i)) & " with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Next

Set bc = Nothing
