## How to add barcode in report with barcode sdk in Microsoft Access with ByteScout Premium Suite

### Step-by-step tutorial on how to add barcode in report with barcode sdk in Microsoft Access

The documentation is designed for a specific purpose to help you to apply the features on your side. ByteScout Premium Suite: the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can add barcode in report with barcode sdk in Microsoft Access.

 These Microsoft Access code samples for Microsoft Access guide developers to speed up coding of the application when using ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for Microsoft Access below into your code editor with your app, compile and run your application. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

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