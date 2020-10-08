## How to decode page by page from TIFF in VBScript using ByteScout BarCode Reader SDK ByteScout BarCode Reader SDK is the barcode decoder with support for code 39, code 128, QR Code, Datamatrix, GS1, PDF417 and all other popular barcodes. Can read barcodes from images, pdf, tiff documents and live web camera. Supports noisy and damaged documents, can split and merge pdf and tiff documents based on barcodes. Can export barcode decoder results to XML, JSON, CSV and into custom data structures.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### **BarcodesFromTIFF.vbs:**
    
```
'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
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


```

<!-- code block end -->    

<!-- code block begin -->

##### **run.bat:**
    
```
REM running from the command line
cscript.exe BarcodesFromTIFF.vbs multipage.tif
pause
```

<!-- code block end -->