## How to decode intelligent mail in VBScript using ByteScout BarCode Reader SDK ByteScout BarCode Reader SDK: the barcode decoder with support for code 39, code 128, QR Code, Datamatrix, GS1, PDF417 and all other popular barcodes. Can read barcodes from images, pdf, tiff documents and live web camera. Supports noisy and damaged documents, can split and merge pdf and tiff documents based on barcodes. Can export barcode decoder results to XML, JSON, CSV and into custom data structures.

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

##### **ReadIntelligentMail.vbs:**
    
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

	MsgBox "Run with the file name as the argument" & vbCRLF & vbCRLF & "ReadIntelligentMail.vbs <InputFileName>"
 	WScript.Quit 0
End If

WScript.Echo "Reading barcode(s) from image " & WScript.Arguments(0)

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
reader.BarcodeTypesToFind.IntelligentMail = True

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
cscript.exe ReadIntelligentMail.vbs intelligentmail.png
pause
```

<!-- code block end -->