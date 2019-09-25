## How to convert pdf to xml with images with pdf extractor sdk in VBScript using ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to convert pdf to xml with images with pdf extractor sdk in VBScript

On this page you will learn from code samples for programming in VBScript.Writing of the code to convert pdf to xml with images with pdf extractor sdk in VBScript can be executed by programmers of any level using ByteScout PDF Suite. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to convert pdf to xml with images with pdf extractor sdk in your VBScript application.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Use of ByteScout PDF Suite in VBScript is also described in the documentation included along with the product.

Trial version of ByteScout PDF Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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