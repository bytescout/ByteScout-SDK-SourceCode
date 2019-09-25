## pdf xfa form to xml with pdf extractor sdk in VBScript using ByteScout Premium Suite

### How to apply ByteScout Premium Suite for pdf xfa form to xml with pdf extractor sdk in VBScript

The samples of source code documentation give a quick and simple method to apply a required functionality into your application. ByteScout Premium Suite was made to help with pdf xfa form to xml with pdf extractor sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The below SDK samples describe how to quickly make your application do pdf xfa form to xml with pdf extractor sdk in VBScript with the help of ByteScout Premium Suite. Follow the steps-by-step instructions from the scratch to work and copy and paste code for VBScript into your editor. Further improvement of the code will make it more robust.

ByteScout Premium Suite free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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