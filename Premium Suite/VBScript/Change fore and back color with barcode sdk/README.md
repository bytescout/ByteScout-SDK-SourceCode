## How to change fore and back color with barcode sdk in VBScript and ByteScout Premium Suite

### How to write a robust code in VBScript to change fore and back color with barcode sdk with this step-by-step tutorial

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout Premium Suite can change fore and back color with barcode sdk. It can be applied from VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Premium Suite for change fore and back color with barcode sdk below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further improvement of the code will make it more robust.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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