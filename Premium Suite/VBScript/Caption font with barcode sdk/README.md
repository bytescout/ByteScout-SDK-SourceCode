## caption font with barcode sdk in VBScript and ByteScout Premium Suite

### Learn to code caption font with barcode sdk in VBScript: How-To tutorial

The documentation is crafted to assist you to apply the features on your side easily. ByteScout Premium Suite was made to help with caption font with barcode sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

This rich and prolific sample source code in VBScript for ByteScout Premium Suite contains various functions and options you should do calling the API to implement caption font with barcode sdk. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Use of ByteScout Premium Suite in VBScript is also described in the documentation included along with the product.

On our website you may get trial version of ByteScout Premium Suite for free. Source code samples are included to help you with your VBScript application.

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