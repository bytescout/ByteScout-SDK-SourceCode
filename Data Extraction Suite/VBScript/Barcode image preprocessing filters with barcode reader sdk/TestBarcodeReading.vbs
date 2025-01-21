'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This exmaple demonstrates the use of image filters to improve the decoding or speed.

Dim result

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")
reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
reader.BarcodeTypesToFind.Code128 = True


' WORKING WITH LOW CONTRAST BARCODE IMAGES

' Add the contrast adjustment for the low contrast image
reader.ImagePreprocessingFilters.AddContrast(40)

result = result & "Image ""low-contrast-barcode.png""" & vbCRLF

reader.ReadFromFile "low-contrast-barcode.png"

If reader.FoundCount = 0 Then
	result = result & "No barcode found!" & vbCRLF
Else
	For i = 0 To reader.FoundCount - 1
        result = result & "Found barcode with type " & CStr(reader.GetFoundBarcodeType(i)) & " and value """ & reader.GetFoundBarcodeValue(i) & """" & vbCRLF
    Next
End If

reader.ImagePreprocessingFilters.Clear()
result = result & vbCRLF


' WORKING WITH NOISY BARCODE IMAGES

' Add the median filter to lower the noise
reader.ImagePreprocessingFilters.AddMedian()

result = result & "Image ""noisy-barcode.png""" & vbCRLF

reader.ReadFromFile "noisy-barcode.png"

If reader.FoundCount = 0 Then
	result = result & "No barcode found!" & vbCRLF
Else
	For i = 0 To reader.FoundCount - 1
        result = result & "Found barcode with type " & CStr(reader.GetFoundBarcodeType(i)) & " and value """ & reader.GetFoundBarcodeValue(i) & """" & vbCRLF
    Next
End If

reader.ImagePreprocessingFilters.Clear()
result = result & vbCRLF


' WORKING WITH DENSE AND ILLEGIBLE BARCODES

' Add the scale filter to enlarge the barcode to make gaps between bars more distinguishable
reader.ImagePreprocessingFilters.AddScale_2(2) ' enlarge twice

result = result & "Image ""too-dense-barcode.png""" & vbCRLF

reader.ReadFromFile "too-dense-barcode.png"

If reader.FoundCount = 0 Then
	result = result & "No barcode found!" & vbCRLF
Else
	For i = 0 To reader.FoundCount - 1
        result = result & "Found barcode with type " & CStr(reader.GetFoundBarcodeType(i)) & " and value """ & reader.GetFoundBarcodeValue(i) & """" & vbCRLF
    Next
End If

reader.ImagePreprocessingFilters.Clear()
result = result & vbCRLF


' REMOVE EMPTY MARGINS FROM IMAGE TO SPEED UP THE PROCESSING

' Add the crop filter to cut off empty margins from the image.
' This will not improve the recognition quality but may speed up the processing 
' if you enabled multiple barcode types to search. 
reader.ImagePreprocessingFilters.AddCropDark()

result = result & "Image ""barcode-with-large-margins.png""" & vbCRLF

reader.ReadFromFile "barcode-with-large-margins.png"

If reader.FoundCount = 0 Then
	result = result & "No barcode found!" & vbCRLF
Else
	For i = 0 To reader.FoundCount - 1
        result = result & "Found barcode with type " & CStr(reader.GetFoundBarcodeType(i)) & " and value """ & reader.GetFoundBarcodeValue(i) & """" & vbCRLF
    Next
End If

reader.ImagePreprocessingFilters.Clear()
result = result & vbCRLF


Msgbox result


Set reader = Nothing
