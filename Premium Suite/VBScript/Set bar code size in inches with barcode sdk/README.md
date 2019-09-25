## How to set bar code size in inches with barcode sdk in VBScript and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set bar code size in inches with barcode sdk in VBScript

Quickly learn how to set bar code size in inches with barcode sdk in VBScript with this sample source code. ByteScout Premium Suite: the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can set bar code size in inches with barcode sdk in VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to set bar code size in inches with barcode sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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

##### ****FitIntoSizeInInches.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set symbology to PDF417
bc.Symbology = 13 ' 13 = PDF417 barcode type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying a square the barcode will be fitted into 5x2 inches square
' Last parameter is the Measure Unit: Inch (2) Specifies the inch as the unit of measure. 
bc.FitInto_3 5, 2, 2

bc.CutUnusedSpace = False ' you can set it to True to cut unused space

bc.SaveImage "result.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

```

<!-- code block end -->