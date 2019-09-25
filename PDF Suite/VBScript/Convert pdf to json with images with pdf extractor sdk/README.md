## How to convert pdf to json with images with pdf extractor sdk in VBScript with ByteScout PDF Suite

### How to write a robust code in VBScript to convert pdf to json with images with pdf extractor sdk with this step-by-step tutorial

The sample shows instructions and algorithm of how to convert pdf to json with images with pdf extractor sdk and how to make it run in your VBScript application. ByteScout PDF Suite: the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can convert pdf to json with images with pdf extractor sdk in VBScript.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout PDF Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample VBScript codes.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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