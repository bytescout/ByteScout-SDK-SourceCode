## How to add barcode in report with barcode sdk in Microsoft Access with ByteScout Barcode Suite

### How to write a robust code in Microsoft Access to add barcode in report with barcode sdk with this step-by-step tutorial

Source code documentation samples give simple and easy method to install a needed feature into your application. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to add barcode in report with barcode sdk using Microsoft Access.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for Microsoft Access plus the guidelines and the code below will help you quickly learn how to add barcode in report with barcode sdk. This Microsoft Access sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Use of ByteScout Barcode Suite in Microsoft Access is also described in the documentation included along with the product.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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

##### ****Barcode in Report.vb:**
    
```
' 1. Add reference to "Bytescout Barcode SDK" ActiveX object to your database project (in menu Tools->References).
' 2. Put Picture object on the Details section of the report.
' 3. Handle the Format event of the Details section and set barcode image to the Picture control.

Option Compare Database

Dim BarCodeGenerator

Private Sub Report_Open(Cancel As Integer)

    ' Setup the barcode generator
    Set BarCodeGenerator = CreateObject("Bytescout.BarCode.Barcode")
    BarCodeGenerator.RegistrationName = "demo"
    BarCodeGenerator.RegistrationKey = "demo"
    BarCodeGenerator.Symbology = 16 ' QRCode
    
End Sub

Private Sub Detail_Format(Cancel As Integer, FormatCount As Integer)

    ' Set barcode value
    BarCodeGenerator.Value = Me.Field1
    ' Set generated barcode image to Picture object
    Me.BarcodeImage.PictureData = BarCodeGenerator.GetImageBytesPNG()
           
End Sub

Private Sub Report_Close()

    ' Cleanup
    Set BarCodeGenerator = Nothing

End Sub

```

<!-- code block end -->