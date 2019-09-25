## How to search barcodes in documents and write results to file with barcode reader sdk in VBScript using ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to search barcodes in documents and write results to file with barcode reader sdk in VBScript

Sample source code below will display you how to manage a complex task like search barcodes in documents and write results to file with barcode reader sdk in VBScript. What is ByteScout Data Extraction Suite? It is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to search barcodes in documents and write results to file with barcode reader sdk in your VBScript application.

This prolific sample source code in VBScript for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to search barcodes in documents and write results to file with barcode reader sdk. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample VBScript codes.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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