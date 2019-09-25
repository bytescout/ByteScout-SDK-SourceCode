## monochrome bitmap with barcode sdk in VBScript with ByteScout Premium Suite

### Learn monochrome bitmap with barcode sdk in VBScript

These sample source codes given below will show you how to handle a complex task, for example, monochrome bitmap with barcode sdk in VBScript. ByteScout Premium Suite was made to help with monochrome bitmap with barcode sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Premium Suite. To use monochrome bitmap with barcode sdk in your VBScript project or application just copy & paste the code and then run your app! Updated and detailed documentation and tutorials are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

ByteScout Premium Suite free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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