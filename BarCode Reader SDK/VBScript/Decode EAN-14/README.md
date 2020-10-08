## How to decode EAN 14 in VBScript with ByteScout BarCode Reader SDK ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format.

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

##### **ReadEAN14.vbs:**
    
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

if (WScript.Arguments.Count < 1) Then

	MsgBox "Run with the file name as the argument" & vbCRLF & vbCRLF & "ReadEAN14.vbs <InputFileName>"
 	WScript.Quit 0
End If

WScript.Echo "Reading barcode(s) from image " & WScript.Arguments(0)

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
' "EAN-14" barcode type is the same as "Code 128"
reader.BarcodeTypesToFind.Code128 = True

reader.ReadFromFile WScript.Arguments(0)

For i = 0 To reader.FoundCount - 1 

	' Write to console
	WScript.Echo "Found barcode with type '" & reader.GetFoundBarcodeType(i) & "' and value '" & reader.GetFoundBarcodeValue(i) & "'"
Next

' Cleanup
Set reader = Nothing
```

<!-- code block end -->    

<!-- code block begin -->

##### **run.bat:**
    
```
REM running from the command line
cscript.exe ReadEAN14.vbs ean14.png
pause
```

<!-- code block end -->