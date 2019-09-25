## PDF XFA form to XML in VBScript and ByteScout PDF Extractor SDK

### PDF XFA form to XML in VBScript

ByteScout tutorials explain the material for programmers who use VBScript. ByteScout PDF Extractor SDK was made to help with PDF XFA form to XML in VBScript. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout PDF Extractor SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enhanced documentation and tutorials are available along with installed ByteScout PDF Extractor SDK if you'd like to dive deeper into the topic and the details of the API.

On our website you may get trial version of ByteScout PDF Extractor SDK for free. Source code samples are included to help you with your VBScript application.

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