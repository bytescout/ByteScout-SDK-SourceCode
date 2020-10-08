## How to decode macro PDF 417 in VBScript using ByteScout BarCode Reader SDK What is ByteScout BarCode Reader SDK? It is the barcode decoder with support for code 39, code 128, QR Code, Datamatrix, GS1, PDF417 and all other popular barcodes. Can read barcodes from images, pdf, tiff documents and live web camera. Supports noisy and damaged documents, can split and merge pdf and tiff documents based on barcodes. Can export barcode decoder results to XML, JSON, CSV and into custom data structures.

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

##### **ReadMacroPDF417.vbs:**
    
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

Dim ImageFiles
Dim Segments
Dim OutputValue

' Input Image files
ImageFiles = Array("MacroPDFBarcode-part1.png", "MacroPDFBarcode-part2.png", "MacroPDFBarcode-part3.png")


Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
reader.BarcodeTypesToFind.PDF417 = True
                    
OutputValue = ""                    
' Loop through input files to get value
For Each FileName In ImageFiles

		WScript.Echo "Reading barcode(s) from image '" & FileName & "'"
		
		' Read barcodes
		reader.ReadFromFile FileName

		For i = 0 To reader.FoundCount - 1 

			' Write to console
			WScript.Echo "Found value '" & reader.GetFoundBarcodeValue(i) & "'"
			
			Segments = Split(reader.GetFoundBarcodeValue(i), "\")
			For Each Segment In Segments
			
				OutputValue = OutputValue & " " & Segment
			Next
		Next
Next

WScript.Echo "Consolidated output value: " & OutputValue

' Cleanup
Set reader = Nothing



```

<!-- code block end -->    

<!-- code block begin -->

##### **run.bat:**
    
```
REM running from the command line
cscript.exe ReadMacroPDF417.vbs
pause
```

<!-- code block end -->