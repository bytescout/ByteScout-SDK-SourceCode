## parsing and reading data from airline tickets in VBScript and VB6 and ByteScout Document Parser SDK

### Build parsing and reading data from airline tickets in VBScript and VB6: ### Step-by-step instructions on how to do parsing and reading data from airline tickets in VBScript and VB6

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout Document Parser SDK was created to assist parsing and reading data from airline tickets in VBScript and VB6. ByteScout Document Parser SDK is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

 Want to speed up the application development? Then this VBScript and VB6, code samples for VBScript and VB6, developers help to speed up the application development and writing a code when using ByteScout Document Parser SDK. To use parsing and reading data from airline tickets in your VBScript and VB6 project or application just copy & paste the code and then run your app! Check these VBScript and VB6 sample code examples to see if they acknowledge to your needs and requirements for the project.

 If you want to try other samples for VBScript and VB6 then free trial version of ByteScout Document Parser SDK is available on our website.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **GeneralExample.vbs:**
    
```
' This example demonstrates document data parsing to JSON and YAML formats.

templatesDocument = "..\..\_Sample Templates\SampleTicket.yml"
inputDocument = "..\..\SampleTicket.pdf"


' Create DocumentParser object
Set documentParser = CreateObject("Bytescout.DocumentParser.DocumentParser")
documentParser.RegistrationName = "demo"
documentParser.RegistrationKey = "demo"

' Loading template...
documentParser.AddTemplate templatesDocument

' Parse document data in JSON format
documentParser.ParseDocument inputDocument, "output1.json", 0 ' 0 = OutputFormat.JSON

' Parse document data in YAML format
documentParser.ParseDocument inputDocument, "output2.yaml", 1 ' 1 = OutputFormat.YAML

WScript.Echo "Parsed data saved as 'output1.json' and 'output2.yaml'."

Set documentParser = Nothing


```

<!-- code block end -->