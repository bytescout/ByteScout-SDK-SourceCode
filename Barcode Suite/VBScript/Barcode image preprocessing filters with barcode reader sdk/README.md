## barcode image preprocessing filters with barcode reader sdk in VBScript using ByteScout Barcode Suite

### How to apply ByteScout Barcode Suite for barcode image preprocessing filters with barcode reader sdk in VBScript

We regularly create and update our sample code library so you may quickly learn barcode image preprocessing filters with barcode reader sdk and the step-by-step process in VBScript. ByteScout Barcode Suite was made to help with barcode image preprocessing filters with barcode reader sdk in VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

VBScript code snippet like this for ByteScout Barcode Suite works best when you need to quickly implement barcode image preprocessing filters with barcode reader sdk in your VBScript application. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Check these VBScript sample code examples to see if they acknowledge to your needs and requirements for the project.

Visit our website to get a free trial version of ByteScout Barcode Suite. Free trial contains many of source code samples to help you with your VBScript project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****TestBarcodeReading.vbs:**
    
```
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

```

<!-- code block end -->