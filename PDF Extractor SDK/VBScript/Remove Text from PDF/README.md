## How to remove text from PDF in VBScript with ByteScout PDF Extractor SDK

### How to code in VBScript to remove text from PDF with this step-by-step tutorial

ByteScout tutorials are designed to explain the code for both VBScript beginners and advanced programmers. ByteScout PDF Extractor SDK is the Software Development Kit (SDK) that is designed to help developers with data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker. It can be used to remove text from PDF using VBScript.

This rich sample source code in VBScript for ByteScout PDF Extractor SDK includes the number of functions and options you should do calling the API to remove text from PDF. Just copy and paste the code into your VBScript application’s code and follow the instruction. Enjoy writing a code with ready-to-use sample VBScript codes.

Trial version of ByteScout PDF Extractor SDK can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### ****RemoveText.vbs:**
    
```
' Create Bytescout.PDFExtractor.CSVExtractor object
Set remover = CreateObject("Bytescout.PDFExtractor.Remover")
remover.RegistrationName = "demo"
remover.RegistrationKey = "demo"

' Load sample PDF document
remover.LoadDocumentFromFile "../../sample1.pdf"

' Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
' NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
' the whole PDF text object containing the search string.
remover.RemoveText 0, "LOREM IPSUM", True, "result.pdf"
        
WScript.Echo "Modified document saved as 'result.pdf' file."
```

<!-- code block end -->