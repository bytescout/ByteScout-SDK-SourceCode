## How to change fore and back color with barcode sdk in VBScript using ByteScout Barcode Suite

### Learn to code in VBScript to change fore and back color with barcode sdk with this step-by-step tutorial

An easy to understand sample source code to learn how to change fore and back color with barcode sdk in VBScript What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to change fore and back color with barcode sdk in your VBScript application.

The following code snippet for ByteScout Barcode Suite works best when you need to quickly change fore and back color with barcode sdk in your VBScript application.  Simply copy and paste in your VBScript project or application you and then run your app! This basic programming language sample code for VBScript will do the whole work for you to change fore and back color with barcode sdk.

Trial version of ByteScout Barcode Suite is available for free. Source code samples are included to help you with your VBScript app.

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

##### ****BarCodeWithCustomColor.vbs:**
    
```

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

bc.SetForeColorRGB 255,255,0
bc.SetBackColorRGB 0,0,0

bc.SaveImage "CustomColor.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "CustomColor.png", 1, false
Set shell = Nothing

```

<!-- code block end -->