## pdf xfa form to xml with pdf extractor sdk in VBScript with ByteScout PDF Suite

### Learn to code in VBScript to make pdf xfa form to xml with pdf extractor sdk with this simple How-To tutorial

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout PDF Suite was created to assist pdf xfa form to xml with pdf extractor sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Save time on writing and testing code by using the code below and use it in your application. To use pdf xfa form to xml with pdf extractor sdk in your VBScript project or application just copy & paste the code and then run your app! Check these VBScript sample code examples to see if they acknowledge to your needs and requirements for the project.

Visit our website to get a free trial version of ByteScout PDF Suite. Free trial contains many of source code samples to help you with your VBScript project.

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

##### ****XfaFormToXml.vbs:**
    
```
' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFAFormExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "..\..\samplexfa.pdf"

' Iterate through content types. See type descriptions below.
For i = 0 To 12 

    count = extractor.GetCount(i) ' Get count of files of given type

    For j = 0 To count - 1
        extractor.SaveToFile i, j, CStr(i) & "-" & CStr(j) & ".xml"
    Next
    
Next

WScript.Echo "XFA form data has been extracted to XML files."


' XFAFormContentType enumeration:
'
' 0 - "config" type;
' 1 - "connectionSet" type;
' 2 - "datasets" type;
' 3 - "form" type;
' 4 - "localeSet" type;
' 5 - "postamble" type;
' 6 - "preamble" type;
' 7 - "schema" type;
' 8 - "template" type;
' 9 - "xfdf" type;
' 10 - "xmpmeta" type;
' 11 - "<xdp:xdp>" opening tag type;
' 12 - "<xdp:xdp>" closing tag type.

```

<!-- code block end -->