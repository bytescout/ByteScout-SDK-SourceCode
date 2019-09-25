## How to convert pdf to json with images with pdf extractor sdk in VBScript and ByteScout Premium Suite

### This code in VBScript shows how to convert pdf to json with images with pdf extractor sdk with this how to tutorial

These sample source codes on this page below are displaying how to convert pdf to json with images with pdf extractor sdk in VBScript. ByteScout Premium Suite can convert pdf to json with images with pdf extractor sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The SDK samples given below describe how to quickly make your application do convert pdf to json with images with pdf extractor sdk in VBScript with the help of ByteScout Premium Suite. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout Premium Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****PdfToJsonWithImages.vbs:**
    
```
' Create Bytescout.PDFExtractor.JSONExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.JSONExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample1.pdf"

' Uncomment this line to get rid of empty nodes in JSON
'extractor.PreserveFormattingOnTextExtraction = False

' Set output image format
extractor.ImageFormat = 0 ' 0 = PNG; 1 = JPEG; 2 = GIF; 3 = BMP

' Save images to external files
extractor.SaveImages = 1 ' 1 = ImageHandling.OuterFile
extractor.ImageFolder = "images" ' Folder for external images
extractor.SaveJSONToFile "result_with_external_images.json"

' Embed images into JSON as Base64 encoded string
extractor.SaveImages = 2 ' 2 = ImageHandling.Embed
extractor.SaveJSONToFile "result_with_embedded_images.json"

WScript.Echo "Done."

```

<!-- code block end -->