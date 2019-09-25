## caption font with barcode sdk in VBScript with ByteScout Barcode Suite

### Simple tutorial on how to do caption font with barcode sdk in VBScript

Here you may get thousands pre-made source code samples for simple implementation in your own programming VBScript projects. ByteScout Barcode Suite was created to assist caption font with barcode sdk in VBScript. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

Save time on writing and testing code by using the code below and use it in your application. To use caption font with barcode sdk in your VBScript project or application just copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes to add caption font with barcode sdk functions using ByteScout Barcode Suite in VBScript.

ByteScout Barcode Suite free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

##### ****Caption Font.vbs:**
    
```
' Create Barcode object
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set barcode type to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value 
bc.Value = "012345" 

' Change caption font
bc.SetCaptionFont "Times New Roman", 24

' Save barcode 
bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false


```

<!-- code block end -->