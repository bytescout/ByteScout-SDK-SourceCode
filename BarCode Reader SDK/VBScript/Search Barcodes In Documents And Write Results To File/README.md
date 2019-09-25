## How to search barcodes in documents and write results to file in VBScript with ByteScout BarCode Reader SDK

### This code in VBScript shows how to search barcodes in documents and write results to file with this how to tutorial

These sample source codes on this page below are demonstrating how to search barcodes in documents and write results to file in VBScript. ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format. It can search barcodes in documents and write results to file in VBScript.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout BarCode Reader SDK for search barcodes in documents and write results to file below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these VBScript sample examples in one or many applications.

Trial version of ByteScout BarCode Reader SDK can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****TestBarcodeReadingFromPDF.vbs:**
    
```
' Create BarCodeReader object
Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit barcode search to PDF417 barcodes only
bc.BarcodeTypesToFind.PDF417 = True

' Create File System object
Set FSO = CreateObject("Scripting.FileSystemObject")

' Get folder object (current folder)
Set objFolder = FSO.GetFolder(".")

' Get file list
Set files = objFolder.Files

' Create output file
Set TS = FSO.CreateTextFile("output.txt")

' Run barcode search for PDF and TIFF files
For Each file in files

	ext = UCase(FSO.GetExtensionName(file))	
	If ext = "PDF" Or ext = "TIF" Then
		bc.ReadFromFile file.Name
		For i = 0 To bc.FoundCount - 1
			' Write found barcode information to output file
			TS.Write("File: """ & file.Name & """ Page " & CStr(bc.GetFoundBarcodePage(i)) & ": Barcode: " & bc.GetFoundBarcodeValue(i)) & vbCRLF
		Next
    End If 
    
Next

TS.Close

Set bc = Nothing
Set TS = Nothing
Set FSO = Nothing

MsgBox "Done! See output.txt with found results"


```

<!-- code block end -->