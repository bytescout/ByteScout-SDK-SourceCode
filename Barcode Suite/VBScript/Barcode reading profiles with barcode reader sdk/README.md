## barcode reading profiles with barcode reader sdk in VBScript with ByteScout Barcode Suite

### Simple tutorial on how to do barcode reading profiles with barcode reader sdk in VBScript

Every ByteScout tool includes sampleVBScript source codes that you can find here or in the folder with installed ByteScout product. ByteScout Barcode Suite was made to help with barcode reading profiles with barcode reader sdk in VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

This rich and prolific sample source code in VBScript for ByteScout Barcode Suite contains various functions and options you should do calling the API to implement barcode reading profiles with barcode reader sdk.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout Barcode Suite (if you haven't added yet) and you are ready to go! These VBScript sample examples can be used in one or many applications.

 If you want to try other samples for VBScript then free trial version of ByteScout Barcode Suite is available on our website.

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

##### ****Profiles.vbs:**
    
```
' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Reader in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

' Create Bytescout.PDFExtractor.TextExtractor object
Set reader1 = CreateObject("Bytescout.BarCodeReader.Reader")
reader1.RegistrationName = "demo"
reader1.RegistrationKey = "demo"

' Apply predefined profiles:
' enable Code39;
' enable EAN-13;
' render PDF at 150 DPI resoultion.
reader1.Profiles = "code39, ean13, pdf150dpi"

' Decode and show barcodes from sample1.pdf
reader1.ReadFromFile "sample1.pdf"
For i = 0 To reader1.FoundCount - 1
    WScript.Echo "Found type " & reader1.GetFoundBarcodeType(i) & " barcode with value " & reader1.GetFoundBarcodeValue(i) & """"
Next


Set reader2 = CreateObject("Bytescout.BarCodeReader.Reader")
reader2.RegistrationName = "demo"
reader2.RegistrationKey = "demo"

' Load and apply custom profiles
reader2.LoadProfiles "profiles.json"
reader2.Profiles = "negative-distorted-datamatrix"

' Decode and show barcodes from sample2.png
reader2.ReadFromFile "sample2.png"
For i = 0 To reader2.FoundCount - 1
    WScript.Echo "Found type " & reader2.GetFoundBarcodeType(i) & " barcode with value " & reader2.GetFoundBarcodeValue(i) & """"
Next

```

<!-- code block end -->