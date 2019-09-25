## monochrome bitmap with barcode sdk in VBScript using ByteScout Barcode Suite

### Learn to code monochrome bitmap with barcode sdk in VBScript: How-To tutorial

Every ByteScout tool includes sampleVBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout Barcode Suite was created to assist monochrome bitmap with barcode sdk in VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

The below SDK samples describe how to quickly make your application do monochrome bitmap with barcode sdk in VBScript with the help of ByteScout Barcode Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Enjoy writing a code with ready-to-use sample VBScript codes to implement monochrome bitmap with barcode sdk using ByteScout Barcode Suite.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****MonochromeBitmap.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set barcode type (symbology)
bc.Symbology = 16 ' 16 = QR Code

' set monochrome output 
bc.ProduceMonochromeImages = True

' set barcode value to encode
bc.Value = "012345"

' save image to file
bc.SaveImage "result.bmp" 

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.bmp", 1, false
Set shell = Nothing

```

<!-- code block end -->