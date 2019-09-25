## caption font in VBScript and ByteScout Barcode SDK

### How To: tutorial on caption font in VBScript

Here you may find thousands pre-made source code pieces for easy implementation in your own programming VBScript projects. ByteScout Barcode SDK was made to help with caption font in VBScript. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

The SDK samples like this one below explain how to quickly make your application do caption font in VBScript with the help of ByteScout Barcode SDK. To do caption font in your VBScript project or application you may simply copy & paste the code and then run your app! Test VBScript sample code examples whether they respond your needs and requirements for the project.

Free trial version of ByteScout Barcode SDK is available on our website. Get it to try other samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




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