## How to generate barcode with barcode sdk in VBScript and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to generate barcode with barcode sdk in VBScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can generate barcode with barcode sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. Follow the instructions from scratch to work and copy the VBScript code. This basic programming language sample code for VBScript will do the whole work for you to generate barcode with barcode sdk.

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

##### ****HelloWorld.vbs:**
    
```

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' display information about Code39 symbology
msgbox "Encoding '012345' using Code39 symbology" & vbCRLF &  bc.GetValueRestrictions(0) ' 0 = Code39 symbology

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

msgbox "Saving Code39 barcode to 'Code39.png'"

bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false
Set shell = Nothing


msgbox "Encoding '012345' using Aztec symbology"

' set symbology to Aztec (2D)
bc.Symbology = 17 ' 17 = Aztec

' set barcode value to encode
bc.Value = "012345" 

' display information about Aztec symbology
msgbox "Encoding '012345' using Aztec  symbology" & vbCRLF & bc.GetValueRestrictions(17) ' 17 = Code39 symbology

bc.SaveImage "Aztec.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "aztec.png", 1, false
Set shell = Nothing


Set bc = Nothing


```

<!-- code block end -->