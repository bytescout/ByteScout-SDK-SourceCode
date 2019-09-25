## custom pdf417 configuration in VBScript using ByteScout Barcode SDK

### custom pdf417 configuration in VBScript

Every ByteScout tool contains example VBScript source codes that you can find here or in the folder with installed ByteScout product. Custom pdf417 configuration in VBScript can be implemented with ByteScout Barcode SDK. ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images.

The SDK samples like this one below explain how to quickly make your application do custom pdf417 configuration in VBScript with the help of ByteScout Barcode SDK. VBScript sample code is all you need: copy and paste the code to your VBScript application's code editor, add a reference to ByteScout Barcode SDK (if you haven't added yet) and you are ready to go! VBScript application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Trial version can be obtained from our website for free. It includes this and other source code samples for VBScript.

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

##### ****SetCustomPDF417Configuration.vbs:**
    
```

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set symbology to PDF417
bc.Symbology = 13 ' 13 = PDF417 barcode type

' set barcode value to encode
bc.Value = "12345678901234567890"

' by default the SDK tries to make the barcode size as small as possible
' if we need it then we can set manual number of rows and columns

bc.Options.PDF417UseManualSize = true ' enable manual size mode
bc.Options.PDF417ColumnCount = 7 ' set max number of columns
bc.Options.PDF417RowCount = 50 ' set max number of rows

bc.CutUnusedSpace = False ' you can set it to True to cut unused space

bc.SaveImage "result.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

```

<!-- code block end -->