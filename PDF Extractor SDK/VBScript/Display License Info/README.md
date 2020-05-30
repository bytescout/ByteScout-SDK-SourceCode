## How to display license info in VBScript and ByteScout PDF Extractor SDK ByteScout PDF Extractor SDK: the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

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

##### **DisplayLicenseInfo.vbs:**
    
```
' LicenseInfo can be retrieved by createing instance of any extractor class,
' Because all of them are derived from BaseExtractor
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set license Info
Set licenseInfo = extractor.LicenseInfo

outputMsg = "===============================" + vbCRLF
outputMsg = outputMsg + "======== License Info =========" + vbCRLF
outputMsg = outputMsg + "===============================" + vbCRLF

outputMsg = outputMsg + "License type: " & licenseInfo.LicenseType & vbCRLF
outputMsg = outputMsg + "License limit type: " & licenseInfo.LimitType & vbCRLF
outputMsg = outputMsg + "Limit of license units: " & licenseInfo.Limit & vbCRLF
outputMsg = outputMsg + "License limit term: " & licenseInfo.LimitTerm & vbCRLF
outputMsg = outputMsg + "No of remaining license units: " & licenseInfo.Remainder & vbCRLF
outputMsg = outputMsg + "Update expires On: " & licenseInfo.UpdatesExpireOn & vbCRLF

outputMsg = outputMsg + "===============================" + vbCRLF

MsgBox outputMsg

Set extractor = Nothing
```

<!-- code block end -->