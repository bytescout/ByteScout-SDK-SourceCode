## custom pdf417 configuration with barcode sdk in VBScript with ByteScout Premium Suite

### Learn to code in VBScript to make custom pdf417 configuration with barcode sdk with this simple How-To tutorial

The samples of source code documentation give a quick and simple method to apply a required functionality into your application. ByteScout Premium Suite was made to help with custom pdf417 configuration with barcode sdk in VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VBScript code snippet like this for ByteScout Premium Suite works best when you need to quickly implement custom pdf417 configuration with barcode sdk in your VBScript application. To use custom pdf417 configuration with barcode sdk in your VBScript project or application just copy & paste the code and then run your app! This basic programming language sample code for VBScript will do the whole work for you in implementing custom pdf417 configuration with barcode sdk in your app.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

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