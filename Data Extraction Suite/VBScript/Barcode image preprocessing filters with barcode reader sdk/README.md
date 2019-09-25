## barcode image preprocessing filters with barcode reader sdk in VBScript and ByteScout Data Extraction Suite

### barcode image preprocessing filters with barcode reader sdk in VBScript

An easy to understand guide to learn how to barcode image preprocessing filters with barcode reader sdk in VBScript. ByteScout Data Extraction Suite helps with barcode image preprocessing filters with barcode reader sdk in VBScript. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

Save time on writing and testing code by using the code below and use it in your application. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Further improvement of the code will make it more robust.

Visit our website to get a free trial version of ByteScout Data Extraction Suite. Free trial contains many of source code samples to help you with your VBScript project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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