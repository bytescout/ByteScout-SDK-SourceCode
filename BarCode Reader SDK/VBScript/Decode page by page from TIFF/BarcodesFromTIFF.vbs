'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Dim ReadFromPages
Dim PageNo

if (WScript.Arguments.Count < 1) Then

	MsgBox "Run with the file name as the argument" & vbCRLF & vbCRLF & "BarcodesFromTIFF.vbs <InputFileName>"
 	WScript.Quit 0
End If

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Limit search to 1-dimensional barcodes only (exclude 2D barcodes to speed up the processing).
' Change to barcodeReader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcode types
' or select specific type, e.g. barcodeReader.BarcodeTypesToFind.PDF417 = True
reader.BarcodeTypesToFind.All1D = True

' Pages from which barcodes to be fetched
ReadFromPages = Array(1, 2, 4, 6)

For Each PageNo In ReadFromPages

	WScript.Echo "Reading barcodes from TIFF page " & PageNo & "..."
	
	' Decoding barcodes from TIFF on page-by-page basis, instead of reading whole page
	reader.ReadFromFilePage WScript.Arguments(0), PageNo - 1
	
	For i = 0 To reader.FoundCount - 1
	
		WScript.Echo "Found barcode, Type: " & reader.GetFoundBarcodeType(i) & ", Value: " & reader.GetFoundBarcodeValue(i) & ", Position: " & _ 
			"[" & reader.GetFoundBarcodeLeft(i) & ", " & reader.GetFoundBarcodeTop(i) & ", " & reader.GetFoundBarcodeWidth(i) & ", " & _
			reader.GetFoundBarcodeHeight(i) & "]"
	Next
Next

