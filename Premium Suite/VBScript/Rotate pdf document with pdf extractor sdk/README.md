## How to rotate pdf document with pdf extractor sdk in VBScript using ByteScout Premium Suite

### Learn to rotate pdf document with pdf extractor sdk in VBScript

The sample shows instructions and algorithm of how to rotate pdf document with pdf extractor sdk and how to make it run in your VBScript application. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can be applied to rotate pdf document with pdf extractor sdk using VBScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly rotate pdf document with pdf extractor sdk in your VBScript application.  Simply copy and paste in your VBScript project or application you and then run your app! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****RotateDocument.vbs:**
    
```
' Create Bytescout.PDFExtractor.DocumentRotator object
Set rotator = CreateObject("Bytescout.PDFExtractor.DocumentRotator")
rotator.RegistrationName = "demo"
rotator.RegistrationKey = "demo"

rotator.Rotate "..\..\sample1.pdf", "result.pdf", 0 ' 0 - rotate 90 deg, 1 - rotate 180 deg, 2 - rotate 270 deg
                
Set rotator = Nothing

WScript.Echo "Rotated document saved as 'result.pdf' file."
```

<!-- code block end -->