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
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **GeneralExample.vbs:**
    
```
' This example demonstrates document data parsing to JSON and YAML formats.

templatesDocument = ".\SampleTicket.yml"
inputDocument = ".\SampleTicket.pdf"


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

<!-- code block begin -->

##### **SampleTicket.yml:**
    
```
templateName: MakeMyTrip Booking
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords:
  - MakeMyTrip
  - Eticket-Dom-Flight
objects:
- name: BookingNo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 198.75
    - 85.625
    - 96.875
    - 12.500001
    pageIndex: 0
- name: BookingDate
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 133.125
    - 97.5000076
    - 78.75
    - 12.500001
    pageIndex: 0
- name: DepartureFrom
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 153
    - 176
    - 77
    - 8.5
    pageIndex: 0
- name: ArrivalTo
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 285
    - 176
    - 84
    - 8.5
    pageIndex: 0
- name: DepartureAt
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 153.75
    - 187.5
    - 123.75
    - 10.625
    pageIndex: 0
- name: ArrivalAt
  objectType: field
  fieldProperties:
    fieldType: rectangle
    dataType: date
    rectangle:
    - 288.125
    - 186.875
    - 125.625008
    - 11.25
    pageIndex: 0
- name: FlightType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 433.5
    - 159.5
    - 68
    - 10.5
    pageIndex: 0
- name: FlightDuration
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 474.375031
    - 170.625
    - 30.0000019
    - 10
    pageIndex: 0
- name: CabinType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 463.125031
    - 194.375015
    - 51.25
    - 10
    pageIndex: 0
- name: PassengerName
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 85
    - 238.125
    - 93.125
    - 14.375
    pageIndex: 0
- name: PassengerType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 229.375015
    - 238.125
    - 31.25
    - 13.75
    pageIndex: 0
- name: AirlinePNR
  objectType: field
  fieldProperties:
    fieldType: rectangle
    rectangle:
    - 375
    - 240.000015
    - 46.25
    - 13.75
    pageIndex: 0


```

<!-- code block end -->