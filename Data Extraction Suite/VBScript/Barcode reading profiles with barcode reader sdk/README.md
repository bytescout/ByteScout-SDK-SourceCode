## barcode reading profiles with barcode reader sdk in VBScript using ByteScout Data Extraction Suite

### Learn to code barcode reading profiles with barcode reader sdk in VBScript: How-To tutorial

These source code samples are assembled by their programming language and functions they use. ByteScout Data Extraction Suite helps with barcode reading profiles with barcode reader sdk in VBScript. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

Save time on writing and testing code by using the code below and use it in your application. If you want to know how it works, then this VBScript sample code should be copied and pasted into your application’s code editor. Then just compile and run it. Enjoy writing a code with ready-to-use sample VBScript codes to add barcode reading profiles with barcode reader sdk functions using ByteScout Data Extraction Suite in VBScript.

Our website gives free trial version of ByteScout Data Extraction Suite. It includes all these source code samples with the purpose to assist you with your VBScript application implementation.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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