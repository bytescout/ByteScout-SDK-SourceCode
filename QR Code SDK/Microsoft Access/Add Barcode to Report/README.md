## How to add barcode to report in Microsoft Access and ByteScout QR Code

### Write code in Microsoft Access to add barcode to report with this step-by-step tutorial

The sample source codes on this page shows how to add barcode to report in Microsoft Access. Want to add barcode to report in your Microsoft Access app? ByteScout QR Code is designed for it. ByteScout QR Code is QR Code generation library. It provides full control on the quality, features and encoding. Can embed logo image right into QR Code itself. Batch barcode generation, and many special features like vCard or URL encoding are also supported.

You will save a lot of time on writing and testing code as you may just take the Microsoft Access code from ByteScout QR Code for add barcode to report below and use it in your application. In your Microsoft Access project or application you may simply copy & paste the code and then run your app! Test Microsoft Access sample code examples whether they respond your needs and requirements for the project.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20QR%20Code%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20QR%20Code%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=A5hB9ul3tX0](https://www.youtube.com/watch?v=A5hB9ul3tX0)




<!-- code block begin -->

##### ****Barcode in Report.txt:**
    
```
1. Add reference to "ByteScout QRCode SDK" ActiveX object to your database project (in menu Tools->References).
2. Put Picture object on the Details section of the report.
3. Handle the Format event of the Details section and set barcode image to the Picture control.

Option Compare Database

Dim BarCodeGenerator

Private Sub Report_Open(Cancel As Integer)

    ' Setup the barcode generator
    Set BarCodeGenerator = CreateObject("Bytescout.BarCode.QRCode")
    BarCodeGenerator.RegistrationName = "demo"
    BarCodeGenerator.RegistrationKey = "demo"
    
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