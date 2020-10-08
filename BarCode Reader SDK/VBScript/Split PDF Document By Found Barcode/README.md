## How to split PDF document by found barcode in VBScript using ByteScout BarCode Reader SDK ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format.

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

##### **SplitDocumentByFoundBarcode.vbs:**
    
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

Dim InputFile
Dim PageRanges
Dim PageNo
Dim SplittedParts

InputFile = "Barcodes.pdf"

WScript.Echo "Reading barcode(s) from PDF document " & InputFile

' Create Bytescout.BarCodeReader.Reader instance
Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
reader.BarcodeTypesToFind.Code39 = True

'--------------------------------------------------------------------------
' NOTE: We can read barcodes from specific page to increase performance.
' For sample please refer to "Decoding barcodes from PDF by pages" program.
'--------------------------------------------------------------------------

' Find barcode in PDF document
reader.ReadFromFile InputFile

' Method 1: Split PDF document in two parts by found barcode
' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
reader.SplitDocument InputFile, "part1.pdf", "part2.pdf", reader.GetFoundBarcodePage(0) + 1

' Method 2: Extract page containing the barcode from PDF document
' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
reader.ExtractPageFromDocument InputFile, "extracted_page.pdf", reader.GetFoundBarcodePage(0) + 1

' Method 3: Split PDF document into parts in one pass.
' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.
' Create string containing page ranges to extract in the form "1-4,6-8,10-11,12-". Page numbers are 1-based!
For i = 0 To reader.FoundCount - 1 

	PageNo = reader.GetFoundBarcodePage(i)

	' Add pages before the first barcode found
	If (i = 0) And (PageNo > 0) Then
	
		PageRanges = "1"
		If (PageNo > 1) Then
		
			PageRanges = PageRanges & "-"
			PageRanges = PageRanges & PageNo
		End If
		PageRanges = PageRanges & ","
	End If
	
	' Add page with barcode
	' +1 because we skip the page with barcode and another +1 because need 1-based page numbers
	PageRanges = PageRanges & (PageNo + 1)
	
	' Add range untill the next barcode
	If (i < reader.FoundCount - 1) Then
	
		If (reader.GetFoundBarcodePage(i + 1) - PageNo > 1) Then
		
			PageRanges = PageRanges & "-"
			PageRanges = PageRanges & reader.GetFoundBarcodePage(i + 1)
		End If
		PageRanges = PageRanges & ","
	Else
		' for the last found barcode add ending "-" meaning "to the last page"
		PageRanges = PageRanges & "-"
	End If
Next 

SplittedParts = reader.SplitDocument_2(InputFile, PageRanges)

' Cleanup
Set reader = Nothing

```

<!-- code block end -->    

<!-- code block begin -->

##### **run.bat:**
    
```
REM running from the command line
cscript.exe SplitDocumentByFoundBarcode.vbs
pause
```

<!-- code block end -->