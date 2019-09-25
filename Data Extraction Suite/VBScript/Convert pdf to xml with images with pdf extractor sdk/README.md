## How to convert pdf to xml with images with pdf extractor sdk in VBScript using ByteScout Data Extraction Suite

### How to write a robust code in VBScript to convert pdf to xml with images with pdf extractor sdk with this step-by-step tutorial

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to convert pdf to xml with images with pdf extractor sdk with VBScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Data Extraction Suite for VBScript plus the guidelines and the code below will help you quickly learn how to convert pdf to xml with images with pdf extractor sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Data Extraction Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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

##### ****PdfToXmlWithImages.vbs:**
    
```
' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "../../sample1.pdf"

' Uncomment this line to get rid of empty nodes in XML
'extractor.PreserveFormattingOnTextExtraction = False

' Set output image format
extractor.ImageFormat = 0 ' 0 = PNG; 1 = JPEG; 2 = GIF; 3 = BMP

' Save images to external files
extractor.SaveImages = 1 ' 1 = ImageHandling.OuterFile
extractor.ImageFolder = "images" ' Folder for external images
extractor.SaveXMLToFile "result_with_external_images.xml"

' Embed images into XML as Base64 encoded string
extractor.SaveImages = 2 ' 2 = ImageHandling.Embed
extractor.SaveXMLToFile "result_with_embedded_images.xml"

WScript.Echo "Done."

```

<!-- code block end -->