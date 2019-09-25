## How to set barcode size with barcode sdk in VBScript and ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set barcode size with barcode sdk in VBScript

The documentation is designed for a specific purpose to help you to apply the features on your side. Want to set barcode size with barcode sdk in your VBScript app? ByteScout Barcode Suite is designed for it. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

Want to save time? You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Barcode Suite for set barcode size with barcode sdk below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instructions. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for VBScript.

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

##### ****FitInto.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Display information about Code39 symbology

msgbox "Easiest way to specify barcode size is to use FitInto_3(width, height, unitOfMeasure) method." & vbCRLF & "Let's generate barcode of 500x300 pixels."

' Set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying dimensions the barcode will be fit into.
' 3rd parameter is the unit of measure: 0 - Pixel, 1 - Point (1/72 inch), 2 - Inch, 3 - document unit (1/300 inch), 4 - Millimeter, 5 - Centimeter, 6 - Twip(1/20 inch).
' We use 3rd parameter as 0 (Pixel).
bc.FitInto_3 500, 300, 0

msgbox "Generated barcode is saved into 'result.png' file"

bc.SaveImage "result.png"

Set bc = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

```

<!-- code block end -->