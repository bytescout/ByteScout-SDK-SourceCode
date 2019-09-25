## barcode reading profiles with barcode reader sdk in VBScript with ByteScout Premium Suite

### Learn barcode reading profiles with barcode reader sdk in VBScript

These source code samples are assembled by their programming language and functions they use. ByteScout Premium Suite was created to assist barcode reading profiles with barcode reader sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

VBScript code snippet like this for ByteScout Premium Suite works best when you need to quickly implement barcode reading profiles with barcode reader sdk in your VBScript application. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. VBScript application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

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