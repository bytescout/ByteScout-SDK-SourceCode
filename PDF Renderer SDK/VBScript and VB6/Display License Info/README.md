## How to display license info in VBScript and VB6 and ByteScout PDF Renderer SDK ByteScout PDF Renderer SDK is the SDK for rendering of PDF into thumbnails and images in high quality. Provides various functions like batch processing, PNG, TIFF output. Can be used from web and desktop applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Renderer%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Renderer%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=eenhl7106lA](https://www.youtube.com/watch?v=eenhl7106lA)




<!-- code block begin -->

##### **DisplayLicenseInfo.vbs:**
    
```
' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Set license Info
Set licenseInfo = renderer.LicenseInfo

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

Set renderer = Nothing
```

<!-- code block end -->