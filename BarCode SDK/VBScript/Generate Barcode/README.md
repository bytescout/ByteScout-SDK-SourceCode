## How to generate barcode in VBScript with ByteScout Barcode SDK

### The tutorial shows how to generate barcode in VBScript

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can generate barcode in VBScript.

VBScript code samples for VBScript developers help to speed up coding of your application when using ByteScout Barcode SDK. Follow the instructions from the scratch to work and copy the VBScript code. Further enhancement of the code will make it more vigorous.

Our website provides trial version of ByteScout Barcode SDK for free. It also includes documentation and source code samples.

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